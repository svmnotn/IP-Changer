// Program.cs
//
// Author:
//       Victor M. Suarez <svmnotn@gmail.com>
//
// Copyright (c) 2015 Victor M. Suarez
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using Gtk;
using System;
using System.IO;
using System.Reflection;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Permissions;

namespace IPChanger
{
  using UI;

  public class Program
  {
    public static string[][] DefaultProperties = new string[5][];
    public static string CompName;
    public static string NetName;
    static string Location;

    public static void Main(string[] args)
    {
      Setup();
      Application.Init();
      MainWindow win = new MainWindow();
      win.Show();
      Application.Run();
    }

    static void Setup()
    {
      DefaultProperties[0] = new string[4];
      DefaultProperties[1] = new string[4];
      DefaultProperties[2] = new string[4];
      DefaultProperties[3] = new string[4];
      DefaultProperties[4] = new string[4];
      Location = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\prop.txt";
      CompName = Environment.MachineName;
      foreach(var nic in NetworkInterface.GetAllNetworkInterfaces()) {
        if(nic.OperationalStatus == OperationalStatus.Up) {
          NetName = nic.Name;
          Load();
          return;
        }
      }

    }

    public static void Load()
    {
      if(File.Exists(Location)) {
        Console.WriteLine("Loading");
        string[] lines = File.ReadAllLines(Location);
        foreach(var s in lines) {
          if(s.Contains("=")) {
            string[] parts = s.Split('=');
            var subParts = parts[1].Split('.');
            switch(parts[0]) {
              case "IP":
                SetSubArray(DefaultProperties[(int)Properties.IP], subParts);
                break;
              case "MASK":
                SetSubArray(DefaultProperties[(int)Properties.MASK], subParts);
                break;
              case "GATE":
                SetSubArray(DefaultProperties[(int)Properties.GATE], subParts);
                break;
              case "DNS1":
                SetSubArray(DefaultProperties[(int)Properties.DNS1], subParts);
                break;
              case "DNS2":
                SetSubArray(DefaultProperties[(int)Properties.DNS2], subParts);
                break;
            }
          }
        }
      } else {
        Reset();
      }
    }

    static void SetSubArray(string[] arr, string[] subarr)
    {
      for(int i = 0; i < arr.Length; i++) {
        arr[i] = subarr[i];
      }
    }

    public static void Save()
    {
      Console.WriteLine("Saving");
      string[] def = {("IP=" + ConsoleHandler.ArrayToString(DefaultProperties[(int)Properties.IP])),
        ("MASK=" + ConsoleHandler.ArrayToString(DefaultProperties[(int)Properties.MASK])),
        ("GATE=" + ConsoleHandler.ArrayToString(DefaultProperties[(int)Properties.GATE])),
        ("DNS1=" + ConsoleHandler.ArrayToString(DefaultProperties[(int)Properties.DNS1])),
        ("DNS2=" + ConsoleHandler.ArrayToString(DefaultProperties[(int)Properties.DNS2]))
      };
      File.WriteAllLines(Location, def);
    }

    public static void Reset()
    {
      for(int i = 0; i < 5; i++) {
        for(int j = 0; j < 4; j++) {
          DefaultProperties[i][j] = "x";
        }
      }
      Save();
    }
  }
}