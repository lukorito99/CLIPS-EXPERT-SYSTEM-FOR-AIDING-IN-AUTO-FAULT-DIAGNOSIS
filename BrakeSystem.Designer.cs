namespace AutoGarage
{
    partial class BrakeSystem
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
            this.airdiagnosislabel = new System.Windows.Forms.Label();
            this.soundbrakecomboBox = new System.Windows.Forms.ComboBox();
            this.checkenginelightlabel = new System.Windows.Forms.Label();
            this.shuddercombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PullcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.effortcombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.brakerichbox = new System.Windows.Forms.RichTextBox();
            this.brakeid = new System.Windows.Forms.Button();
            this.brakepanel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Brakereset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // airdiagnosislabel
            // 
            this.airdiagnosislabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.airdiagnosislabel.AutoSize = true;
            this.airdiagnosislabel.BackColor = System.Drawing.Color.Transparent;
            this.airdiagnosislabel.Font = new System.Drawing.Font("Segoe Print", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airdiagnosislabel.ForeColor = System.Drawing.Color.Blue;
            this.airdiagnosislabel.Location = new System.Drawing.Point(421, 1);
            this.airdiagnosislabel.Name = "airdiagnosislabel";
            this.airdiagnosislabel.Size = new System.Drawing.Size(544, 76);
            this.airdiagnosislabel.TabIndex = 16;
            this.airdiagnosislabel.Text = "Brake System Diagnosis";
            this.airdiagnosislabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.airdiagnosislabel.Click += new System.EventHandler(this.airdiagnosislabel_Click);
            // 
            // soundbrakecomboBox
            // 
            this.soundbrakecomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.soundbrakecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.soundbrakecomboBox.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundbrakecomboBox.ForeColor = System.Drawing.Color.Blue;
            this.soundbrakecomboBox.FormattingEnabled = true;
            this.soundbrakecomboBox.Location = new System.Drawing.Point(25, 168);
            this.soundbrakecomboBox.Name = "soundbrakecomboBox";
            this.soundbrakecomboBox.Size = new System.Drawing.Size(461, 40);
            this.soundbrakecomboBox.TabIndex = 26;
            this.soundbrakecomboBox.SelectedIndexChanged += new System.EventHandler(this.soundbrakecomboBox_SelectedIndexChanged);
            // 
            // checkenginelightlabel
            // 
            this.checkenginelightlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.checkenginelightlabel.AutoSize = true;
            this.checkenginelightlabel.BackColor = System.Drawing.Color.Transparent;
            this.checkenginelightlabel.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkenginelightlabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.checkenginelightlabel.Location = new System.Drawing.Point(18, 128);
            this.checkenginelightlabel.Name = "checkenginelightlabel";
            this.checkenginelightlabel.Size = new System.Drawing.Size(363, 43);
            this.checkenginelightlabel.TabIndex = 25;
            this.checkenginelightlabel.Text = "Sound When Brakes Applied";
            this.checkenginelightlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // shuddercombo
            // 
            this.shuddercombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.shuddercombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shuddercombo.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shuddercombo.ForeColor = System.Drawing.Color.Blue;
            this.shuddercombo.FormattingEnabled = true;
            this.shuddercombo.Location = new System.Drawing.Point(25, 276);
            this.shuddercombo.Name = "shuddercombo";
            this.shuddercombo.Size = new System.Drawing.Size(461, 40);
            this.shuddercombo.TabIndex = 28;
            this.shuddercombo.SelectedIndexChanged += new System.EventHandler(this.shuddercombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(18, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 43);
            this.label1.TabIndex = 27;
            this.label1.Text = "Vehicle Shudders When Braked";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PullcomboBox
            // 
            this.PullcomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PullcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PullcomboBox.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PullcomboBox.ForeColor = System.Drawing.Color.Blue;
            this.PullcomboBox.FormattingEnabled = true;
            this.PullcomboBox.Location = new System.Drawing.Point(26, 389);
            this.PullcomboBox.Name = "PullcomboBox";
            this.PullcomboBox.Size = new System.Drawing.Size(460, 40);
            this.PullcomboBox.TabIndex = 30;
            this.PullcomboBox.SelectedIndexChanged += new System.EventHandler(this.PullcomboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(19, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 43);
            this.label2.TabIndex = 29;
            this.label2.Text = "Vehicle Pulls To  Side When Braked";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // effortcombo
            // 
            this.effortcombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.effortcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.effortcombo.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effortcombo.ForeColor = System.Drawing.Color.Blue;
            this.effortcombo.FormattingEnabled = true;
            this.effortcombo.Location = new System.Drawing.Point(26, 497);
            this.effortcombo.Name = "effortcombo";
            this.effortcombo.Size = new System.Drawing.Size(460, 40);
            this.effortcombo.TabIndex = 32;
            this.effortcombo.SelectedIndexChanged += new System.EventHandler(this.effortcombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(19, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(422, 43);
            this.label3.TabIndex = 31;
            this.label3.Text = "Effort Taken To Apply Brakes    ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // brakerichbox
            // 
            this.brakerichbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.brakerichbox.BackColor = System.Drawing.Color.White;
            this.brakerichbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.brakerichbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brakerichbox.ForeColor = System.Drawing.Color.ForestGreen;
            this.brakerichbox.Location = new System.Drawing.Point(778, 133);
            this.brakerichbox.Name = "brakerichbox";
            this.brakerichbox.ReadOnly = true;
            this.brakerichbox.Size = new System.Drawing.Size(593, 404);
            this.brakerichbox.TabIndex = 33;
            this.brakerichbox.Text = "";
            this.brakerichbox.TextChanged += new System.EventHandler(this.brakerichbox_TextChanged);
            // 
            // brakeid
            // 
            this.brakeid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.brakeid.AutoSize = true;
            this.brakeid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.brakeid.BackColor = System.Drawing.Color.Transparent;
            this.brakeid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brakeid.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brakeid.ForeColor = System.Drawing.Color.Blue;
            this.brakeid.Location = new System.Drawing.Point(296, 654);
            this.brakeid.Name = "brakeid";
            this.brakeid.Size = new System.Drawing.Size(199, 42);
            this.brakeid.TabIndex = 64;
            this.brakeid.Text = "View Diagnosis";
            this.brakeid.UseVisualStyleBackColor = false;
            this.brakeid.Click += new System.EventHandler(this.brakeid_Click);
            // 
            // brakepanel
            // 
            this.brakepanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.brakepanel.AutoSize = true;
            this.brakepanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.brakepanel.BackColor = System.Drawing.Color.Transparent;
            this.brakepanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brakepanel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brakepanel.ForeColor = System.Drawing.Color.Blue;
            this.brakepanel.Location = new System.Drawing.Point(523, 654);
            this.brakepanel.Name = "brakepanel";
            this.brakepanel.Size = new System.Drawing.Size(316, 42);
            this.brakepanel.TabIndex = 65;
            this.brakepanel.Text = "Return To Selection Panel";
            this.brakepanel.UseVisualStyleBackColor = false;
            this.brakepanel.Click += new System.EventHandler(this.brakepanel_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(867, 654);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(331, 42);
            this.button1.TabIndex = 66;
            this.button1.Text = "Brake System Maintenance";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Brakereset
            // 
            this.Brakereset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Brakereset.AutoSize = true;
            this.Brakereset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Brakereset.BackColor = System.Drawing.Color.Transparent;
            this.Brakereset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Brakereset.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brakereset.ForeColor = System.Drawing.Color.Blue;
            this.Brakereset.Location = new System.Drawing.Point(189, 654);
            this.Brakereset.Name = "Brakereset";
            this.Brakereset.Size = new System.Drawing.Size(86, 42);
            this.Brakereset.TabIndex = 67;
            this.Brakereset.Text = "Reset";
            this.Brakereset.UseVisualStyleBackColor = false;
            this.Brakereset.Click += new System.EventHandler(this.Brakereset_Click);
            // 
            // BrakeSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 749);
            this.Controls.Add(this.Brakereset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.brakepanel);
            this.Controls.Add(this.brakeid);
            this.Controls.Add(this.brakerichbox);
            this.Controls.Add(this.effortcombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PullcomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shuddercombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soundbrakecomboBox);
            this.Controls.Add(this.checkenginelightlabel);
            this.Controls.Add(this.airdiagnosislabel);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BrakeSystem";
            this.Text = "The Brake System";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BrakeSystem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        private System.Windows.Forms.Label airdiagnosislabel;
        private System.Windows.Forms.ComboBox soundbrakecomboBox;
        private System.Windows.Forms.Label checkenginelightlabel;
        private System.Windows.Forms.ComboBox shuddercombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PullcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox effortcombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox brakerichbox;
        private System.Windows.Forms.Button brakeid;
        private System.Windows.Forms.Button brakepanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Brakereset;
    }
}