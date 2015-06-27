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
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace IPChanger.UI {

  public partial class MainWindow : Form {

    public MainWindow() {
      InitializeComponent();
      MachineName.Text = Program.CompName;
      foreach(var nic in NetworkInterface.GetAllNetworkInterfaces()) {
        NetAdapter.Items.Add(nic.Name);
      }
      NetAdapter.SelectedIndex = NetAdapter.FindString(Program.NetName);
      LoadData();
    }

    void LoadData() {
      foreach(Control table in DataTable.Controls) {
        if(!table.Name.Contains("Info")) {
          foreach(Control child in table.Controls) {
            if(!child.Name.Contains("dot")) {
              TextBox txt = (TextBox)child;
              var tmp = Program.DefaultProperties[GetPropertyIndex(txt.Name)][GetIndex(txt.Name)];
              if(tmp.Contains("x")) {
                txt.Text = "";
                txt.Enabled = true;
              } else {
                txt.Text = tmp;
                txt.Enabled = false;
              }
            }
          }
        }
      }
    }

    string ValidateText(string txt) {
      var tmp = "x";
      if(txt.Length > 0) {
        tmp = txt;
        foreach(var c in txt.ToCharArray()) {
          if(!Char.IsDigit(c)) {
            tmp = "x";
            break;
          }
        }
      }
      return tmp;
    }

    string SaveChangeText(int propertyIndex, int index, string text) {
      var tmp = ValidateText(text);
      Console.WriteLine("Data to be saved: " + tmp);
      Program.DefaultProperties[propertyIndex][index] = tmp;
      return tmp == "x" ? "" : tmp;
    }

    int GetPropertyIndex(string name) {
      int i = 0;
      name = name.Remove(name.Length - 1);
      name = name.ToUpper();
      var names = Enum.GetNames(typeof(IPProperties));
      for(; i < names.Length;) {
        if(names[i] == name) {
          break;
        } else {
          i++;
        }
      }
      return i;
    }

    int GetIndex(string name) {
      return Convert.ToInt32(name.ToCharArray()[name.Length - 1] + "") - 1;
    }

    #region EventHandlers

    protected void OnTextChanged(object sender, EventArgs args) {
      TextBox e = (TextBox)sender;
      e.Text = SaveChangeText(GetPropertyIndex(e.Name), GetIndex(e.Name), e.Text);
    }

    private void OnSaveCurrent(object sender, EventArgs e) {
      Program.Save();
      LoadData();
    }

    private void OnTrashCurrent(object sender, EventArgs e) {
      Program.Reset();
      LoadData();
    }

    private void OnAdapterChange(object sender, EventArgs e) {
      Program.NetName = NetAdapter.SelectedItem.ToString();
    }

    private void OnDHCPClick(object sender, EventArgs e) {
      new LogerWindow(ConsoleHandler.GetDHCP()).Show();
    }

    private void OnStaticClick(object sender, EventArgs e) {
      new LogerWindow(ConsoleHandler.GetStatic()).Show();
    }
    #endregion
  }
}