namespace AutoGarage
{
    partial class Transmision
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
            this.drivetrainlabel = new System.Windows.Forms.Label();
            this.Transmissioncombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.transmissioninfo = new System.Windows.Forms.RichTextBox();
            this.transmissionreset = new System.Windows.Forms.Button();
            this.transmissionreturn = new System.Windows.Forms.Button();
            this.transmissiondiagnosis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drivetrainlabel
            // 
            this.drivetrainlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.drivetrainlabel.AutoSize = true;
            this.drivetrainlabel.BackColor = System.Drawing.Color.Transparent;
            this.drivetrainlabel.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drivetrainlabel.ForeColor = System.Drawing.Color.Blue;
            this.drivetrainlabel.Location = new System.Drawing.Point(281, 0);
            this.drivetrainlabel.Name = "drivetrainlabel";
            this.drivetrainlabel.Size = new System.Drawing.Size(561, 85);
            this.drivetrainlabel.TabIndex = 15;
            this.drivetrainlabel.Text = "Transmission Slipping";
            this.drivetrainlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Transmissioncombo
            // 
            this.Transmissioncombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Transmissioncombo.BackColor = System.Drawing.Color.White;
            this.Transmissioncombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Transmissioncombo.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transmissioncombo.ForeColor = System.Drawing.Color.Green;
            this.Transmissioncombo.FormattingEnabled = true;
            this.Transmissioncombo.Location = new System.Drawing.Point(6, 143);
            this.Transmissioncombo.Name = "Transmissioncombo";
            this.Transmissioncombo.Size = new System.Drawing.Size(460, 50);
            this.Transmissioncombo.TabIndex = 19;
            this.Transmissioncombo.SelectedIndexChanged += new System.EventHandler(this.Transmissioncombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(-2, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 57);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sound When Shifting Gears";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transmissioninfo
            // 
            this.transmissioninfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.transmissioninfo.BackColor = System.Drawing.Color.White;
            this.transmissioninfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transmissioninfo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transmissioninfo.ForeColor = System.Drawing.Color.ForestGreen;
            this.transmissioninfo.Location = new System.Drawing.Point(6, 243);
            this.transmissioninfo.Name = "transmissioninfo";
            this.transmissioninfo.ReadOnly = true;
            this.transmissioninfo.Size = new System.Drawing.Size(460, 481);
            this.transmissioninfo.TabIndex = 21;
            this.transmissioninfo.Text = "";
            this.transmissioninfo.TextChanged += new System.EventHandler(this.transmissioninfo_TextChanged);
            // 
            // transmissionreset
            // 
            this.transmissionreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.transmissionreset.AutoSize = true;
            this.transmissionreset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.transmissionreset.BackColor = System.Drawing.Color.Transparent;
            this.transmissionreset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.transmissionreset.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transmissionreset.ForeColor = System.Drawing.Color.Blue;
            this.transmissionreset.Location = new System.Drawing.Point(706, 702);
            this.transmissionreset.Name = "transmissionreset";
            this.transmissionreset.Size = new System.Drawing.Size(86, 42);
            this.transmissionreset.TabIndex = 43;
            this.transmissionreset.Text = "Reset";
            this.transmissionreset.UseVisualStyleBackColor = false;
            this.transmissionreset.Click += new System.EventHandler(this.transmissionreset_Click);
            // 
            // transmissionreturn
            // 
            this.transmissionreturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.transmissionreturn.AutoSize = true;
            this.transmissionreturn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.transmissionreturn.BackColor = System.Drawing.Color.Transparent;
            this.transmissionreturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.transmissionreturn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transmissionreturn.ForeColor = System.Drawing.Color.Blue;
            this.transmissionreturn.Location = new System.Drawing.Point(1003, 702);
            this.transmissionreturn.Name = "transmissionreturn";
            this.transmissionreturn.Size = new System.Drawing.Size(102, 42);
            this.transmissionreturn.TabIndex = 44;
            this.transmissionreturn.Text = "Return";
            this.transmissionreturn.UseVisualStyleBackColor = false;
            this.transmissionreturn.Click += new System.EventHandler(this.transmissionreturn_Click);
            // 
            // transmissiondiagnosis
            // 
            this.transmissiondiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.transmissiondiagnosis.AutoSize = true;
            this.transmissiondiagnosis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.transmissiondiagnosis.BackColor = System.Drawing.Color.Transparent;
            this.transmissiondiagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.transmissiondiagnosis.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transmissiondiagnosis.ForeColor = System.Drawing.Color.Blue;
            this.transmissiondiagnosis.Location = new System.Drawing.Point(798, 702);
            this.transmissiondiagnosis.Name = "transmissiondiagnosis";
            this.transmissiondiagnosis.Size = new System.Drawing.Size(199, 42);
            this.transmissiondiagnosis.TabIndex = 45;
            this.transmissiondiagnosis.Text = "View Diagnosis";
            this.transmissiondiagnosis.UseVisualStyleBackColor = false;
            this.transmissiondiagnosis.Click += new System.EventHandler(this.transmissiondiagnosis_Click);
            // 
            // Transmision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 759);
            this.Controls.Add(this.transmissiondiagnosis);
            this.Controls.Add(this.transmissionreturn);
            this.Controls.Add(this.transmissionreset);
            this.Controls.Add(this.transmissioninfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Transmissioncombo);
            this.Controls.Add(this.drivetrainlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transmision";
            this.Text = "Transmision";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Transmision_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label drivetrainlabel;
        private System.Windows.Forms.ComboBox Transmissioncombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox transmissioninfo;
        private System.Windows.Forms.Button transmissionreset;
        private System.Windows.Forms.Button transmissionreturn;
        private System.Windows.Forms.Button transmissiondiagnosis;
    }
}