namespace AutoGarage
{
    partial class airconditioning
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
            this.airconditioningdiagnosiscombobox = new System.Windows.Forms.ComboBox();
            this.acrichbox = new System.Windows.Forms.RichTextBox();
            this.returnselectbutton = new System.Windows.Forms.Button();
            this.acreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // airdiagnosislabel
            // 
            this.airdiagnosislabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.airdiagnosislabel.AutoSize = true;
            this.airdiagnosislabel.BackColor = System.Drawing.Color.Transparent;
            this.airdiagnosislabel.Font = new System.Drawing.Font("Segoe Print", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airdiagnosislabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.airdiagnosislabel.Location = new System.Drawing.Point(244, 33);
            this.airdiagnosislabel.Name = "airdiagnosislabel";
            this.airdiagnosislabel.Size = new System.Drawing.Size(773, 76);
            this.airdiagnosislabel.TabIndex = 14;
            this.airdiagnosislabel.Text = "Air Conditioning System Diagnosis";
            this.airdiagnosislabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.airdiagnosislabel.Click += new System.EventHandler(this.airdiagnosislabel_Click);
            // 
            // airconditioningdiagnosiscombobox
            // 
            this.airconditioningdiagnosiscombobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.airconditioningdiagnosiscombobox.BackColor = System.Drawing.Color.White;
            this.airconditioningdiagnosiscombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.airconditioningdiagnosiscombobox.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airconditioningdiagnosiscombobox.ForeColor = System.Drawing.Color.Chocolate;
            this.airconditioningdiagnosiscombobox.FormattingEnabled = true;
            this.airconditioningdiagnosiscombobox.Location = new System.Drawing.Point(703, 112);
            this.airconditioningdiagnosiscombobox.Name = "airconditioningdiagnosiscombobox";
            this.airconditioningdiagnosiscombobox.Size = new System.Drawing.Size(545, 50);
            this.airconditioningdiagnosiscombobox.TabIndex = 15;
            this.airconditioningdiagnosiscombobox.SelectedIndexChanged += new System.EventHandler(this.airconditioningdiagnosiscombobox_SelectedIndexChanged);
            this.airconditioningdiagnosiscombobox.SelectionChangeCommitted += new System.EventHandler(this.airconditioningdiagnosiscombobox_SelectedIndexChanged);
            // 
            // acrichbox
            // 
            this.acrichbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.acrichbox.BackColor = System.Drawing.Color.White;
            this.acrichbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.acrichbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acrichbox.ForeColor = System.Drawing.Color.ForestGreen;
            this.acrichbox.Location = new System.Drawing.Point(702, 198);
            this.acrichbox.Name = "acrichbox";
            this.acrichbox.ReadOnly = true;
            this.acrichbox.Size = new System.Drawing.Size(545, 430);
            this.acrichbox.TabIndex = 17;
            this.acrichbox.Text = "";
            this.acrichbox.TextChanged += new System.EventHandler(this.acrichbox_TextChanged);
            // 
            // returnselectbutton
            // 
            this.returnselectbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.returnselectbutton.AutoSize = true;
            this.returnselectbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.returnselectbutton.BackColor = System.Drawing.Color.Transparent;
            this.returnselectbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.returnselectbutton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnselectbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.returnselectbutton.Location = new System.Drawing.Point(802, 648);
            this.returnselectbutton.Name = "returnselectbutton";
            this.returnselectbutton.Size = new System.Drawing.Size(316, 42);
            this.returnselectbutton.TabIndex = 18;
            this.returnselectbutton.Text = "Return To Selection Panel";
            this.returnselectbutton.UseVisualStyleBackColor = false;
            this.returnselectbutton.Click += new System.EventHandler(this.returnselectbutton_Click);
            // 
            // acreset
            // 
            this.acreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.acreset.AutoSize = true;
            this.acreset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.acreset.BackColor = System.Drawing.Color.Transparent;
            this.acreset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.acreset.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acreset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.acreset.Location = new System.Drawing.Point(702, 648);
            this.acreset.Name = "acreset";
            this.acreset.Size = new System.Drawing.Size(86, 42);
            this.acreset.TabIndex = 19;
            this.acreset.Text = "Reset";
            this.acreset.UseVisualStyleBackColor = false;
            this.acreset.Click += new System.EventHandler(this.acreset_Click);
            // 
            // airconditioning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1260, 749);
            this.Controls.Add(this.acreset);
            this.Controls.Add(this.returnselectbutton);
            this.Controls.Add(this.acrichbox);
            this.Controls.Add(this.airconditioningdiagnosiscombobox);
            this.Controls.Add(this.airdiagnosislabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(900, 726);
            this.Name = "airconditioning";
            this.Text = "airconditioning";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.airconditioning_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
      
        private System.Windows.Forms.Label airdiagnosislabel;
        private System.Windows.Forms.ComboBox airconditioningdiagnosiscombobox;
        private System.Windows.Forms.RichTextBox acrichbox;
        private System.Windows.Forms.Button returnselectbutton;
        private System.Windows.Forms.Button acreset;
    }
}