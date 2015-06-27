//The MIT License (MIT)
//
//Copyright (c) 2015 Victor M. Suarez
//
//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:
//
//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.
//
//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.
using System;
using System.Diagnostics;

namespace IPChanger {
  public class ConsoleHandler {
    public static string RunCommand(string cmd) {
      var ret = cmd + Environment.NewLine + "-----------------------" + Environment.NewLine;
      Process process = new Process();
      ProcessStartInfo startInfo = new ProcessStartInfo();
      startInfo.UseShellExecute = false;
      startInfo.CreateNoWindow = true;
      startInfo.LoadUserProfile = true;
      startInfo.RedirectStandardOutput = true;
      startInfo.RedirectStandardError = true;
      startInfo.RedirectStandardInput = true;
      startInfo.FileName = "netsh.exe";
      startInfo.Arguments = cmd;
      process.StartInfo = startInfo;
      process.Start();
      ret += process.StandardOutput.ReadToEnd();
      ret += "-----------------------" + Environment.NewLine;
      return ret;
    }

    public static string[] GetDHCP() {
      return new string[] {"interface ip set address name=\"" + Program.NetName + "\" source=dhcp",
                           "interface ip set dnsservers name=\"" + Program.NetName + "\" source=dhcp" };
    }

    public static string[] GetStatic() {
      var ret = new string[3];
      var cmd = "interface ip set address name=\"";
      cmd += Program.NetName;
      cmd += "\" source=static address=";
      cmd += ArrayToString(Program.DefaultProperties[(int)IPProperties.IP]);
      cmd += " mask=";
      cmd += ArrayToString(Program.DefaultProperties[(int)IPProperties.MASK]);
      cmd += " gateway=";
      cmd += ArrayToString(Program.DefaultProperties[(int)IPProperties.GATE]);
      ret[0] = cmd;
      cmd = "interface ip set dns name=\"";
      cmd += Program.NetName;
      cmd += "\" source=static address=";
      cmd += ArrayToString(Program.DefaultProperties[(int)IPProperties.DNS1]);
      cmd += " register=primary validate=no";
      ret[1] = cmd;
      cmd = "interface ip add dns name=\"";
      cmd += Program.NetName;
      cmd += "\" address=";
      cmd += ArrayToString(Program.DefaultProperties[(int)IPProperties.DNS2]);
      cmd += " index=2";
      ret[2] = cmd;
      return ret;
    }

    public static string ArrayToString(string[] arr) {
      var s = "";
      foreach(var p in arr) {
        s += p + ".";
      }
      return s.Remove(s.LastIndexOf('.'));
    }
  }
}