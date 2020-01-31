namespace serial_port_comunication
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
        ~MainWindow()
        {
            serialPort.Close();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.connectButton = new System.Windows.Forms.Button();
            this.comPortComboBox = new System.Windows.Forms.ComboBox();
            this.comPortLabel = new System.Windows.Forms.Label();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.dataBitsLabel = new System.Windows.Forms.Label();
            this.dataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.parityLabel = new System.Windows.Forms.Label();
            this.parityComboBox = new System.Windows.Forms.ComboBox();
            this.stopBitsLabel = new System.Windows.Forms.Label();
            this.stopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.rescanButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.sendDescriptionLabel = new System.Windows.Forms.Label();
            this.receiveDescriptionLabel = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.sendMessageTextBox = new System.Windows.Forms.TextBox();
            this.receivedMessageTextBox = new System.Windows.Forms.TextBox();
            this.clearRecivedMessageButton = new System.Windows.Forms.Button();
            this.clearSendMessageButton = new System.Windows.Forms.Button();
            this.inPlaceCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.Linen;
            this.connectButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.connectButton, "connectButton");
            this.connectButton.Name = "connectButton";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // comPortComboBox
            // 
            this.comPortComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.comPortComboBox, "comPortComboBox");
            this.comPortComboBox.Name = "comPortComboBox";
            // 
            // comPortLabel
            // 
            resources.ApplyResources(this.comPortLabel, "comPortLabel");
            this.comPortLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comPortLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comPortLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.comPortLabel.Name = "comPortLabel";
            // 
            // baudRateLabel
            // 
            resources.ApplyResources(this.baudRateLabel, "baudRateLabel");
            this.baudRateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.baudRateLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.baudRateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.baudRateLabel.Name = "baudRateLabel";
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Items.AddRange(new object[] {
            resources.GetString("baudRateComboBox.Items"),
            resources.GetString("baudRateComboBox.Items1"),
            resources.GetString("baudRateComboBox.Items2"),
            resources.GetString("baudRateComboBox.Items3"),
            resources.GetString("baudRateComboBox.Items4"),
            resources.GetString("baudRateComboBox.Items5"),
            resources.GetString("baudRateComboBox.Items6"),
            resources.GetString("baudRateComboBox.Items7"),
            resources.GetString("baudRateComboBox.Items8"),
            resources.GetString("baudRateComboBox.Items9"),
            resources.GetString("baudRateComboBox.Items10")});
            resources.ApplyResources(this.baudRateComboBox, "baudRateComboBox");
            this.baudRateComboBox.Name = "baudRateComboBox";
            // 
            // dataBitsLabel
            // 
            resources.ApplyResources(this.dataBitsLabel, "dataBitsLabel");
            this.dataBitsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataBitsLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataBitsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dataBitsLabel.Name = "dataBitsLabel";
            // 
            // dataBitsComboBox
            // 
            this.dataBitsComboBox.FormattingEnabled = true;
            this.dataBitsComboBox.Items.AddRange(new object[] {
            resources.GetString("dataBitsComboBox.Items"),
            resources.GetString("dataBitsComboBox.Items1"),
            resources.GetString("dataBitsComboBox.Items2"),
            resources.GetString("dataBitsComboBox.Items3")});
            resources.ApplyResources(this.dataBitsComboBox, "dataBitsComboBox");
            this.dataBitsComboBox.Name = "dataBitsComboBox";
            // 
            // parityLabel
            // 
            resources.ApplyResources(this.parityLabel, "parityLabel");
            this.parityLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.parityLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.parityLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.parityLabel.Name = "parityLabel";
            // 
            // parityComboBox
            // 
            this.parityComboBox.FormattingEnabled = true;
            this.parityComboBox.Items.AddRange(new object[] {
            resources.GetString("parityComboBox.Items"),
            resources.GetString("parityComboBox.Items1"),
            resources.GetString("parityComboBox.Items2"),
            resources.GetString("parityComboBox.Items3"),
            resources.GetString("parityComboBox.Items4")});
            resources.ApplyResources(this.parityComboBox, "parityComboBox");
            this.parityComboBox.Name = "parityComboBox";
            // 
            // stopBitsLabel
            // 
            resources.ApplyResources(this.stopBitsLabel, "stopBitsLabel");
            this.stopBitsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.stopBitsLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.stopBitsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stopBitsLabel.Name = "stopBitsLabel";
            // 
            // stopBitsComboBox
            // 
            this.stopBitsComboBox.FormattingEnabled = true;
            this.stopBitsComboBox.Items.AddRange(new object[] {
            resources.GetString("stopBitsComboBox.Items"),
            resources.GetString("stopBitsComboBox.Items1"),
            resources.GetString("stopBitsComboBox.Items2")});
            resources.ApplyResources(this.stopBitsComboBox, "stopBitsComboBox");
            this.stopBitsComboBox.Name = "stopBitsComboBox";
            // 
            // rescanButton
            // 
            this.rescanButton.BackColor = System.Drawing.Color.Linen;
            this.rescanButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.rescanButton, "rescanButton");
            this.rescanButton.Name = "rescanButton";
            this.rescanButton.UseVisualStyleBackColor = false;
            this.rescanButton.Click += new System.EventHandler(this.rescanButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.messageTextBox, "messageTextBox");
            this.messageTextBox.Name = "messageTextBox";
            // 
            // sendDescriptionLabel
            // 
            resources.ApplyResources(this.sendDescriptionLabel, "sendDescriptionLabel");
            this.sendDescriptionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.sendDescriptionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.sendDescriptionLabel.Name = "sendDescriptionLabel";
            // 
            // receiveDescriptionLabel
            // 
            resources.ApplyResources(this.receiveDescriptionLabel, "receiveDescriptionLabel");
            this.receiveDescriptionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.receiveDescriptionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.receiveDescriptionLabel.Name = "receiveDescriptionLabel";
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            resources.ApplyResources(this.sendButton, "sendButton");
            this.sendButton.ForeColor = System.Drawing.SystemColors.Control;
            this.sendButton.Name = "sendButton";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // sendMessageTextBox
            // 
            this.sendMessageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            resources.ApplyResources(this.sendMessageTextBox, "sendMessageTextBox");
            this.sendMessageTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.sendMessageTextBox.Name = "sendMessageTextBox";
            // 
            // receivedMessageTextBox
            // 
            this.receivedMessageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            resources.ApplyResources(this.receivedMessageTextBox, "receivedMessageTextBox");
            this.receivedMessageTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.receivedMessageTextBox.Name = "receivedMessageTextBox";
            // 
            // clearRecivedMessageButton
            // 
            this.clearRecivedMessageButton.BackColor = System.Drawing.Color.Linen;
            this.clearRecivedMessageButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.clearRecivedMessageButton, "clearRecivedMessageButton");
            this.clearRecivedMessageButton.Name = "clearRecivedMessageButton";
            this.clearRecivedMessageButton.UseVisualStyleBackColor = false;
            this.clearRecivedMessageButton.Click += new System.EventHandler(this.clearRecivedMessageButton_Click);
            // 
            // clearSendMessageButton
            // 
            this.clearSendMessageButton.BackColor = System.Drawing.Color.Linen;
            this.clearSendMessageButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.clearSendMessageButton, "clearSendMessageButton");
            this.clearSendMessageButton.Name = "clearSendMessageButton";
            this.clearSendMessageButton.UseVisualStyleBackColor = false;
            this.clearSendMessageButton.Click += new System.EventHandler(this.clearSendMessageButton_Click);
            // 
            // inPlaceCheckBox
            // 
            resources.ApplyResources(this.inPlaceCheckBox, "inPlaceCheckBox");
            this.inPlaceCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.inPlaceCheckBox.Name = "inPlaceCheckBox";
            this.inPlaceCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.inPlaceCheckBox);
            this.Controls.Add(this.clearSendMessageButton);
            this.Controls.Add(this.clearRecivedMessageButton);
            this.Controls.Add(this.receivedMessageTextBox);
            this.Controls.Add(this.sendMessageTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.receiveDescriptionLabel);
            this.Controls.Add(this.sendDescriptionLabel);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.rescanButton);
            this.Controls.Add(this.stopBitsLabel);
            this.Controls.Add(this.stopBitsComboBox);
            this.Controls.Add(this.parityLabel);
            this.Controls.Add(this.parityComboBox);
            this.Controls.Add(this.dataBitsLabel);
            this.Controls.Add(this.dataBitsComboBox);
            this.Controls.Add(this.baudRateLabel);
            this.Controls.Add(this.baudRateComboBox);
            this.Controls.Add(this.comPortLabel);
            this.Controls.Add(this.comPortComboBox);
            this.Controls.Add(this.connectButton);
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ComboBox comPortComboBox;
        private System.Windows.Forms.Label comPortLabel;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.Label dataBitsLabel;
        private System.Windows.Forms.ComboBox dataBitsComboBox;
        private System.Windows.Forms.Label parityLabel;
        private System.Windows.Forms.ComboBox parityComboBox;
        private System.Windows.Forms.Label stopBitsLabel;
        private System.Windows.Forms.ComboBox stopBitsComboBox;
        private System.Windows.Forms.Button rescanButton;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label sendDescriptionLabel;
        private System.Windows.Forms.Label receiveDescriptionLabel;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox sendMessageTextBox;
        private System.Windows.Forms.TextBox receivedMessageTextBox;
        private System.Windows.Forms.Button clearRecivedMessageButton;
        private System.Windows.Forms.Button clearSendMessageButton;
        private System.Windows.Forms.CheckBox inPlaceCheckBox;
    }
}

