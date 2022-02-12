namespace AutoGarage
{
    partial class DiagnosisArea
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
            this.selectdiagnosislabel = new System.Windows.Forms.Label();
            this.selectdiagnosiscombobox = new System.Windows.Forms.ComboBox();
            this.returnhomebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectdiagnosislabel
            // 
            this.selectdiagnosislabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.selectdiagnosislabel.AutoSize = true;
            this.selectdiagnosislabel.BackColor = System.Drawing.Color.Transparent;
            this.selectdiagnosislabel.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectdiagnosislabel.ForeColor = System.Drawing.Color.Green;
            this.selectdiagnosislabel.Location = new System.Drawing.Point(189, 231);
            this.selectdiagnosislabel.Name = "selectdiagnosislabel";
            this.selectdiagnosislabel.Size = new System.Drawing.Size(417, 85);
            this.selectdiagnosislabel.TabIndex = 13;
            this.selectdiagnosislabel.Text = "Select Diagnosis";
            this.selectdiagnosislabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectdiagnosislabel.Click += new System.EventHandler(this.selectdiagnosislabel_Click);
            // 
            // selectdiagnosiscombobox
            // 
            this.selectdiagnosiscombobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.selectdiagnosiscombobox.BackColor = System.Drawing.Color.White;
            this.selectdiagnosiscombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectdiagnosiscombobox.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectdiagnosiscombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectdiagnosiscombobox.FormattingEnabled = true;
            this.selectdiagnosiscombobox.Location = new System.Drawing.Point(139, 356);
            this.selectdiagnosiscombobox.Name = "selectdiagnosiscombobox";
            this.selectdiagnosiscombobox.Size = new System.Drawing.Size(516, 55);
            this.selectdiagnosiscombobox.TabIndex = 14;
            this.selectdiagnosiscombobox.SelectedIndexChanged += new System.EventHandler(this.selectdiagnosiscombobox_SelectedIndexChanged);
            // 
            // returnhomebutton
            // 
            this.returnhomebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.returnhomebutton.AutoSize = true;
            this.returnhomebutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.returnhomebutton.BackColor = System.Drawing.Color.Transparent;
            this.returnhomebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.returnhomebutton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnhomebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(128)))), ((int)(((byte)(23)))));
            this.returnhomebutton.Location = new System.Drawing.Point(236, 459);
            this.returnhomebutton.Name = "returnhomebutton";
            this.returnhomebutton.Size = new System.Drawing.Size(313, 47);
            this.returnhomebutton.TabIndex = 19;
            this.returnhomebutton.Text = "Return To Home Panel";
            this.returnhomebutton.UseVisualStyleBackColor = false;
            this.returnhomebutton.Click += new System.EventHandler(this.returnhomebutton_Click);
            // 
            // DiagnosisArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 739);
            this.Controls.Add(this.returnhomebutton);
            this.Controls.Add(this.selectdiagnosiscombobox);
            this.Controls.Add(this.selectdiagnosislabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "DiagnosisArea";
            this.Text = "DiagnosisArea";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DiagnosisArea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectdiagnosislabel;
        private System.Windows.Forms.ComboBox selectdiagnosiscombobox;
        private System.Windows.Forms.Button returnhomebutton;
    }
}