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
namespace IPChanger.UI {

  partial class MainWindow {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.MainTable = new System.Windows.Forms.TableLayoutPanel();
      this.InfoTable = new System.Windows.Forms.TableLayoutPanel();
      this.InfoMachineName = new System.Windows.Forms.Label();
      this.InfoNetAdapter = new System.Windows.Forms.Label();
      this.MachineName = new System.Windows.Forms.Label();
      this.NetAdapter = new System.Windows.Forms.ComboBox();
      this.DataTable = new System.Windows.Forms.TableLayoutPanel();
      this.dns2Table = new System.Windows.Forms.TableLayoutPanel();
      this.dot12 = new System.Windows.Forms.Label();
      this.dot13 = new System.Windows.Forms.Label();
      this.dot14 = new System.Windows.Forms.Label();
      this.dns21 = new System.Windows.Forms.TextBox();
      this.dns22 = new System.Windows.Forms.TextBox();
      this.dns23 = new System.Windows.Forms.TextBox();
      this.dns24 = new System.Windows.Forms.TextBox();
      this.dns1Table = new System.Windows.Forms.TableLayoutPanel();
      this.dot9 = new System.Windows.Forms.Label();
      this.dot10 = new System.Windows.Forms.Label();
      this.dot11 = new System.Windows.Forms.Label();
      this.dns11 = new System.Windows.Forms.TextBox();
      this.dns12 = new System.Windows.Forms.TextBox();
      this.dns13 = new System.Windows.Forms.TextBox();
      this.dns14 = new System.Windows.Forms.TextBox();
      this.gateTable = new System.Windows.Forms.TableLayoutPanel();
      this.dot6 = new System.Windows.Forms.Label();
      this.dot7 = new System.Windows.Forms.Label();
      this.dot8 = new System.Windows.Forms.Label();
      this.gate1 = new System.Windows.Forms.TextBox();
      this.gate2 = new System.Windows.Forms.TextBox();
      this.gate3 = new System.Windows.Forms.TextBox();
      this.gate4 = new System.Windows.Forms.TextBox();
      this.maskTable = new System.Windows.Forms.TableLayoutPanel();
      this.dot3 = new System.Windows.Forms.Label();
      this.dot4 = new System.Windows.Forms.Label();
      this.dot5 = new System.Windows.Forms.Label();
      this.mask1 = new System.Windows.Forms.TextBox();
      this.mask2 = new System.Windows.Forms.TextBox();
      this.mask3 = new System.Windows.Forms.TextBox();
      this.mask4 = new System.Windows.Forms.TextBox();
      this.InfoIP = new System.Windows.Forms.Label();
      this.InfoMask = new System.Windows.Forms.Label();
      this.InfoGate = new System.Windows.Forms.Label();
      this.InfoDNS1 = new System.Windows.Forms.Label();
      this.InfoDNS2 = new System.Windows.Forms.Label();
      this.ipTable = new System.Windows.Forms.TableLayoutPanel();
      this.dot = new System.Windows.Forms.Label();
      this.dot1 = new System.Windows.Forms.Label();
      this.dot2 = new System.Windows.Forms.Label();
      this.ip1 = new System.Windows.Forms.TextBox();
      this.ip2 = new System.Windows.Forms.TextBox();
      this.ip3 = new System.Windows.Forms.TextBox();
      this.ip4 = new System.Windows.Forms.TextBox();
      this.ButtonTable = new System.Windows.Forms.TableLayoutPanel();
      this.DHCP = new System.Windows.Forms.Button();
      this.Static = new System.Windows.Forms.Button();
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.saveCurrent = new System.Windows.Forms.ToolStripMenuItem();
      this.trashCurrent = new System.Windows.Forms.ToolStripMenuItem();
      this.MainTable.SuspendLayout();
      this.InfoTable.SuspendLayout();
      this.DataTable.SuspendLayout();
      this.dns2Table.SuspendLayout();
      this.dns1Table.SuspendLayout();
      this.gateTable.SuspendLayout();
      this.maskTable.SuspendLayout();
      this.ipTable.SuspendLayout();
      this.ButtonTable.SuspendLayout();
      this.menuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // MainTable
      // 
      this.MainTable.ColumnCount = 1;
      this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.MainTable.Controls.Add(this.InfoTable, 0, 0);
      this.MainTable.Controls.Add(this.DataTable, 0, 1);
      this.MainTable.Controls.Add(this.ButtonTable, 0, 2);
      this.MainTable.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.MainTable.Location = new System.Drawing.Point(2, 29);
      this.MainTable.Name = "MainTable";
      this.MainTable.RowCount = 3;
      this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.42857F));
      this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.14286F));
      this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.42857F));
      this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.MainTable.Size = new System.Drawing.Size(397, 298);
      this.MainTable.TabIndex = 0;
      // 
      // InfoTable
      // 
      this.InfoTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.InfoTable.ColumnCount = 2;
      this.InfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.39505F));
      this.InfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.60495F));
      this.InfoTable.Controls.Add(this.InfoMachineName, 0, 0);
      this.InfoTable.Controls.Add(this.InfoNetAdapter, 0, 1);
      this.InfoTable.Controls.Add(this.MachineName, 1, 0);
      this.InfoTable.Controls.Add(this.NetAdapter, 1, 1);
      this.InfoTable.Location = new System.Drawing.Point(3, 3);
      this.InfoTable.Name = "InfoTable";
      this.InfoTable.RowCount = 2;
      this.InfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.InfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.InfoTable.Size = new System.Drawing.Size(391, 57);
      this.InfoTable.TabIndex = 0;
      // 
      // InfoMachineName
      // 
      this.InfoMachineName.AutoSize = true;
      this.InfoMachineName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.InfoMachineName.Location = new System.Drawing.Point(3, 0);
      this.InfoMachineName.Name = "InfoMachineName";
      this.InfoMachineName.Size = new System.Drawing.Size(89, 28);
      this.InfoMachineName.TabIndex = 0;
      this.InfoMachineName.Text = "Machine Name:";
      this.InfoMachineName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // InfoNetAdapter
      // 
      this.InfoNetAdapter.AutoSize = true;
      this.InfoNetAdapter.Dock = System.Windows.Forms.DockStyle.Fill;
      this.InfoNetAdapter.Location = new System.Drawing.Point(3, 28);
      this.InfoNetAdapter.Name = "InfoNetAdapter";
      this.InfoNetAdapter.Size = new System.Drawing.Size(89, 29);
      this.InfoNetAdapter.TabIndex = 1;
      this.InfoNetAdapter.Text = "Network Adapter:";
      this.InfoNetAdapter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // MachineName
      // 
      this.MachineName.AutoSize = true;
      this.MachineName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.MachineName.Location = new System.Drawing.Point(98, 0);
      this.MachineName.Name = "MachineName";
      this.MachineName.Size = new System.Drawing.Size(290, 28);
      this.MachineName.TabIndex = 2;
      this.MachineName.Text = "label3";
      this.MachineName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // NetAdapter
      // 
      this.NetAdapter.Dock = System.Windows.Forms.DockStyle.Fill;
      this.NetAdapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.NetAdapter.FormattingEnabled = true;
      this.NetAdapter.Location = new System.Drawing.Point(98, 31);
      this.NetAdapter.Name = "NetAdapter";
      this.NetAdapter.Size = new System.Drawing.Size(290, 21);
      this.NetAdapter.TabIndex = 3;
      this.NetAdapter.SelectedValueChanged += new System.EventHandler(this.OnAdapterChange);
      // 
      // DataTable
      // 
      this.DataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.DataTable.ColumnCount = 2;
      this.DataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.80362F));
      this.DataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.19638F));
      this.DataTable.Controls.Add(this.dns2Table, 1, 4);
      this.DataTable.Controls.Add(this.dns1Table, 1, 3);
      this.DataTable.Controls.Add(this.gateTable, 1, 2);
      this.DataTable.Controls.Add(this.maskTable, 1, 1);
      this.DataTable.Controls.Add(this.InfoIP, 0, 0);
      this.DataTable.Controls.Add(this.InfoMask, 0, 1);
      this.DataTable.Controls.Add(this.InfoGate, 0, 2);
      this.DataTable.Controls.Add(this.InfoDNS1, 0, 3);
      this.DataTable.Controls.Add(this.InfoDNS2, 0, 4);
      this.DataTable.Controls.Add(this.ipTable, 1, 0);
      this.DataTable.Location = new System.Drawing.Point(3, 66);
      this.DataTable.Name = "DataTable";
      this.DataTable.RowCount = 5;
      this.DataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.DataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.DataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.DataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.DataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.DataTable.Size = new System.Drawing.Size(391, 179);
      this.DataTable.TabIndex = 1;
      // 
      // dns2Table
      // 
      this.dns2Table.ColumnCount = 7;
      this.dns2Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.dns2Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
      this.dns2Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.dns2Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
      this.dns2Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.dns2Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
      this.dns2Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.dns2Table.Controls.Add(this.dot12, 1, 0);
      this.dns2Table.Controls.Add(this.dot13, 3, 0);
      this.dns2Table.Controls.Add(this.dot14, 5, 0);
      this.dns2Table.Controls.Add(this.dns21, 0, 0);
      this.dns2Table.Controls.Add(this.dns22, 2, 0);
      this.dns2Table.Controls.Add(this.dns23, 4, 0);
      this.dns2Table.Controls.Add(this.dns24, 6, 0);
      this.dns2Table.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dns2Table.Location = new System.Drawing.Point(111, 143);
      this.dns2Table.Name = "dns2Table";
      this.dns2Table.RowCount = 1;
      this.dns2Table.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.dns2Table.Size = new System.Drawing.Size(277, 33);
      this.dns2Table.TabIndex = 9;
      // 
      // dot12
      // 
      this.dot12.AutoSize = true;
      this.dot12.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dot12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dot12.Location = new System.Drawing.Point(61, 0);
      this.dot12.Name = "dot12";
      this.dot12.Size = new System.Drawing.Size(9, 33);
      this.dot12.TabIndex = 0;
      this.dot12.Text = ".";
      this.dot12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // dot13
      // 
      this.dot13.AutoSize = true;
      this.dot13.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dot13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dot13.Location = new System.Drawing.Point(134, 0);
      this.dot13.Name = "dot13";
      this.dot13.Size = new System.Drawing.Size(9, 33);
      this.dot13.TabIndex = 1;
      this.dot13.Text = ".";
      this.dot13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // dot14
      // 
      this.dot14.AutoSize = true;
      this.dot14.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dot14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dot14.Location = new System.Drawing.Point(207, 0);
      this.dot14.Name = "dot14";
      this.dot14.Size = new System.Drawing.Size(9, 33);
      this.dot14.TabIndex = 2;
      this.dot14.Text = ".";
      this.dot14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // dns21
      // 
      this.dns21.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dns21.Location = new System.Drawing.Point(3, 3);
      this.dns21.MaxLength = 3;
      this.dns21.Name = "dns21";
      this.dns21.Size = new System.Drawing.Size(52, 20);
      this.dns21.TabIndex = 3;
      this.dns21.TextChanged += new System.EventHandler(this.OnTextChanged);
      // 
      // dns22
      // 
      this.dns22.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dns22.Location = new System.Drawing.Point(76, 3);
      this.dns22.MaxLength = 3;
      this.dns22.Name = "dns22";
      this.dns22.Size = new System.Drawing.Size(52, 20);
      this.dns22.TabIndex = 4;
      this.dns22.TextChanged += new System.EventHandler(this.OnTextChanged);
      // 
      // dns23
      // 
      this.dns23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dns23.Location = new System.Drawing.Point(149, 3);
      this.dns23.MaxLength = 3;
      this.dns23.Name = "dns23";
      this.dns23.Size = new System.Drawing.Size(52, 20);
      this.dns23.TabIndex = 5;
      this.dns23.TextChanged += new System.EventHandler(this.OnTextChanged);
      // 
      // dns24
      // 
      this.dns24.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dns24.Location = new System.Drawing.Point(222, 3);
      this.dns24.MaxLength = 3;
      this.dns24.Name = "dns24";
      this.dns24.Size = new System.Drawing.Size(52, 20);
      this.dns24.TabIndex = 6;
      this.dns24.TextChanged += new System.EventHandler(this.OnTextChanged);
      // 
      // dns1Table
      // 
      this.dns1Table.ColumnCount = 7;
      this.dns1Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.dns1Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
      this.dns1Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.dns1Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
      this.dns1Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.dns1Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
      this.dns1Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.dns1Table.Controls.Add(this.dot9, 1, 0);
      this.dns1Table.Controls.Add(this.dot10, 3, 0);
      this.dns1Table.Controls.Add(this.dot11, 5, 0);
      this.dns1Table.Controls.Add(this.dns11, 0, 0);
      this.dns1Table.Controls.Add(this.dns12, 2, 0);
      this.dns1Table.Controls.Add(this.dns13, 4, 0);
      this.dns1Table.Controls.Add(this.dns14, 6, 0);
      this.dns1Table.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dns1Table.Location = new System.Drawing.Point(111, 108);
      this.dns1Table.Name = "dns1Table";
      this.dns1Table.RowCount = 1;
      this.dns1Table.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.dns1Table.Size = new System.Drawing.Size(277, 29);
      this.dns1Table.TabIndex = 8;
      // 
      // dot9
      // 
      this.dot9.AutoSize = true;
      this.dot9.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dot9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dot9.Location = new System.Drawing.Point(61, 0);
      this.dot9.Name = "dot9";
      this.dot9.Size = new System.Drawing.Size(9, 29);
      this.dot9.TabIndex = 0;
      this.dot9.Text = ".";
      this.dot9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // dot10
      // 
      this.dot10.AutoSize = true;
      this.dot10.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dot10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dot10.Location = new System.Drawing.Point(134, 0);
      this.dot10.Name = "dot10";
      this.dot10.Size = new System.Drawing.Size(9, 29);
      this.dot10.TabIndex = 1;
      this.dot10.Text = ".";
      this.dot10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // dot11
      // 
      this.dot11.AutoSize = true;
      this.dot11.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dot11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dot11.Location = new System.Drawing.Point(207, 0);
      this.dot11.Name = "dot11";
      this.dot11.Size = new System.Drawing.Size(9, 29);
      this.dot11.TabIndex = 2;
      this.dot11.Text = ".";
      this.dot11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // dns11
      // 
      this.dns11.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dns11.Location = new System.Drawing.Point(3, 3);
      this.dns11.MaxLength = 3;
      this.dns11.Name = "dns11";
      this.dns11.Size = new System.Drawing.Size(52, 20);
      this.dns11.TabIndex = 3;
      this.dns11.TextChanged += new System.EventHandler(this.OnTextChanged);
      // 
      // dns12
      // 
      this.dns12.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dns12.Location = new System.Drawing.Point(76, 3);
      this.dns12.MaxLength = 3;
      this.dns12.Name = "dns12";
      this.dns12.Size = new System.Drawing.Size(52, 20);
      this.dns12.TabIndex = 4;
      this.dns12.TextChanged += new System.EventHandler(this.OnTextChanged);
      // 
      // dns13
      // 
      this.dns13.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dns13.Location = new System.Drawing.Point(149, 3);
      this.dns13.MaxLength = 3;
      this.dns13.Name = "dns13";
      this.dns13.Size = new System.Drawing.Size(52, 20);
      this.dns13.TabIndex = 5;
      this.dns13.TextChanged += new System.EventHandler(this.OnTextChanged);
      // 
      // dns14
      // 
      this.dns14.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dns14.Location = new System.Drawing.Point(222, 3);
      this.dns14.MaxLength = 3;
      this.dns14.Name = "dns14";
      this.dns14.Size = new System.Drawing.Size(52, 20);
      this.dns14.TabIndex = 6;
      this.dns14.TextChanged += new System.EventHandler(this.OnTextChanged);
      // 
      // gateTable
      // 
      this.gateTable.ColumnCount = 7;
      this.gateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.gateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
      this.gateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.gateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
      this.gateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.gateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
      this.gateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.gateTable.Controls.Add(this.dot6, 1, 0);
      this.gateTable.Controls.Add(this.dot7, 3, 0);
      this.gateTable.Controls.Add(this.dot8, 5, 0);
      this.gateTable.Controls.Add(this.gate1, 0, 0);
      this.gateTable.Controls.Add(this.gate2, 2, 0);
      this.gateTable.Controls.Add(this.gate3, 4, 0);
      this.gateTable.Controls.Add(this.gate4, 6, 0);
      this.gateTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gateTable.Location = new System.Drawing.Point(111, 73);
      this.gateTable.Name = "gateTable";
      this.gateTable.RowCount = 1;
      this.gateTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.gateTable.Size = new System.Drawing.Size(277, 29);
      this.gateTable.TabIndex = 7;
      // 
      // dot6
      // 
      this.dot6.AutoSize = true;
      this.dot6.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dot6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dot6.Location = new System.Drawing.Point(61, 0);
      this.dot6.Name = "dot6";
      this.dot6.Size = new System.Drawing.Size(9, 29);
      this.dot6.TabIndex = 0;
      this.dot6.Text = ".";
      this.dot6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // dot7
      // 
      this.dot7.AutoSize = true;
      this.dot7.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dot7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dot7.Location = new System.Drawing.Point(134, 0);
      this.dot7.Name = "dot7";
      this.dot7.Size = new System.Drawing.Size(9, 29);
      this.dot7.TabIndex = 1;
      this.dot7.Text = ".";
      this.dot7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // dot8
      // 
      this.dot8.AutoSize = true;
      this.dot8.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dot8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dot8.Location = new System.Drawing.Point(207, 0);
      this.dot8.Name = "dot8";
      this.dot8.Size = new System.Drawing.Size(9, 29);
      this.dot8.TabIndex = 2;
      this.dot8.Text = ".";
      this.dot8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // gate1
      // 
      this.gate1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gate1.Location = new System.Drawing.Point(3, 3);
      this.gate1.MaxLength = 3;
      this.gate1.Name = "gate1";
      this.gate1.Size = new System.Drawing.Size(52, 20);
      this.gate1.TabIndex = 3;
      this.gate1.TextChanged += new System.EventHandler(this.OnTextChanged);
      // 
      // gate2
      // 
      this.gate2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gate2.Location = new System.Drawing.Point(76, 3);
      this.gate2.MaxLength = 3;
      this.gate2.Name = "gate2";
      this.gate2.Size = new System.Drawing.Size(52, 20);
      this.gate2.TabIndex = 4;
      this.gate2.TextChanged += new System.EventHandler(this.OnTextChanged);
      // 
      // gate3
      // 
      this.gate3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gate3.Location = new System.Drawing.Point(149, 3);
      this.gate3.MaxLength = 3;
      this.gate3.Name = "gate3";
      this.gate3.Size = new System.Drawing.Size(52, 20);
      this.gate3.TabIndex = 5;
      this.gate3.TextChanged += new System.EventHandler(this.OnTextChanged);
      // 
      // gate4
      // 
      this.gate4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gate4.Location = new System.Drawing.Point(222, 3);
      this.gate4.MaxLength = 3;
      this.gate4.Name = "gate4";
      this.gate4.Size = new System.Drawing.Size(52, 20);
      this.gate4.TabIndex = 6;
      this.gate4.TextChanged += new System.EventHandler(this.OnTextChanged);
      // 
      // maskTable
      // 
      this.maskTable.ColumnCount = 7;
      this.maskTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.maskTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
      this.maskTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.maskTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
      this.maskTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.maskTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
      this.maskTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.maskTable.Controls.Add(this.dot3, 1, 0);
      this.maskTable.Controls.Add(this.dot4, 3, 0);
      this.maskTable.Controls.Add(this.dot5, 5, 0);
      this.maskTable.Controls.Add(this.mask1, 0, 0);
      this.maskTable.Controls.Add(this.mask2, 2, 0);
      this.maskTable.Controls.Add(this.mask3, 4, 0);
      this.maskTable.Controls.Add(this.mask4, 6, 0);
      this.maskTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.maskTable.Location = new System.Drawing.Point(111, 38);
      this.maskTable.Name = "maskTable";
      this.maskTable.RowCount = 1;
      this.maskTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.maskTable.Size = new System.Drawing.Size(277, 29);
      this.maskTable.TabIndex = 6;
      // 
      // dot3
      // 
      this.dot3.AutoSize = true;
      this.dot3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dot3.Location = new System.Drawing.Point(61, 0);
      this.dot3.Name = "dot3";
      this.dot3.Size = new System.Drawing.Size(9, 29);
      this.dot3.TabIndex = 0;
      this.dot3.Text = ".";
      this.dot3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // dot4
      // 
      this.dot4.AutoSize = true;
      this.dot4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dot4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dot4.Location = new System.Drawing.Point(134, 0);
      this.dot4.Name = "dot4";
      this.dot4.Size = new System.Drawing.Size(9, 29);
      this.dot4.TabIndex = 1;
      this.dot4.Text = ".";
      this.dot4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // dot5
      // 
      this.dot5.AutoSize = true;
      this.dot5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dot5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dot5.Location = new System.Drawing.Point(207, 0);
      this.dot5.Name = "dot5";
      this.dot5.Size = new System.Drawing.Size(9, 29);
      this.dot5.TabIndex = 2;
      this.dot5.Text = ".";
      this.dot5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // mask1
      // 
      this.mask1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mask1.Location = new System.Drawing.Point(3, 3);
      this.mask1.MaxLength = 3;
      this.mask1.Name = "mask1";
      this.mask1.Size = new System.Drawing.Size(52, 20);
      this.mask1.TabIndex = 3;
      this.mask1.TextChanged += new System.EventHandler(this.OnTextChanged);
      // 
      // mask2
      // 
      this.mask2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mask2.Location = new System.Drawing.Point(76, 3);
      this.mask2.MaxLength = 3;
      this.mask2.Name = "mask2";
      this.mask2.Size = new System.Drawing.Size(52, 20);
      this.mask2.TabIndex = 4;
      this.mask2.TextChanged += new System.EventHandler(this.OnTextChanged);
      // 
      // mask3
      // 
      this.mask3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mask3.Location = new System.Drawing.Point(149, 3);
      this.mask3.MaxLength = 3;
      this.mask3.Name = "mask3";
      this.mask3.Size = new System.Drawing.Size(52, 20);
      this.mask3.TabIndex = 5;
      this.mask3.TextChanged += new System.EventHandler(this.OnTextChanged);
      // 
      // mask4
      // 
      this.mask4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mask4.Location = new System.Drawing.Point(222, 3);
      this.mask4.MaxLength = 3;
      this.mask4.Name = "mask4";
      this.mask4.Size = new System.Drawing.Size(52, 20);
      this.mask4.TabIndex = 6;
      this.mask4.TextChanged += new System.EventHandler(this.OnTextChanged);
      // 
      // InfoIP
      // 
      this.InfoIP.AutoSize = true;
      this.InfoIP.Dock = System.Windows.Forms.DockStyle.Fill;
      this.InfoIP.Location = new System.Drawing.Point(3, 0);
      this.InfoIP.Name = "InfoIP";
      this.InfoIP.Size = new System.Drawing.Size(102, 35);
      this.InfoIP.TabIndex = 0;
      this.InfoIP.Text = "IP";
      this.InfoIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // InfoMask
      // 
      this.InfoMask.AutoSize = true;
      this.InfoMask.Dock = System.Windows.Forms.DockStyle.Fill;
      this.InfoMask.Location = new System.Drawing.Point(3, 35);
      this.InfoMask.Name = "InfoMask";
      this.InfoMask.Size = new System.Drawing.Size(102, 35);
      this.InfoMask.TabIndex = 1;
      this.InfoMask.Text = "Subnet Mask";
      this.InfoMask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // InfoGate
      // 
      this.InfoGate.AutoSize = true;
      this.InfoGate.Dock = System.Windows.Forms.DockStyle.Fill;
      this.InfoGate.Location = new System.Drawing.Point(3, 70);
      this.InfoGate.Name = "InfoGate";
      this.InfoGate.Size = new System.Drawing.Size(102, 35);
      this.InfoGate.TabIndex = 2;
      this.InfoGate.Text = "Default Gateway";
      this.InfoGate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // InfoDNS1
      // 
      this.InfoDNS1.AutoSize = true;
      this.InfoDNS1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.InfoDNS1.Location = new System.Drawing.Point(3, 105);
      this.InfoDNS1.Name = "InfoDNS1";
      this.InfoDNS1.Size = new System.Drawing.Size(102, 35);
      this.InfoDNS1.TabIndex = 3;
      this.InfoDNS1.Text = "Primary DNS Server";
      this.InfoDNS1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // InfoDNS2
      // 
      this.InfoDNS2.AutoSize = true;
      this.InfoDNS2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.InfoDNS2.Location = new System.Drawing.Point(3, 140);
      this.InfoDNS2.Name = "InfoDNS2";
      this.InfoDNS2.Size = new System.Drawing.Size(102, 39);
      this.InfoDNS2.TabIndex = 4;
      this.InfoDNS2.Text = "Secondary DNS Server";
      this.InfoDNS2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // ipTable
      // 
      this.ipTable.ColumnCount = 7;
      this.ipTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.ipTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
      this.ipTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.ipTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
      this.ipTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.ipTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
      this.ipTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.ipTable.Controls.Add(this.dot, 1, 0);
      this.ipTable.Controls.Add(this.dot1, 3, 0);
      this.ipTable.Controls.Add(this.dot2, 5, 0);
      this.ipTable.Controls.Add(this.ip1, 0, 0);
      this.ipTable.Controls.Add(this.ip2, 2, 0);
      this.ipTable.Controls.Add(this.ip3, 4, 0);
      this.ipTable.Controls.Add(this.ip4, 6, 0);
      this.ipTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ipTable.Location = new System.Drawing.Point(111, 3);
      this.ipTable.Name = "ipTable";
      this.ipTable.RowCount = 1;
      this.ipTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.ipTable.Size = new System.Drawing.Size(277, 29);
      this.ipTable.TabIndex = 5;
      // 
      // dot
      // 
      this.dot.AutoSize = true;
      this.dot.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dot.Location = new System.Drawing.Point(61, 0);
      this.dot.Name = "dot";
      this.dot.Size = new System.Drawing.Size(9, 29);
      this.dot.TabIndex = 0;
      this.dot.Text = ".";
      this.dot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // dot1
      // 
      this.dot1.AutoSize = true;
      this.dot1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dot1.Location = new System.Drawing.Point(134, 0);
      this.dot1.Name = "dot1";
      this.dot1.Size = new System.Drawing.Size(9, 29);
      this.dot1.TabIndex = 1;
      this.dot1.Text = ".";
      this.dot1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // dot2
      // 
      this.dot2.AutoSize = true;
      this.dot2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dot2.Location = new System.Drawing.Point(207, 0);
      this.dot2.Name = "dot2";
      this.dot2.Size = new System.Drawing.Size(9, 29);
      this.dot2.TabIndex = 2;
      this.dot2.Text = ".";
      this.dot2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // ip1
      // 
      this.ip1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ip1.Location = new System.Drawing.Point(3, 3);
      this.ip1.MaxLength = 3;
      this.ip1.Name = "ip1";
      this.ip1.Size = new System.Drawing.Size(52, 20);
      this.ip1.TabIndex = 3;
      this.ip1.TextChanged += new System.EventHandler(this.OnTextChanged);
      // 
      // ip2
      // 
      this.ip2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ip2.Location = new System.Drawing.Point(76, 3);
      this.ip2.MaxLength = 3;
      this.ip2.Name = "ip2";
      this.ip2.Size = new System.Drawing.Size(52, 20);
      this.ip2.TabIndex = 4;
      this.ip2.TextChanged += new System.EventHandler(this.OnTextChanged);
      // 
      // ip3
      // 
      this.ip3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ip3.Location = new System.Drawing.Point(149, 3);
      this.ip3.MaxLength = 3;
      this.ip3.Name = "ip3";
      this.ip3.Size = new System.Drawing.Size(52, 20);
      this.ip3.TabIndex = 5;
      this.ip3.TextChanged += new System.EventHandler(this.OnTextChanged);
      // 
      // ip4
      // 
      this.ip4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ip4.Location = new System.Drawing.Point(222, 3);
      this.ip4.MaxLength = 3;
      this.ip4.Name = "ip4";
      this.ip4.Size = new System.Drawing.Size(52, 20);
      this.ip4.TabIndex = 6;
      this.ip4.TextChanged += new System.EventHandler(this.OnTextChanged);
      // 
      // ButtonTable
      // 
      this.ButtonTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ButtonTable.ColumnCount = 2;
      this.ButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.ButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.ButtonTable.Controls.Add(this.DHCP, 0, 0);
      this.ButtonTable.Controls.Add(this.Static, 1, 0);
      this.ButtonTable.Location = new System.Drawing.Point(3, 251);
      this.ButtonTable.Name = "ButtonTable";
      this.ButtonTable.RowCount = 1;
      this.ButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.ButtonTable.Size = new System.Drawing.Size(391, 44);
      this.ButtonTable.TabIndex = 2;
      // 
      // DHCP
      // 
      this.DHCP.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DHCP.Location = new System.Drawing.Point(3, 3);
      this.DHCP.Name = "DHCP";
      this.DHCP.Size = new System.Drawing.Size(189, 38);
      this.DHCP.TabIndex = 0;
      this.DHCP.Text = "Set DHCP";
      this.DHCP.UseCompatibleTextRendering = true;
      this.DHCP.UseVisualStyleBackColor = true;
      this.DHCP.Click += new System.EventHandler(this.OnDHCPClick);
      // 
      // Static
      // 
      this.Static.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Static.Location = new System.Drawing.Point(198, 3);
      this.Static.Name = "Static";
      this.Static.Size = new System.Drawing.Size(190, 38);
      this.Static.TabIndex = 1;
      this.Static.Text = "Set Static";
      this.Static.UseVisualStyleBackColor = true;
      this.Static.Click += new System.EventHandler(this.OnStaticClick);
      // 
      // menuStrip
      // 
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCurrent,
            this.trashCurrent});
      this.menuStrip.Location = new System.Drawing.Point(2, 2);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
      this.menuStrip.Size = new System.Drawing.Size(397, 24);
      this.menuStrip.TabIndex = 1;
      this.menuStrip.Text = "menuStrip1";
      // 
      // saveCurrent
      // 
      this.saveCurrent.Name = "saveCurrent";
      this.saveCurrent.Size = new System.Drawing.Size(86, 20);
      this.saveCurrent.Text = "Save Current";
      this.saveCurrent.Click += new System.EventHandler(this.OnSaveCurrent);
      // 
      // trashCurrent
      // 
      this.trashCurrent.Name = "trashCurrent";
      this.trashCurrent.Size = new System.Drawing.Size(91, 20);
      this.trashCurrent.Text = "Trash Current";
      this.trashCurrent.Click += new System.EventHandler(this.OnTrashCurrent);
      // 
      // MainWindow
      // 
      this.AccessibleDescription = "Application made to change a computer\'s IP settings based on a predefined file.";
      this.AccessibleName = "IP Changer";
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ControlDark;
      this.ClientSize = new System.Drawing.Size(401, 329);
      this.Controls.Add(this.menuStrip);
      this.Controls.Add(this.MainTable);
      this.MainMenuStrip = this.menuStrip;
      this.Name = "MainWindow";
      this.Padding = new System.Windows.Forms.Padding(2);
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "IP Changer";
      this.MainTable.ResumeLayout(false);
      this.InfoTable.ResumeLayout(false);
      this.InfoTable.PerformLayout();
      this.DataTable.ResumeLayout(false);
      this.DataTable.PerformLayout();
      this.dns2Table.ResumeLayout(false);
      this.dns2Table.PerformLayout();
      this.dns1Table.ResumeLayout(false);
      this.dns1Table.PerformLayout();
      this.gateTable.ResumeLayout(false);
      this.gateTable.PerformLayout();
      this.maskTable.ResumeLayout(false);
      this.maskTable.PerformLayout();
      this.ipTable.ResumeLayout(false);
      this.ipTable.PerformLayout();
      this.ButtonTable.ResumeLayout(false);
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel MainTable;
    private System.Windows.Forms.TableLayoutPanel InfoTable;
    private System.Windows.Forms.Label InfoMachineName;
    private System.Windows.Forms.Label InfoNetAdapter;
    private System.Windows.Forms.Label MachineName;
    private System.Windows.Forms.ComboBox NetAdapter;
    private System.Windows.Forms.TableLayoutPanel DataTable;
    private System.Windows.Forms.TableLayoutPanel ButtonTable;
    private System.Windows.Forms.Button DHCP;
    private System.Windows.Forms.Button Static;
    private System.Windows.Forms.Label InfoIP;
    private System.Windows.Forms.Label InfoMask;
    private System.Windows.Forms.Label InfoGate;
    private System.Windows.Forms.Label InfoDNS1;
    private System.Windows.Forms.Label InfoDNS2;
    private System.Windows.Forms.TableLayoutPanel ipTable;
    private System.Windows.Forms.Label dot;
    private System.Windows.Forms.Label dot1;
    private System.Windows.Forms.Label dot2;
    private System.Windows.Forms.TextBox ip1;
    private System.Windows.Forms.TextBox ip2;
    private System.Windows.Forms.TextBox ip3;
    private System.Windows.Forms.TextBox ip4;
    private System.Windows.Forms.TableLayoutPanel dns2Table;
    private System.Windows.Forms.Label dot12;
    private System.Windows.Forms.Label dot13;
    private System.Windows.Forms.Label dot14;
    private System.Windows.Forms.TextBox dns21;
    private System.Windows.Forms.TextBox dns22;
    private System.Windows.Forms.TextBox dns23;
    private System.Windows.Forms.TextBox dns24;
    private System.Windows.Forms.TableLayoutPanel dns1Table;
    private System.Windows.Forms.Label dot9;
    private System.Windows.Forms.Label dot10;
    private System.Windows.Forms.Label dot11;
    private System.Windows.Forms.TextBox dns11;
    private System.Windows.Forms.TextBox dns12;
    private System.Windows.Forms.TextBox dns13;
    private System.Windows.Forms.TextBox dns14;
    private System.Windows.Forms.TableLayoutPanel gateTable;
    private System.Windows.Forms.Label dot6;
    private System.Windows.Forms.Label dot7;
    private System.Windows.Forms.Label dot8;
    private System.Windows.Forms.TextBox gate1;
    private System.Windows.Forms.TextBox gate2;
    private System.Windows.Forms.TextBox gate3;
    private System.Windows.Forms.TextBox gate4;
    private System.Windows.Forms.TableLayoutPanel maskTable;
    private System.Windows.Forms.Label dot3;
    private System.Windows.Forms.Label dot4;
    private System.Windows.Forms.Label dot5;
    private System.Windows.Forms.TextBox mask1;
    private System.Windows.Forms.TextBox mask2;
    private System.Windows.Forms.TextBox mask3;
    private System.Windows.Forms.TextBox mask4;
    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem saveCurrent;
    private System.Windows.Forms.ToolStripMenuItem trashCurrent;
  }
}

