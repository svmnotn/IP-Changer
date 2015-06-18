//Main.cs
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
using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.Collections.Generic;

namespace IPChanger
{
    class MainClass
    {
        static string[] defaults = new string[5];
        static Dictionary<string,string> cusProps = new Dictionary<string,string>();

        public static void Main(string[] args)
        {
            if(LoadPropFile()) {
                Console.WriteLine("This computer is named: " + Environment.MachineName);
                Console.WriteLine("DHCP[0] or Static[1]?");
                var dhcp = Console.ReadLine();
                if(dhcp == "0") {
                    Console.WriteLine("Setting the computer to DHCP");
                    SetDHCP();
                    Console.WriteLine("Done.");
                    Console.ReadLine();
                } else {
                    if(cusProps.Count > 0) {
                        Console.WriteLine("Please input the desired changes as asked.");
                        GetCustomFromUser();
                    }
                    SetStatic();
                    Console.WriteLine("Done.");
                    Console.ReadLine();
                }
            }
        }

        static bool LoadPropFile()
        {
            var loc = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            loc += "\\prop.txt";
            if(File.Exists(loc)) {
                int properties = 0;
                string[] lines = File.ReadAllLines(loc);
                foreach(var s in lines) {
                    if(s.Contains("=")) {
                        string[] parts = s.Split('=');
                        switch(parts[0]) {
                            case "IP":
                                properties++;
                                defaults[(int)Properties.IP] = parts[1];
                                break;
                            case "MASK":
                                properties++;
                                defaults[(int)Properties.MASK] = parts[1];
                                break;
                            case "GATE":
                                properties++;
                                defaults[(int)Properties.GATE] = parts[1];
                                break;
                            case "DNS1":
                                properties++;
                                defaults[(int)Properties.DNS1] = parts[1];
                                break;
                            case "DNS2":
                                properties++;
                                defaults[(int)Properties.DNS2] = parts[1];
                                break;
                            default:
                                cusProps.Add(parts[0], parts[1]);
                                break;
                        }
                    }
                }
                if(properties < 5) {
                    return Error("ERROR: Missing default properties in prop.txt.\nPlease add these before continuing.");
                } else if(properties > 5) {
                        return Error("ERROR: Too many default properties in prop.txt.\nPlease remove the extras before continuing.");
                    }
            } else {
                Console.WriteLine("WARNING: prop.txt did not exist creating one.");
                var tmp = File.Create(loc);
                tmp.Close();
                string[] def = {"IP=0.0.0.0",
                                "MASK=255.0.0.0",
                                "GATE=0.0.0.0",
                                "DNS1=0.0.0.0",
                                "DNS2=0.0.0.0"};
                File.AppendAllLines(loc, def);
                return Error("prop.txt has been created.\nPlease exit the program and make the desired changes before using this program again.");
            }
            return true;
        }

        static bool Error(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadLine();
            return false;
        }

        static void GetCustomFromUser()
        {
            var tmp = new Dictionary<string,string>();
            //GET USER TO INPUT REAL DATA
            foreach(var prop in cusProps.Keys) {
                string name;
                cusProps.TryGetValue(prop, out name);
                Console.WriteLine("Please input " + name);
                tmp.Add(prop, Console.ReadLine());
            }
            LoadProps(tmp);
        }

        static void LoadProps(Dictionary<string,string> userProps)
        {
            for(int i = 0; i < defaults.Length; i++) {
                foreach(var id in userProps.Keys) {
                    if(defaults[i].Contains(id)) {
                        string val;
                        userProps.TryGetValue(id, out val);
                        defaults[i] = defaults[i].Replace(id, val);
                    }
                }
            }
        }

        static void SetDHCP()
        {
            RunCommand("int ipv4 set address name=\"Local Area Connection\" source=dhcp");
            RunCommand("int ipv4 set dnsservers name=\"Local Area Connection\" source=dhcp");
        }

        static void SetStatic()
        {
            string cmd = "int ipv4 set address name=\"Local Area Connection\" source=static address=";
            cmd += defaults[(int)Properties.IP];
            cmd += " mask=";
            cmd += defaults[(int)Properties.MASK];
            cmd += " gateway=";
            cmd += defaults[(int)Properties.GATE];
            RunCommand(cmd);
            cmd = "int ipv4 set dns name=\"Local Area Connection\" source=static address=";
            cmd += defaults[(int)Properties.DNS1];
            cmd += " register=primary validate=no";
            RunCommand(cmd);
            cmd = "int ipv4 add dns name=\"Local Area Connection\" address=";
            cmd += defaults[(int)Properties.DNS2];
            cmd += " index=2";
            RunCommand(cmd);
        }

        static void RunCommand(string cmd)
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
    }
}