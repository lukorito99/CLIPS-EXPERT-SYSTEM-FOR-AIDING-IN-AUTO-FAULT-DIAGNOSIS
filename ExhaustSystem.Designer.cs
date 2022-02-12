namespace AutoGarage
{
    partial class ExhaustSystem
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
            this.exhaust = new System.Windows.Forms.RichTextBox();
            this.exhaustcombobox = new System.Windows.Forms.ComboBox();
            this.airdiagnosislabel = new System.Windows.Forms.Label();
            this.returnexhaust = new System.Windows.Forms.Button();
            this.exhaustreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exhaust
            // 
            this.exhaust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.exhaust.BackColor = System.Drawing.Color.White;
            this.exhaust.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exhaust.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exhaust.ForeColor = System.Drawing.Color.ForestGreen;
            this.exhaust.Location = new System.Drawing.Point(21, 181);
            this.exhaust.Name = "exhaust";
            this.exhaust.ReadOnly = true;
            this.exhaust.Size = new System.Drawing.Size(593, 435);
            this.exhaust.TabIndex = 21;
            this.exhaust.Text = "";
            this.exhaust.TextChanged += new System.EventHandler(this.exhaust_TextChanged);
            // 
            // exhaustcombobox
            // 
            this.exhaustcombobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.exhaustcombobox.BackColor = System.Drawing.Color.White;
            this.exhaustcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exhaustcombobox.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exhaustcombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.exhaustcombobox.FormattingEnabled = true;
            this.exhaustcombobox.Location = new System.Drawing.Point(21, 105);
            this.exhaustcombobox.Name = "exhaustcombobox";
            this.exhaustcombobox.Size = new System.Drawing.Size(593, 55);
            this.exhaustcombobox.TabIndex = 20;
            this.exhaustcombobox.SelectedIndexChanged += new System.EventHandler(this.exhaustcombobox_SelectedIndexChanged);
            // 
            // airdiagnosislabel
            // 
            this.airdiagnosislabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.airdiagnosislabel.AutoSize = true;
            this.airdiagnosislabel.BackColor = System.Drawing.Color.Transparent;
            this.airdiagnosislabel.Font = new System.Drawing.Font("Segoe Print", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airdiagnosislabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(25)))));
            this.airdiagnosislabel.Location = new System.Drawing.Point(83, 18);
            this.airdiagnosislabel.Name = "airdiagnosislabel";
            this.airdiagnosislabel.Size = new System.Drawing.Size(468, 76);
            this.airdiagnosislabel.TabIndex = 19;
            this.airdiagnosislabel.Text = "The Exhaust System";
            this.airdiagnosislabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.airdiagnosislabel.Click += new System.EventHandler(this.airdiagnosislabel_Click);
            // 
            // returnexhaust
            // 
            this.returnexhaust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.returnexhaust.AutoSize = true;
            this.returnexhaust.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.returnexhaust.BackColor = System.Drawing.Color.Transparent;
            this.returnexhaust.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.returnexhaust.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnexhaust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.returnexhaust.Location = new System.Drawing.Point(138, 638);
            this.returnexhaust.Name = "returnexhaust";
            this.returnexhaust.Size = new System.Drawing.Size(376, 50);
            this.returnexhaust.TabIndex = 44;
            this.returnexhaust.Text = "Return To Selection Panel";
            this.returnexhaust.UseVisualStyleBackColor = false;
            this.returnexhaust.Click += new System.EventHandler(this.returnexhaust_Click);
            // 
            // exhaustreset
            // 
            this.exhaustreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.exhaustreset.AutoSize = true;
            this.exhaustreset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exhaustreset.BackColor = System.Drawing.Color.Transparent;
            this.exhaustreset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exhaustreset.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exhaustreset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exhaustreset.Location = new System.Drawing.Point(21, 638);
            this.exhaustreset.Name = "exhaustreset";
            this.exhaustreset.Size = new System.Drawing.Size(101, 50);
            this.exhaustreset.TabIndex = 45;
            this.exhaustreset.Text = "Reset";
            this.exhaustreset.UseVisualStyleBackColor = false;
            this.exhaustreset.Click += new System.EventHandler(this.exhaustreset_Click);
            // 
            // ExhaustSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1329, 719);
            this.Controls.Add(this.exhaustreset);
            this.Controls.Add(this.returnexhaust);
            this.Controls.Add(this.exhaust);
            this.Controls.Add(this.exhaustcombobox);
            this.Controls.Add(this.airdiagnosislabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExhaustSystem";
            this.Text = "ExhaustSystem";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExhaustSystem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.RichTextBox exhaust;
        private System.Windows.Forms.ComboBox exhaustcombobox;
        private System.Windows.Forms.Label airdiagnosislabel;
        private System.Windows.Forms.Button returnexhaust;
        private System.Windows.Forms.Button exhaustreset;
    }
}