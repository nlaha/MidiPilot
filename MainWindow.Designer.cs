namespace MidiPilot
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.selectAll = new MaterialSkin.Controls.MaterialFlatButton();
            this.selectNone = new MaterialSkin.Controls.MaterialFlatButton();
            this.MidiChannelSelector = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clearConsole = new MaterialSkin.Controls.MaterialFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.DeviceTypeMenu = new System.Windows.Forms.ComboBox();
            this.MidiConnectBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MidiLogBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MidiDeviceSelector = new System.Windows.Forms.ComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.EventMidiChannelSelector = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EventControlType = new System.Windows.Forms.ComboBox();
            this.addMidiEntry = new MaterialSkin.Controls.MaterialFlatButton();
            this.MidiOptions = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VirtualInputSelector = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.addKeyXinputEntry = new MaterialSkin.Controls.MaterialFlatButton();
            this.label10 = new System.Windows.Forms.Label();
            this.KeyXinputOptions = new System.Windows.Forms.ListBox();
            this.OutputTypeSelector = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.EntryList = new System.Windows.Forms.ListBox();
            this.MidiNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayRightClickMenu = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.TrayMenuTitle = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.TrayMenuConnect = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.trayRightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer3, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 77);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.36192F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.63808F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 372F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(663, 1166);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.selectAll);
            this.splitContainer1.Panel1.Controls.Add(this.selectNone);
            this.splitContainer1.Panel1.Controls.Add(this.MidiChannelSelector);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.clearConsole);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.DeviceTypeMenu);
            this.splitContainer1.Panel2.Controls.Add(this.MidiConnectBtn);
            this.splitContainer1.Panel2.Controls.Add(this.MidiLogBox);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.MidiDeviceSelector);
            this.splitContainer1.Size = new System.Drawing.Size(657, 322);
            this.splitContainer1.SplitterDistance = 146;
            this.splitContainer1.TabIndex = 5;
            // 
            // selectAll
            // 
            this.selectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectAll.AutoSize = true;
            this.selectAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selectAll.Depth = 0;
            this.selectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.008696F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAll.Location = new System.Drawing.Point(5, 280);
            this.selectAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.selectAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.selectAll.Name = "selectAll";
            this.selectAll.Primary = false;
            this.selectAll.Size = new System.Drawing.Size(42, 36);
            this.selectAll.TabIndex = 5;
            this.selectAll.Text = "all";
            this.selectAll.UseVisualStyleBackColor = true;
            this.selectAll.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // selectNone
            // 
            this.selectNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectNone.AutoSize = true;
            this.selectNone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selectNone.Depth = 0;
            this.selectNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.008696F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectNone.Location = new System.Drawing.Point(55, 279);
            this.selectNone.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.selectNone.MouseState = MaterialSkin.MouseState.HOVER;
            this.selectNone.Name = "selectNone";
            this.selectNone.Primary = false;
            this.selectNone.Size = new System.Drawing.Size(57, 36);
            this.selectNone.TabIndex = 4;
            this.selectNone.Text = "none";
            this.selectNone.UseVisualStyleBackColor = true;
            this.selectNone.Click += new System.EventHandler(this.SelectNone_Click);
            // 
            // MidiChannelSelector
            // 
            this.MidiChannelSelector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MidiChannelSelector.CheckOnClick = true;
            this.MidiChannelSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MidiChannelSelector.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MidiChannelSelector.FormattingEnabled = true;
            this.MidiChannelSelector.Items.AddRange(new object[] {
            "Ch1",
            "Ch2",
            "Ch3",
            "Ch4",
            "Ch5",
            "Ch6",
            "Ch7",
            "Ch8",
            "Ch9",
            "Ch10",
            "Ch11",
            "Ch12",
            "Ch13",
            "Ch14",
            "Ch15",
            "Ch16"});
            this.MidiChannelSelector.Location = new System.Drawing.Point(10, 40);
            this.MidiChannelSelector.Name = "MidiChannelSelector";
            this.MidiChannelSelector.Size = new System.Drawing.Size(128, 238);
            this.MidiChannelSelector.TabIndex = 3;
            this.MidiChannelSelector.SelectedIndexChanged += new System.EventHandler(this.MidiChannelSelector_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Oswald", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "MIDI Channels";
            // 
            // clearConsole
            // 
            this.clearConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearConsole.AutoSize = true;
            this.clearConsole.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearConsole.Depth = 0;
            this.clearConsole.Font = new System.Drawing.Font("Oswald", 6.26087F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearConsole.Location = new System.Drawing.Point(368, 29);
            this.clearConsole.Margin = new System.Windows.Forms.Padding(1);
            this.clearConsole.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearConsole.Name = "clearConsole";
            this.clearConsole.Primary = false;
            this.clearConsole.Size = new System.Drawing.Size(130, 36);
            this.clearConsole.TabIndex = 6;
            this.clearConsole.Text = "clear output";
            this.clearConsole.UseVisualStyleBackColor = true;
            this.clearConsole.Click += new System.EventHandler(this.ClearConsole_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Oswald", 11.26956F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Device Type";
            // 
            // DeviceTypeMenu
            // 
            this.DeviceTypeMenu.FormattingEnabled = true;
            this.DeviceTypeMenu.Items.AddRange(new object[] {
            "Generic Midi Device",
            "Nord Electro 5D",
            "Korg nanoKontrol2"});
            this.DeviceTypeMenu.Location = new System.Drawing.Point(5, 281);
            this.DeviceTypeMenu.Name = "DeviceTypeMenu";
            this.DeviceTypeMenu.Size = new System.Drawing.Size(227, 24);
            this.DeviceTypeMenu.TabIndex = 4;
            // 
            // MidiConnectBtn
            // 
            this.MidiConnectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MidiConnectBtn.Depth = 0;
            this.MidiConnectBtn.Font = new System.Drawing.Font("Oswald", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MidiConnectBtn.Location = new System.Drawing.Point(283, 269);
            this.MidiConnectBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.MidiConnectBtn.Name = "MidiConnectBtn";
            this.MidiConnectBtn.Primary = true;
            this.MidiConnectBtn.Size = new System.Drawing.Size(239, 40);
            this.MidiConnectBtn.TabIndex = 3;
            this.MidiConnectBtn.Text = "Connect";
            this.MidiConnectBtn.UseVisualStyleBackColor = true;
            this.MidiConnectBtn.Click += new System.EventHandler(this.MidiConnectBtn_Click);
            // 
            // MidiLogBox
            // 
            this.MidiLogBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MidiLogBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MidiLogBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MidiLogBox.FormattingEnabled = true;
            this.MidiLogBox.ItemHeight = 17;
            this.MidiLogBox.Location = new System.Drawing.Point(5, 70);
            this.MidiLogBox.Margin = new System.Windows.Forms.Padding(5);
            this.MidiLogBox.Name = "MidiLogBox";
            this.MidiLogBox.ScrollAlwaysVisible = true;
            this.MidiLogBox.Size = new System.Drawing.Size(497, 172);
            this.MidiLogBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Oswald", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "MIDI Device";
            // 
            // MidiDeviceSelector
            // 
            this.MidiDeviceSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MidiDeviceSelector.FormattingEnabled = true;
            this.MidiDeviceSelector.Location = new System.Drawing.Point(5, 40);
            this.MidiDeviceSelector.Name = "MidiDeviceSelector";
            this.MidiDeviceSelector.Size = new System.Drawing.Size(261, 24);
            this.MidiDeviceSelector.TabIndex = 1;
            this.MidiDeviceSelector.SelectedIndexChanged += new System.EventHandler(this.MidiDeviceSelector_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 331);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.EventMidiChannelSelector);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.EventControlType);
            this.splitContainer2.Panel1.Controls.Add(this.addMidiEntry);
            this.splitContainer2.Panel1.Controls.Add(this.MidiOptions);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.VirtualInputSelector);
            this.splitContainer2.Panel2.Controls.Add(this.label9);
            this.splitContainer2.Panel2.Controls.Add(this.addKeyXinputEntry);
            this.splitContainer2.Panel2.Controls.Add(this.label10);
            this.splitContainer2.Panel2.Controls.Add(this.KeyXinputOptions);
            this.splitContainer2.Panel2.Controls.Add(this.OutputTypeSelector);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Size = new System.Drawing.Size(657, 459);
            this.splitContainer2.SplitterDistance = 322;
            this.splitContainer2.TabIndex = 6;
            // 
            // EventMidiChannelSelector
            // 
            this.EventMidiChannelSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventMidiChannelSelector.FormattingEnabled = true;
            this.EventMidiChannelSelector.Location = new System.Drawing.Point(154, 266);
            this.EventMidiChannelSelector.Name = "EventMidiChannelSelector";
            this.EventMidiChannelSelector.Size = new System.Drawing.Size(163, 24);
            this.EventMidiChannelSelector.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Font = new System.Drawing.Font("Oswald", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-1, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 27);
            this.label8.TabIndex = 9;
            this.label8.Text = "MIDI Channel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("Oswald", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-1, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "MIDI Control Type";
            // 
            // EventControlType
            // 
            this.EventControlType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventControlType.FormattingEnabled = true;
            this.EventControlType.Location = new System.Drawing.Point(154, 226);
            this.EventControlType.Name = "EventControlType";
            this.EventControlType.Size = new System.Drawing.Size(162, 24);
            this.EventControlType.TabIndex = 7;
            // 
            // addMidiEntry
            // 
            this.addMidiEntry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addMidiEntry.AutoSize = true;
            this.addMidiEntry.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addMidiEntry.BackColor = System.Drawing.SystemColors.Window;
            this.addMidiEntry.Depth = 0;
            this.addMidiEntry.Location = new System.Drawing.Point(4, 417);
            this.addMidiEntry.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addMidiEntry.MouseState = MaterialSkin.MouseState.HOVER;
            this.addMidiEntry.Name = "addMidiEntry";
            this.addMidiEntry.Primary = false;
            this.addMidiEntry.Size = new System.Drawing.Size(139, 36);
            this.addMidiEntry.TabIndex = 6;
            this.addMidiEntry.Text = "Add Midi Entry";
            this.addMidiEntry.UseVisualStyleBackColor = false;
            // 
            // MidiOptions
            // 
            this.MidiOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MidiOptions.FormattingEnabled = true;
            this.MidiOptions.ItemHeight = 16;
            this.MidiOptions.Location = new System.Drawing.Point(3, 40);
            this.MidiOptions.Name = "MidiOptions";
            this.MidiOptions.Size = new System.Drawing.Size(314, 180);
            this.MidiOptions.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Oswald", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "MIDI";
            // 
            // VirtualInputSelector
            // 
            this.VirtualInputSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VirtualInputSelector.Enabled = false;
            this.VirtualInputSelector.FormattingEnabled = true;
            this.VirtualInputSelector.Location = new System.Drawing.Point(160, 266);
            this.VirtualInputSelector.Name = "VirtualInputSelector";
            this.VirtualInputSelector.Size = new System.Drawing.Size(164, 24);
            this.VirtualInputSelector.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Font = new System.Drawing.Font("Oswald", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-1, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 27);
            this.label9.TabIndex = 13;
            this.label9.Text = "Virtual Input Device";
            // 
            // addKeyXinputEntry
            // 
            this.addKeyXinputEntry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addKeyXinputEntry.AutoSize = true;
            this.addKeyXinputEntry.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addKeyXinputEntry.BackColor = System.Drawing.SystemColors.Window;
            this.addKeyXinputEntry.Depth = 0;
            this.addKeyXinputEntry.Location = new System.Drawing.Point(4, 417);
            this.addKeyXinputEntry.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addKeyXinputEntry.MouseState = MaterialSkin.MouseState.HOVER;
            this.addKeyXinputEntry.Name = "addKeyXinputEntry";
            this.addKeyXinputEntry.Primary = false;
            this.addKeyXinputEntry.Size = new System.Drawing.Size(253, 36);
            this.addKeyXinputEntry.TabIndex = 7;
            this.addKeyXinputEntry.Text = "Add Keyboard/Xinput Entry";
            this.addKeyXinputEntry.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.Font = new System.Drawing.Font("Oswald", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-1, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 27);
            this.label10.TabIndex = 12;
            this.label10.Text = "Keyboard/Xinput";
            // 
            // KeyXinputOptions
            // 
            this.KeyXinputOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyXinputOptions.FormattingEnabled = true;
            this.KeyXinputOptions.ItemHeight = 16;
            this.KeyXinputOptions.Location = new System.Drawing.Point(3, 40);
            this.KeyXinputOptions.Name = "KeyXinputOptions";
            this.KeyXinputOptions.Size = new System.Drawing.Size(323, 180);
            this.KeyXinputOptions.TabIndex = 6;
            // 
            // OutputTypeSelector
            // 
            this.OutputTypeSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTypeSelector.FormattingEnabled = true;
            this.OutputTypeSelector.Items.AddRange(new object[] {
            "Keyboard",
            "Mouse"});
            this.OutputTypeSelector.Location = new System.Drawing.Point(161, 226);
            this.OutputTypeSelector.Name = "OutputTypeSelector";
            this.OutputTypeSelector.Size = new System.Drawing.Size(163, 24);
            this.OutputTypeSelector.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Oswald", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "Keyboard/Xinput";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(3, 796);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.label6);
            this.splitContainer3.Panel2.Controls.Add(this.EntryList);
            this.splitContainer3.Size = new System.Drawing.Size(657, 367);
            this.splitContainer3.SplitterDistance = 219;
            this.splitContainer3.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Oswald", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-4, -5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 37);
            this.label6.TabIndex = 7;
            this.label6.Text = "Controller Binds";
            // 
            // EntryList
            // 
            this.EntryList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntryList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EntryList.FormattingEnabled = true;
            this.EntryList.ItemHeight = 16;
            this.EntryList.Location = new System.Drawing.Point(3, 35);
            this.EntryList.Name = "EntryList";
            this.EntryList.Size = new System.Drawing.Size(428, 322);
            this.EntryList.TabIndex = 0;
            // 
            // MidiNotifyIcon
            // 
            this.MidiNotifyIcon.ContextMenuStrip = this.trayRightClickMenu;
            this.MidiNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MidiNotifyIcon.Icon")));
            this.MidiNotifyIcon.Text = "MidiPilot";
            this.MidiNotifyIcon.Visible = true;
            // 
            // trayRightClickMenu
            // 
            this.trayRightClickMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.trayRightClickMenu.Depth = 0;
            this.trayRightClickMenu.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.trayRightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrayMenuTitle,
            this.TrayMenuConnect});
            this.trayRightClickMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.trayRightClickMenu.Name = "trayRightClickMenu";
            this.trayRightClickMenu.Size = new System.Drawing.Size(139, 64);
            // 
            // TrayMenuTitle
            // 
            this.TrayMenuTitle.AutoSize = false;
            this.TrayMenuTitle.Enabled = false;
            this.TrayMenuTitle.Name = "TrayMenuTitle";
            this.TrayMenuTitle.Size = new System.Drawing.Size(120, 30);
            this.TrayMenuTitle.Text = "MidiPilot";
            // 
            // TrayMenuConnect
            // 
            this.TrayMenuConnect.AutoSize = false;
            this.TrayMenuConnect.Name = "TrayMenuConnect";
            this.TrayMenuConnect.Padding = new System.Windows.Forms.Padding(0, 11, 0, 1);
            this.TrayMenuConnect.Size = new System.Drawing.Size(120, 30);
            this.TrayMenuConnect.Text = "Device";
            this.TrayMenuConnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 1255);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(644, 1255);
            this.Name = "MainWindow";
            this.Text = "MidiPilot";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.trayRightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox MidiChannelSelector;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialRaisedButton MidiConnectBtn;
        private System.Windows.Forms.ListBox MidiLogBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MidiDeviceSelector;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon MidiNotifyIcon;
        private MaterialSkin.Controls.MaterialContextMenuStrip trayRightClickMenu;
        private MaterialSkin.Controls.MaterialToolStripMenuItem TrayMenuTitle;
        private MaterialSkin.Controls.MaterialToolStripMenuItem TrayMenuConnect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DeviceTypeMenu;
        private System.Windows.Forms.ListBox MidiOptions;
        private System.Windows.Forms.ListBox KeyXinputOptions;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox EntryList;
        private MaterialSkin.Controls.MaterialFlatButton addMidiEntry;
        private MaterialSkin.Controls.MaterialFlatButton addKeyXinputEntry;
        private System.Windows.Forms.ComboBox EventMidiChannelSelector;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox EventControlType;
        private System.Windows.Forms.ComboBox VirtualInputSelector;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox OutputTypeSelector;
        private MaterialSkin.Controls.MaterialFlatButton clearConsole;
        private MaterialSkin.Controls.MaterialFlatButton selectNone;
        private MaterialSkin.Controls.MaterialFlatButton selectAll;
    }
}

