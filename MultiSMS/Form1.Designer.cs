namespace MultiSMS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tlTab1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPortName = new System.Windows.Forms.Label();
            this.lblBaudrate = new System.Windows.Forms.Label();
            this.lblParity = new System.Windows.Forms.Label();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.lblStopBit = new System.Windows.Forms.Label();
            this.lblHandshake = new System.Windows.Forms.Label();
            this.lblDtr = new System.Windows.Forms.Label();
            this.lblRTS = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.cbStopBit = new System.Windows.Forms.ComboBox();
            this.cbHandshake = new System.Windows.Forms.ComboBox();
            this.cbDTR = new System.Windows.Forms.CheckBox();
            this.cbRTS = new System.Windows.Forms.CheckBox();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tlTab1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(518, 419);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tlTab1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(510, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connection";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tlTab1
            // 
            this.tlTab1.ColumnCount = 2;
            this.tlTab1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlTab1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlTab1.Controls.Add(this.lblPortName, 0, 0);
            this.tlTab1.Controls.Add(this.lblBaudrate, 0, 1);
            this.tlTab1.Controls.Add(this.lblParity, 0, 2);
            this.tlTab1.Controls.Add(this.lblDataBits, 0, 3);
            this.tlTab1.Controls.Add(this.lblStopBit, 0, 4);
            this.tlTab1.Controls.Add(this.lblHandshake, 0, 5);
            this.tlTab1.Controls.Add(this.lblDtr, 0, 6);
            this.tlTab1.Controls.Add(this.lblRTS, 0, 7);
            this.tlTab1.Controls.Add(this.btnConnect, 0, 8);
            this.tlTab1.Controls.Add(this.cbBaudrate, 1, 1);
            this.tlTab1.Controls.Add(this.cbParity, 1, 2);
            this.tlTab1.Controls.Add(this.cbDataBits, 1, 3);
            this.tlTab1.Controls.Add(this.cbStopBit, 1, 4);
            this.tlTab1.Controls.Add(this.cbHandshake, 1, 5);
            this.tlTab1.Controls.Add(this.cbDTR, 1, 6);
            this.tlTab1.Controls.Add(this.cbRTS, 1, 7);
            this.tlTab1.Controls.Add(this.cbPort, 1, 0);
            this.tlTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlTab1.Location = new System.Drawing.Point(3, 3);
            this.tlTab1.Name = "tlTab1";
            this.tlTab1.RowCount = 9;
            this.tlTab1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlTab1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlTab1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlTab1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlTab1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlTab1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlTab1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlTab1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlTab1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlTab1.Size = new System.Drawing.Size(504, 387);
            this.tlTab1.TabIndex = 0;
            // 
            // lblPortName
            // 
            this.lblPortName.AutoSize = true;
            this.lblPortName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPortName.Location = new System.Drawing.Point(3, 0);
            this.lblPortName.Name = "lblPortName";
            this.lblPortName.Size = new System.Drawing.Size(246, 43);
            this.lblPortName.TabIndex = 0;
            this.lblPortName.Text = "Port";
            this.lblPortName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBaudrate
            // 
            this.lblBaudrate.AutoSize = true;
            this.lblBaudrate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBaudrate.Location = new System.Drawing.Point(3, 43);
            this.lblBaudrate.Name = "lblBaudrate";
            this.lblBaudrate.Size = new System.Drawing.Size(246, 43);
            this.lblBaudrate.TabIndex = 1;
            this.lblBaudrate.Text = "Baudrate";
            this.lblBaudrate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblParity.Location = new System.Drawing.Point(3, 86);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(246, 43);
            this.lblParity.TabIndex = 2;
            this.lblParity.Text = "Parity";
            this.lblParity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDataBits
            // 
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataBits.Location = new System.Drawing.Point(3, 129);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(246, 43);
            this.lblDataBits.TabIndex = 3;
            this.lblDataBits.Text = "Data bits";
            this.lblDataBits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStopBit
            // 
            this.lblStopBit.AutoSize = true;
            this.lblStopBit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStopBit.Location = new System.Drawing.Point(3, 172);
            this.lblStopBit.Name = "lblStopBit";
            this.lblStopBit.Size = new System.Drawing.Size(246, 43);
            this.lblStopBit.TabIndex = 4;
            this.lblStopBit.Text = "Stop bit";
            this.lblStopBit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHandshake
            // 
            this.lblHandshake.AutoSize = true;
            this.lblHandshake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHandshake.Location = new System.Drawing.Point(3, 215);
            this.lblHandshake.Name = "lblHandshake";
            this.lblHandshake.Size = new System.Drawing.Size(246, 43);
            this.lblHandshake.TabIndex = 5;
            this.lblHandshake.Text = "Handshake";
            this.lblHandshake.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDtr
            // 
            this.lblDtr.AutoSize = true;
            this.lblDtr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDtr.Location = new System.Drawing.Point(3, 258);
            this.lblDtr.Name = "lblDtr";
            this.lblDtr.Size = new System.Drawing.Size(246, 43);
            this.lblDtr.TabIndex = 6;
            this.lblDtr.Text = "DTR enable";
            this.lblDtr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRTS
            // 
            this.lblRTS.AutoSize = true;
            this.lblRTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRTS.Location = new System.Drawing.Point(3, 301);
            this.lblRTS.Name = "lblRTS";
            this.lblRTS.Size = new System.Drawing.Size(246, 43);
            this.lblRTS.TabIndex = 7;
            this.lblRTS.Text = "RTS enable";
            this.lblRTS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSize = true;
            this.btnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnect.BackColor = System.Drawing.Color.Transparent;
            this.tlTab1.SetColumnSpan(this.btnConnect, 2);
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.Location = new System.Drawing.Point(3, 347);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(498, 37);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbBaudrate.DisplayMember = "9600";
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200"});
            this.cbBaudrate.Location = new System.Drawing.Point(255, 54);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(121, 21);
            this.cbBaudrate.TabIndex = 10;
            this.cbBaudrate.ValueMember = "9600";
            // 
            // cbParity
            // 
            this.cbParity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cbParity.Location = new System.Drawing.Point(255, 97);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(121, 21);
            this.cbParity.TabIndex = 11;
            // 
            // cbDataBits
            // 
            this.cbDataBits.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbDataBits.Location = new System.Drawing.Point(255, 140);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(121, 21);
            this.cbDataBits.TabIndex = 12;
            // 
            // cbStopBit
            // 
            this.cbStopBit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbStopBit.FormattingEnabled = true;
            this.cbStopBit.Items.AddRange(new object[] {
            "1",
            "2",
            "1.5"});
            this.cbStopBit.Location = new System.Drawing.Point(255, 183);
            this.cbStopBit.Name = "cbStopBit";
            this.cbStopBit.Size = new System.Drawing.Size(121, 21);
            this.cbStopBit.TabIndex = 13;
            // 
            // cbHandshake
            // 
            this.cbHandshake.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbHandshake.FormattingEnabled = true;
            this.cbHandshake.Items.AddRange(new object[] {
            "None",
            "XOnXOff",
            "RequestToSend",
            "RequestToSendXOnXOff"});
            this.cbHandshake.Location = new System.Drawing.Point(255, 226);
            this.cbHandshake.Name = "cbHandshake";
            this.cbHandshake.Size = new System.Drawing.Size(121, 21);
            this.cbHandshake.TabIndex = 14;
            // 
            // cbDTR
            // 
            this.cbDTR.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbDTR.AutoSize = true;
            this.cbDTR.Checked = true;
            this.cbDTR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDTR.Location = new System.Drawing.Point(255, 272);
            this.cbDTR.Name = "cbDTR";
            this.cbDTR.Size = new System.Drawing.Size(15, 14);
            this.cbDTR.TabIndex = 15;
            this.cbDTR.UseVisualStyleBackColor = true;
            // 
            // cbRTS
            // 
            this.cbRTS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbRTS.AutoSize = true;
            this.cbRTS.Checked = true;
            this.cbRTS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRTS.Location = new System.Drawing.Point(255, 315);
            this.cbRTS.Name = "cbRTS";
            this.cbRTS.Size = new System.Drawing.Size(15, 14);
            this.cbRTS.TabIndex = 16;
            this.cbRTS.UseVisualStyleBackColor = true;
            // 
            // cbPort
            // 
            this.cbPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(255, 11);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(121, 21);
            this.cbPort.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(510, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SMS sender";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 443);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "MultiSMS";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tlTab1.ResumeLayout(false);
            this.tlTab1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tlTab1;
        private System.Windows.Forms.Label lblPortName;
        private System.Windows.Forms.Label lblBaudrate;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.Label lblDataBits;
        private System.Windows.Forms.Label lblStopBit;
        private System.Windows.Forms.Label lblHandshake;
        private System.Windows.Forms.Label lblDtr;
        private System.Windows.Forms.Label lblRTS;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbBaudrate;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.ComboBox cbStopBit;
        private System.Windows.Forms.ComboBox cbHandshake;
        private System.Windows.Forms.CheckBox cbDTR;
        private System.Windows.Forms.CheckBox cbRTS;
        private System.Windows.Forms.ComboBox cbPort;
    }
}

