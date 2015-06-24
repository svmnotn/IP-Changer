// MainWindow.cs
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
using System.Net.NetworkInformation;
using IPChanger;

namespace IPChanger.UI
{
  public partial class MainWindow: Window
  {
    public MainWindow() : base(WindowType.Toplevel)
    {
      Build();
      SetDefaults();
    }

    void SetDefaults()
    {
      MachineName.LabelProp = Program.CompName;
      NetworkName.LabelProp = Program.NetName;
      //Loop over all children, each child should be 1 to 1 to the default properties
      for(int i = 0; i < PropertyVBox.Children.Length; i++) {
        HBox prop = (HBox)PropertyVBox.Children[i];
        int j = 0;
        foreach(var child in prop.Children) {
          //For each child that is an Entry check if it needs to be changed
          if(child is Entry && j < 4) {
            Entry c = (Entry)child;
            var tmp = Program.DefaultProperties[i][j];
            if(!tmp.Contains("x")) {
              c.Text = tmp;
              c.IsEditable = false;
              c.CanFocus = false;
              c.HasFrame = false;
            } else {
              c.Text = "";
              c.IsEditable = true;
              c.CanFocus = true;
              c.HasFrame = true;
            }
            j++;
          } else if(j == 4) {
            j = 0;
          }
        }
      }
    }

    string ChangeText(int i, int j, string text)
    {
      var tmp = "x";
      if(text.Length > 0) {
        tmp = text;
        foreach(var c in text.ToCharArray()) {
          if(!Char.IsDigit(c)) {
            tmp = "x";
            break;
          }
        }
      }
      Program.DefaultProperties[i][j] = tmp;
      return tmp == "x" ? "" : tmp;
    }

    #region EventHandlers

    protected void OnEntryChanged(object sender, EventArgs args)
    {
      Entry e = (Entry)sender;
      var name = e.Name;
      int i = 0;
      int j = 0;
      if(Char.IsDigit(name.ToCharArray()[name.Length - 1])) {
        j = Convert.ToInt32(name.ToCharArray()[name.Length - 1] + "");
        name = name.Remove(name.Length - 1);
      }
      name = name.ToUpper();
      var names = Enum.GetNames(typeof(Properties));
      for(; i < names.Length;) {
        if(names[i] == name) {
          break;
        } else {
          i++;
        }
      }
      e.Text = ChangeText(i, j, e.Text);
    }

    protected void OnDHCPClicked(object sender, EventArgs e)
    {
      ConsoleHandler.SetDHCP();
      var msg = new Done("Computer set to DHCP");
      msg.Run();
      msg.Destroy();
      Application.Quit();
    }

    protected void OnStaticClicked(object sender, EventArgs e)
    {
      ConsoleHandler.SetStatic();
      var msg = new Done("Computer set to Static");
      msg.Run();
      msg.Destroy();
      OnDeleteEvent(null, new DeleteEventArgs());
    }

    protected void OnNew(object sender, EventArgs e)
    {
      Sure s = new Sure("This will replace the current file with a new one, do you whish to continue?");
      if(s.Run() == (int)ResponseType.Yes) {
        Program.Reset();
        SetDefaults();
      }
      s.Destroy();
    }

    protected void OnSave(object sender, EventArgs e)
    {
      Program.Save();
      SetDefaults();
    }

    protected void OnLoad(object sender, EventArgs e)
    {
      Program.Load();
      SetDefaults();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
      Application.Quit();
      a.RetVal = true;
    }

    #endregion
  }
}