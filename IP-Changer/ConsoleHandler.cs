// ConsoleHandler.cs
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
using System;
using System.Diagnostics;

namespace IPChanger
{
  public class ConsoleHandler
  {
    public static void RunCommand(string cmd)
    {
      Console.WriteLine(cmd);
      Process process = new Process();
      ProcessStartInfo startInfo = new ProcessStartInfo();
      startInfo.CreateNoWindow = false;
      startInfo.WindowStyle = ProcessWindowStyle.Normal;
      startInfo.FileName = "netsh.exe";
      startInfo.Arguments = cmd;
      startInfo.UseShellExecute = true;
      process.StartInfo = startInfo;
      process.Start();
    }

    public static void SetDHCP()
    {
      RunCommand("int ipv4 set address name=\"" + Program.NetName + "\" source=dhcp");
      RunCommand("int ipv4 set dnsservers name=\"" + Program.NetName + "\" source=dhcp");
    }

    public static void SetStatic()
    {
      string cmd = "int ipv4 set address name=\"";
      cmd += Program.NetName;
      cmd += "\" source=static address=";
      cmd += ArrayToString(Program.DefaultProperties[(int)Properties.IP]);
      cmd += " mask=";
      cmd += ArrayToString(Program.DefaultProperties[(int)Properties.MASK]);
      cmd += " gateway=";
      cmd += ArrayToString(Program.DefaultProperties[(int)Properties.GATE]);
      RunCommand(cmd);
      cmd = "int ipv4 set dns name=\"";
      cmd += Program.NetName;
      cmd += "\" source=static address=";
      cmd += ArrayToString(Program.DefaultProperties[(int)Properties.DNS1]);
      cmd += " register=primary validate=no";
      RunCommand(cmd);
      cmd = "int ipv4 add dns name=\"";
      cmd += Program.NetName;
      cmd += "\" source=static address=";
      cmd += ArrayToString(Program.DefaultProperties[(int)Properties.DNS2]);
      cmd += " index=2";
      RunCommand(cmd);
    }

    public static string ArrayToString(string[] arr)
    {
      var s = "";
      foreach(var p in arr) {
        s += p + ".";
      }
      return s.Remove(s.LastIndexOf('.'));
    }
  }
}