namespace AutoGarage
{
    partial class AutoForm
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
            this.autodiagnosislabel = new System.Windows.Forms.Label();
            this.welcomelabel = new System.Windows.Forms.Label();
            this.Beginbutton = new System.Windows.Forms.Button();
            this.Endbutton = new System.Windows.Forms.Button();
            this.dateinfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // autodiagnosislabel
            // 
            this.autodiagnosislabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.autodiagnosislabel.AutoSize = true;
            this.autodiagnosislabel.BackColor = System.Drawing.Color.Transparent;
            this.autodiagnosislabel.Font = new System.Drawing.Font("Segoe Print", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autodiagnosislabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.autodiagnosislabel.Location = new System.Drawing.Point(388, 173);
            this.autodiagnosislabel.Name = "autodiagnosislabel";
            this.autodiagnosislabel.Size = new System.Drawing.Size(457, 98);
            this.autodiagnosislabel.TabIndex = 12;
            this.autodiagnosislabel.Text = "Auto Diagnosis";
            this.autodiagnosislabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.autodiagnosislabel.Click += new System.EventHandler(this.autodiagnosislabel_Click);
            // 
            // welcomelabel
            // 
            this.welcomelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.welcomelabel.AutoSize = true;
            this.welcomelabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomelabel.Font = new System.Drawing.Font("Segoe UI Symbol", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomelabel.ForeColor = System.Drawing.Color.Blue;
            this.welcomelabel.Location = new System.Drawing.Point(499, 290);
            this.welcomelabel.Name = "welcomelabel";
            this.welcomelabel.Size = new System.Drawing.Size(234, 61);
            this.welcomelabel.TabIndex = 18;
            this.welcomelabel.Text = "Welcome ";
            this.welcomelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Beginbutton
            // 
            this.Beginbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Beginbutton.AutoSize = true;
            this.Beginbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Beginbutton.BackColor = System.Drawing.Color.Transparent;
            this.Beginbutton.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.Beginbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Beginbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Beginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Beginbutton.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beginbutton.ForeColor = System.Drawing.Color.OrangeRed;
            this.Beginbutton.Location = new System.Drawing.Point(506, 387);
            this.Beginbutton.Name = "Beginbutton";
            this.Beginbutton.Size = new System.Drawing.Size(112, 61);
            this.Beginbutton.TabIndex = 27;
            this.Beginbutton.Text = "Begin";
            this.Beginbutton.UseVisualStyleBackColor = false;
            this.Beginbutton.Click += new System.EventHandler(this.Beginbutton_Click);
            // 
            // Endbutton
            // 
            this.Endbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Endbutton.AutoSize = true;
            this.Endbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Endbutton.BackColor = System.Drawing.Color.Transparent;
            this.Endbutton.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.Endbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Endbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Endbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Endbutton.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Endbutton.ForeColor = System.Drawing.Color.OrangeRed;
            this.Endbutton.Location = new System.Drawing.Point(637, 387);
            this.Endbutton.MinimumSize = new System.Drawing.Size(79, 42);
            this.Endbutton.Name = "Endbutton";
            this.Endbutton.Size = new System.Drawing.Size(90, 61);
            this.Endbutton.TabIndex = 28;
            this.Endbutton.Text = "End";
            this.Endbutton.UseVisualStyleBackColor = false;
            this.Endbutton.Click += new System.EventHandler(this.Endbutton_Click);
            // 
            // dateinfo
            // 
            this.dateinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateinfo.AutoSize = true;
            this.dateinfo.BackColor = System.Drawing.Color.Transparent;
            this.dateinfo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateinfo.ForeColor = System.Drawing.Color.OrangeRed;
            this.dateinfo.Location = new System.Drawing.Point(1048, 9);
            this.dateinfo.Name = "dateinfo";
            this.dateinfo.Size = new System.Drawing.Size(47, 28);
            this.dateinfo.TabIndex = 30;
            this.dateinfo.Text = "date";
            this.dateinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1233, 749);
            this.Controls.Add(this.dateinfo);
            this.Controls.Add(this.Endbutton);
            this.Controls.Add(this.Beginbutton);
            this.Controls.Add(this.welcomelabel);
            this.Controls.Add(this.autodiagnosislabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(550, 520);
            this.Name = "AutoForm";
            this.Text = "Auto";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AutoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label autodiagnosislabel;
        private System.Windows.Forms.Label welcomelabel;
        private System.Windows.Forms.Button Beginbutton;
        private System.Windows.Forms.Button Endbutton;
        private System.Windows.Forms.Label dateinfo;
    }
}

