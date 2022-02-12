namespace AutoGarage
{
    partial class FuelSystemMaintenance
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
            this.fuelcombo = new System.Windows.Forms.ComboBox();
            this.fuelrichbox = new System.Windows.Forms.RichTextBox();
            this.secondfuelpanel = new System.Windows.Forms.Button();
            this.fuelmaintenancreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // airdiagnosislabel
            // 
            this.airdiagnosislabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.airdiagnosislabel.AutoSize = true;
            this.airdiagnosislabel.BackColor = System.Drawing.Color.Transparent;
            this.airdiagnosislabel.Font = new System.Drawing.Font("Segoe Print", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airdiagnosislabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.airdiagnosislabel.Location = new System.Drawing.Point(387, -8);
            this.airdiagnosislabel.Name = "airdiagnosislabel";
            this.airdiagnosislabel.Size = new System.Drawing.Size(597, 76);
            this.airdiagnosislabel.TabIndex = 15;
            this.airdiagnosislabel.Text = " Fuel System Maintenance";
            this.airdiagnosislabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fuelcombo
            // 
            this.fuelcombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.fuelcombo.BackColor = System.Drawing.Color.White;
            this.fuelcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fuelcombo.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelcombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.fuelcombo.FormattingEnabled = true;
            this.fuelcombo.Location = new System.Drawing.Point(12, 159);
            this.fuelcombo.Name = "fuelcombo";
            this.fuelcombo.Size = new System.Drawing.Size(554, 50);
            this.fuelcombo.TabIndex = 16;
            this.fuelcombo.SelectedIndexChanged += new System.EventHandler(this.fuelcombo_SelectedIndexChanged);
            // 
            // fuelrichbox
            // 
            this.fuelrichbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.fuelrichbox.BackColor = System.Drawing.Color.White;
            this.fuelrichbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fuelrichbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelrichbox.ForeColor = System.Drawing.Color.ForestGreen;
            this.fuelrichbox.Location = new System.Drawing.Point(803, 159);
            this.fuelrichbox.Name = "fuelrichbox";
            this.fuelrichbox.ReadOnly = true;
            this.fuelrichbox.Size = new System.Drawing.Size(554, 479);
            this.fuelrichbox.TabIndex = 18;
            this.fuelrichbox.Text = "";
            // 
            // secondfuelpanel
            // 
            this.secondfuelpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.secondfuelpanel.AutoSize = true;
            this.secondfuelpanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.secondfuelpanel.BackColor = System.Drawing.Color.Transparent;
            this.secondfuelpanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.secondfuelpanel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondfuelpanel.ForeColor = System.Drawing.Color.Blue;
            this.secondfuelpanel.Location = new System.Drawing.Point(122, 682);
            this.secondfuelpanel.Name = "secondfuelpanel";
            this.secondfuelpanel.Size = new System.Drawing.Size(113, 47);
            this.secondfuelpanel.TabIndex = 63;
            this.secondfuelpanel.Text = "Return";
            this.secondfuelpanel.UseVisualStyleBackColor = false;
            this.secondfuelpanel.Click += new System.EventHandler(this.secondfuelpanel_Click);
            // 
            // fuelmaintenancreset
            // 
            this.fuelmaintenancreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.fuelmaintenancreset.AutoSize = true;
            this.fuelmaintenancreset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fuelmaintenancreset.BackColor = System.Drawing.Color.Transparent;
            this.fuelmaintenancreset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fuelmaintenancreset.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelmaintenancreset.ForeColor = System.Drawing.Color.Blue;
            this.fuelmaintenancreset.Location = new System.Drawing.Point(11, 682);
            this.fuelmaintenancreset.Name = "fuelmaintenancreset";
            this.fuelmaintenancreset.Size = new System.Drawing.Size(97, 47);
            this.fuelmaintenancreset.TabIndex = 64;
            this.fuelmaintenancreset.Text = "Reset";
            this.fuelmaintenancreset.UseVisualStyleBackColor = false;
            this.fuelmaintenancreset.Click += new System.EventHandler(this.fuelmaintenancreset_Click);
            // 
            // FuelSystemMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 747);
            this.Controls.Add(this.fuelmaintenancreset);
            this.Controls.Add(this.secondfuelpanel);
            this.Controls.Add(this.fuelrichbox);
            this.Controls.Add(this.fuelcombo);
            this.Controls.Add(this.airdiagnosislabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FuelSystemMaintenance";
            this.Text = "Fuel System Maintenance";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FuelSystemMaintenance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Label airdiagnosislabel;
        private System.Windows.Forms.ComboBox fuelcombo;
        private System.Windows.Forms.RichTextBox fuelrichbox;
        private System.Windows.Forms.Button secondfuelpanel;
        private System.Windows.Forms.Button fuelmaintenancreset;
    }
}