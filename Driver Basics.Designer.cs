namespace AutoGarage
{
    partial class Driver_Basics
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
            this.basicdriverlabel = new System.Windows.Forms.Label();
            this.driverbasiccombobox = new System.Windows.Forms.ComboBox();
            this.driverbasicsrichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.driverbasicsbutton = new System.Windows.Forms.Button();
            this.driverreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // basicdriverlabel
            // 
            this.basicdriverlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.basicdriverlabel.AutoSize = true;
            this.basicdriverlabel.BackColor = System.Drawing.Color.Transparent;
            this.basicdriverlabel.Font = new System.Drawing.Font("Segoe Print", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicdriverlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.basicdriverlabel.Location = new System.Drawing.Point(56, 7);
            this.basicdriverlabel.Name = "basicdriverlabel";
            this.basicdriverlabel.Size = new System.Drawing.Size(638, 76);
            this.basicdriverlabel.TabIndex = 13;
            this.basicdriverlabel.Text = "Overall Vehicle Maintenance";
            this.basicdriverlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.basicdriverlabel.Click += new System.EventHandler(this.basicdriverlabel_Click);
            // 
            // driverbasiccombobox
            // 
            this.driverbasiccombobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.driverbasiccombobox.BackColor = System.Drawing.Color.White;
            this.driverbasiccombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.driverbasiccombobox.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverbasiccombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.driverbasiccombobox.FormattingEnabled = true;
            this.driverbasiccombobox.Location = new System.Drawing.Point(12, 95);
            this.driverbasiccombobox.Name = "driverbasiccombobox";
            this.driverbasiccombobox.Size = new System.Drawing.Size(416, 45);
            this.driverbasiccombobox.TabIndex = 15;
            this.driverbasiccombobox.SelectedIndexChanged += new System.EventHandler(this.driverbasiccombobox_SelectedIndexChanged);
            this.driverbasiccombobox.SelectionChangeCommitted += new System.EventHandler(this.driverbasiccombobox_SelectedIndexChanged);
            // 
            // driverbasicsrichTextBox1
            // 
            this.driverbasicsrichTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.driverbasicsrichTextBox1.BackColor = System.Drawing.Color.White;
            this.driverbasicsrichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.driverbasicsrichTextBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverbasicsrichTextBox1.ForeColor = System.Drawing.Color.ForestGreen;
            this.driverbasicsrichTextBox1.Location = new System.Drawing.Point(12, 164);
            this.driverbasicsrichTextBox1.Name = "driverbasicsrichTextBox1";
            this.driverbasicsrichTextBox1.ReadOnly = true;
            this.driverbasicsrichTextBox1.Size = new System.Drawing.Size(416, 524);
            this.driverbasicsrichTextBox1.TabIndex = 16;
            this.driverbasicsrichTextBox1.Text = "";
            this.driverbasicsrichTextBox1.TextChanged += new System.EventHandler(this.driverbasicsrichTextBox1_TextChanged);
            // 
            // driverbasicsbutton
            // 
            this.driverbasicsbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.driverbasicsbutton.AutoSize = true;
            this.driverbasicsbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.driverbasicsbutton.BackColor = System.Drawing.Color.Transparent;
            this.driverbasicsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.driverbasicsbutton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverbasicsbutton.ForeColor = System.Drawing.Color.Chocolate;
            this.driverbasicsbutton.Location = new System.Drawing.Point(104, 712);
            this.driverbasicsbutton.Name = "driverbasicsbutton";
            this.driverbasicsbutton.Size = new System.Drawing.Size(316, 42);
            this.driverbasicsbutton.TabIndex = 42;
            this.driverbasicsbutton.Text = "Return To Selection Panel";
            this.driverbasicsbutton.UseVisualStyleBackColor = false;
            this.driverbasicsbutton.Click += new System.EventHandler(this.driverbasicsbutton_Click);
            // 
            // driverreset
            // 
            this.driverreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.driverreset.AutoSize = true;
            this.driverreset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.driverreset.BackColor = System.Drawing.Color.Transparent;
            this.driverreset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.driverreset.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverreset.ForeColor = System.Drawing.Color.Chocolate;
            this.driverreset.Location = new System.Drawing.Point(12, 712);
            this.driverreset.Name = "driverreset";
            this.driverreset.Size = new System.Drawing.Size(86, 42);
            this.driverreset.TabIndex = 43;
            this.driverreset.Text = "Reset";
            this.driverreset.UseVisualStyleBackColor = false;
            this.driverreset.Click += new System.EventHandler(this.driverreset_Click);
            // 
            // Driver_Basics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 788);
            this.Controls.Add(this.driverreset);
            this.Controls.Add(this.driverbasicsbutton);
            this.Controls.Add(this.driverbasicsrichTextBox1);
            this.Controls.Add(this.driverbasiccombobox);
            this.Controls.Add(this.basicdriverlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(750, 650);
            this.Name = "Driver_Basics";
            this.Text = "Driver_Basics";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Driver_Basics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Label basicdriverlabel;
        private System.Windows.Forms.ComboBox driverbasiccombobox;
        private System.Windows.Forms.RichTextBox driverbasicsrichTextBox1;
        private System.Windows.Forms.Button driverbasicsbutton;
        private System.Windows.Forms.Button driverreset;
    }
}