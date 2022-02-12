namespace AutoGarage
{
    partial class Engine_Maintenance
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
            this.maintaincombobox = new System.Windows.Forms.ComboBox();
            this.maintain = new System.Windows.Forms.RichTextBox();
            this.returnbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // airdiagnosislabel
            // 
            this.airdiagnosislabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.airdiagnosislabel.AutoSize = true;
            this.airdiagnosislabel.BackColor = System.Drawing.Color.Transparent;
            this.airdiagnosislabel.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airdiagnosislabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.airdiagnosislabel.Location = new System.Drawing.Point(349, -9);
            this.airdiagnosislabel.Name = "airdiagnosislabel";
            this.airdiagnosislabel.Size = new System.Drawing.Size(526, 85);
            this.airdiagnosislabel.TabIndex = 15;
            this.airdiagnosislabel.Text = "Engine Maintenance";
            this.airdiagnosislabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.airdiagnosislabel.Click += new System.EventHandler(this.airdiagnosislabel_Click);
            // 
            // maintaincombobox
            // 
            this.maintaincombobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.maintaincombobox.BackColor = System.Drawing.Color.White;
            this.maintaincombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maintaincombobox.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintaincombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.maintaincombobox.FormattingEnabled = true;
            this.maintaincombobox.Location = new System.Drawing.Point(297, 75);
            this.maintaincombobox.Name = "maintaincombobox";
            this.maintaincombobox.Size = new System.Drawing.Size(631, 51);
            this.maintaincombobox.TabIndex = 16;
            this.maintaincombobox.SelectedIndexChanged += new System.EventHandler(this.maintaincombobox_SelectedIndexChanged);
            // 
            // maintain
            // 
            this.maintain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.maintain.BackColor = System.Drawing.Color.White;
            this.maintain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maintain.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintain.ForeColor = System.Drawing.Color.ForestGreen;
            this.maintain.Location = new System.Drawing.Point(152, 465);
            this.maintain.Name = "maintain";
            this.maintain.ReadOnly = true;
            this.maintain.Size = new System.Drawing.Size(920, 251);
            this.maintain.TabIndex = 18;
            this.maintain.Text = "";
            this.maintain.TextChanged += new System.EventHandler(this.maintain_TextChanged);
            // 
            // returnbutton
            // 
            this.returnbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.returnbutton.AutoSize = true;
            this.returnbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.returnbutton.BackColor = System.Drawing.Color.Transparent;
            this.returnbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.returnbutton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbutton.ForeColor = System.Drawing.Color.Blue;
            this.returnbutton.Location = new System.Drawing.Point(1093, 669);
            this.returnbutton.Name = "returnbutton";
            this.returnbutton.Size = new System.Drawing.Size(120, 47);
            this.returnbutton.TabIndex = 43;
            this.returnbutton.Text = "Return ";
            this.returnbutton.UseVisualStyleBackColor = false;
            this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(1093, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 47);
            this.button1.TabIndex = 44;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Engine_Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1225, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.returnbutton);
            this.Controls.Add(this.maintain);
            this.Controls.Add(this.maintaincombobox);
            this.Controls.Add(this.airdiagnosislabel);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Engine_Maintenance";
            this.Text = "Engine Maintenance";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Engine_Maintenance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Label airdiagnosislabel;
        private System.Windows.Forms.ComboBox maintaincombobox;
        private System.Windows.Forms.RichTextBox maintain;
        private System.Windows.Forms.Button returnbutton;
        private System.Windows.Forms.Button button1;
    }
}