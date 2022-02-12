namespace AutoGarage
{
    partial class The_Ignition
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
            this.ignitionlabel = new System.Windows.Forms.Label();
            this.ignitionrichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fuelcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.accelerationcomboBox = new System.Windows.Forms.ComboBox();
            this.accelerationlabel = new System.Windows.Forms.Label();
            this.enginemisfirecombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idlecomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plug = new System.Windows.Forms.Button();
            this.ignitionsbutton = new System.Windows.Forms.Button();
            this.igmbutton = new System.Windows.Forms.Button();
            this.igreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ignitionlabel
            // 
            this.ignitionlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ignitionlabel.AutoSize = true;
            this.ignitionlabel.BackColor = System.Drawing.Color.Transparent;
            this.ignitionlabel.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ignitionlabel.ForeColor = System.Drawing.Color.Blue;
            this.ignitionlabel.Location = new System.Drawing.Point(433, 35);
            this.ignitionlabel.Name = "ignitionlabel";
            this.ignitionlabel.Size = new System.Drawing.Size(519, 85);
            this.ignitionlabel.TabIndex = 15;
            this.ignitionlabel.Text = "The Ignition System";
            this.ignitionlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ignitionrichTextBox1
            // 
            this.ignitionrichTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ignitionrichTextBox1.BackColor = System.Drawing.Color.White;
            this.ignitionrichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ignitionrichTextBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ignitionrichTextBox1.ForeColor = System.Drawing.Color.ForestGreen;
            this.ignitionrichTextBox1.Location = new System.Drawing.Point(912, 123);
            this.ignitionrichTextBox1.Name = "ignitionrichTextBox1";
            this.ignitionrichTextBox1.ReadOnly = true;
            this.ignitionrichTextBox1.Size = new System.Drawing.Size(449, 510);
            this.ignitionrichTextBox1.TabIndex = 55;
            this.ignitionrichTextBox1.Text = "";
            // 
            // fuelcomboBox
            // 
            this.fuelcomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.fuelcomboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.fuelcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fuelcomboBox.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelcomboBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.fuelcomboBox.FormattingEnabled = true;
            this.fuelcomboBox.Location = new System.Drawing.Point(43, 328);
            this.fuelcomboBox.Name = "fuelcomboBox";
            this.fuelcomboBox.Size = new System.Drawing.Size(358, 40);
            this.fuelcomboBox.TabIndex = 59;
            this.fuelcomboBox.SelectedIndexChanged += new System.EventHandler(this.fuelcomboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(43, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 47);
            this.label2.TabIndex = 58;
            this.label2.Text = "Fuel Consumption";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // accelerationcomboBox
            // 
            this.accelerationcomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.accelerationcomboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.accelerationcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accelerationcomboBox.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accelerationcomboBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.accelerationcomboBox.FormattingEnabled = true;
            this.accelerationcomboBox.Location = new System.Drawing.Point(43, 218);
            this.accelerationcomboBox.Name = "accelerationcomboBox";
            this.accelerationcomboBox.Size = new System.Drawing.Size(358, 40);
            this.accelerationcomboBox.TabIndex = 57;
            this.accelerationcomboBox.SelectedIndexChanged += new System.EventHandler(this.accelerationcomboBox_SelectedIndexChanged);
            // 
            // accelerationlabel
            // 
            this.accelerationlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.accelerationlabel.AutoSize = true;
            this.accelerationlabel.BackColor = System.Drawing.Color.Transparent;
            this.accelerationlabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.accelerationlabel.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accelerationlabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.accelerationlabel.Location = new System.Drawing.Point(43, 168);
            this.accelerationlabel.Name = "accelerationlabel";
            this.accelerationlabel.Size = new System.Drawing.Size(189, 47);
            this.accelerationlabel.TabIndex = 56;
            this.accelerationlabel.Text = "Acceleration";
            this.accelerationlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // enginemisfirecombo
            // 
            this.enginemisfirecombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.enginemisfirecombo.Cursor = System.Windows.Forms.Cursors.Default;
            this.enginemisfirecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enginemisfirecombo.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enginemisfirecombo.ForeColor = System.Drawing.Color.DarkCyan;
            this.enginemisfirecombo.FormattingEnabled = true;
            this.enginemisfirecombo.Location = new System.Drawing.Point(43, 530);
            this.enginemisfirecombo.Name = "enginemisfirecombo";
            this.enginemisfirecombo.Size = new System.Drawing.Size(358, 40);
            this.enginemisfirecombo.TabIndex = 63;
            this.enginemisfirecombo.SelectedIndexChanged += new System.EventHandler(this.enginemisfirecombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(43, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 47);
            this.label3.TabIndex = 62;
            this.label3.Text = "Engine Misfiring";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // idlecomboBox
            // 
            this.idlecomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.idlecomboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.idlecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idlecomboBox.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlecomboBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.idlecomboBox.FormattingEnabled = true;
            this.idlecomboBox.Location = new System.Drawing.Point(43, 429);
            this.idlecomboBox.Name = "idlecomboBox";
            this.idlecomboBox.Size = new System.Drawing.Size(358, 40);
            this.idlecomboBox.TabIndex = 61;
            this.idlecomboBox.SelectedIndexChanged += new System.EventHandler(this.idlecomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(43, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 47);
            this.label1.TabIndex = 60;
            this.label1.Text = "Idle Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // plug
            // 
            this.plug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.plug.AutoSize = true;
            this.plug.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.plug.BackColor = System.Drawing.Color.Transparent;
            this.plug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plug.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.plug.Location = new System.Drawing.Point(43, 669);
            this.plug.Name = "plug";
            this.plug.Size = new System.Drawing.Size(199, 42);
            this.plug.TabIndex = 64;
            this.plug.Text = "View Diagnosis";
            this.plug.UseVisualStyleBackColor = false;
            this.plug.Click += new System.EventHandler(this.plug_Click);
            // 
            // ignitionsbutton
            // 
            this.ignitionsbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ignitionsbutton.AutoSize = true;
            this.ignitionsbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ignitionsbutton.BackColor = System.Drawing.Color.Transparent;
            this.ignitionsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ignitionsbutton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ignitionsbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ignitionsbutton.Location = new System.Drawing.Point(342, 669);
            this.ignitionsbutton.Name = "ignitionsbutton";
            this.ignitionsbutton.Size = new System.Drawing.Size(316, 42);
            this.ignitionsbutton.TabIndex = 65;
            this.ignitionsbutton.Text = "Return To Selection Panel";
            this.ignitionsbutton.UseVisualStyleBackColor = false;
            this.ignitionsbutton.Click += new System.EventHandler(this.ignitionsbutton_Click);
            // 
            // igmbutton
            // 
            this.igmbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.igmbutton.AutoSize = true;
            this.igmbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.igmbutton.BackColor = System.Drawing.Color.Transparent;
            this.igmbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.igmbutton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igmbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.igmbutton.Location = new System.Drawing.Point(679, 669);
            this.igmbutton.Name = "igmbutton";
            this.igmbutton.Size = new System.Drawing.Size(358, 42);
            this.igmbutton.TabIndex = 66;
            this.igmbutton.Text = "Ignition System Maintenance";
            this.igmbutton.UseVisualStyleBackColor = false;
            this.igmbutton.Click += new System.EventHandler(this.igmbutton_Click);
            // 
            // igreset
            // 
            this.igreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.igreset.AutoSize = true;
            this.igreset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.igreset.BackColor = System.Drawing.Color.Transparent;
            this.igreset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.igreset.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igreset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.igreset.Location = new System.Drawing.Point(43, 608);
            this.igreset.Name = "igreset";
            this.igreset.Size = new System.Drawing.Size(86, 42);
            this.igreset.TabIndex = 67;
            this.igreset.Text = "Reset";
            this.igreset.UseVisualStyleBackColor = false;
            this.igreset.Click += new System.EventHandler(this.igreset_Click);
            // 
            // The_Ignition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1385, 748);
            this.Controls.Add(this.igreset);
            this.Controls.Add(this.igmbutton);
            this.Controls.Add(this.ignitionsbutton);
            this.Controls.Add(this.plug);
            this.Controls.Add(this.enginemisfirecombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idlecomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fuelcomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accelerationcomboBox);
            this.Controls.Add(this.accelerationlabel);
            this.Controls.Add(this.ignitionrichTextBox1);
            this.Controls.Add(this.ignitionlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "The_Ignition";
            this.Text = "The_Ignition";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.The_Ignition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Label ignitionlabel;
        public System.Windows.Forms.RichTextBox ignitionrichTextBox1;
        private System.Windows.Forms.ComboBox fuelcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox accelerationcomboBox;
        private System.Windows.Forms.Label accelerationlabel;
        private System.Windows.Forms.ComboBox enginemisfirecombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox idlecomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button plug;
        private System.Windows.Forms.Button ignitionsbutton;
        private System.Windows.Forms.Button igmbutton;
        private System.Windows.Forms.Button igreset;
    }
}