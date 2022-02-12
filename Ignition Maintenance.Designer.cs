namespace AutoGarage
{
    partial class Ignition_Maintenance
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
            this.igmaintaincombobox = new System.Windows.Forms.ComboBox();
            this.maintainig = new System.Windows.Forms.RichTextBox();
            this.igmreturnsbutton = new System.Windows.Forms.Button();
            this.ignitionreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ignitionlabel
            // 
            this.ignitionlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ignitionlabel.AutoSize = true;
            this.ignitionlabel.BackColor = System.Drawing.Color.Transparent;
            this.ignitionlabel.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ignitionlabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.ignitionlabel.Location = new System.Drawing.Point(325, 25);
            this.ignitionlabel.Name = "ignitionlabel";
            this.ignitionlabel.Size = new System.Drawing.Size(570, 65);
            this.ignitionlabel.TabIndex = 16;
            this.ignitionlabel.Text = "Ignition System Maintenance";
            this.ignitionlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // igmaintaincombobox
            // 
            this.igmaintaincombobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.igmaintaincombobox.BackColor = System.Drawing.Color.White;
            this.igmaintaincombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.igmaintaincombobox.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igmaintaincombobox.ForeColor = System.Drawing.Color.Teal;
            this.igmaintaincombobox.FormattingEnabled = true;
            this.igmaintaincombobox.Location = new System.Drawing.Point(338, 106);
            this.igmaintaincombobox.Name = "igmaintaincombobox";
            this.igmaintaincombobox.Size = new System.Drawing.Size(558, 51);
            this.igmaintaincombobox.TabIndex = 17;
            this.igmaintaincombobox.SelectedIndexChanged += new System.EventHandler(this.maintaincombobox_SelectedIndexChanged);
            // 
            // maintainig
            // 
            this.maintainig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.maintainig.BackColor = System.Drawing.Color.White;
            this.maintainig.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintainig.ForeColor = System.Drawing.Color.ForestGreen;
            this.maintainig.Location = new System.Drawing.Point(338, 175);
            this.maintainig.Name = "maintainig";
            this.maintainig.ReadOnly = true;
            this.maintainig.Size = new System.Drawing.Size(558, 464);
            this.maintainig.TabIndex = 19;
            this.maintainig.Text = "";
            // 
            // igmreturnsbutton
            // 
            this.igmreturnsbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.igmreturnsbutton.AutoSize = true;
            this.igmreturnsbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.igmreturnsbutton.BackColor = System.Drawing.Color.Transparent;
            this.igmreturnsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.igmreturnsbutton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igmreturnsbutton.ForeColor = System.Drawing.Color.Blue;
            this.igmreturnsbutton.Location = new System.Drawing.Point(783, 666);
            this.igmreturnsbutton.Name = "igmreturnsbutton";
            this.igmreturnsbutton.Size = new System.Drawing.Size(113, 47);
            this.igmreturnsbutton.TabIndex = 66;
            this.igmreturnsbutton.Text = "Return";
            this.igmreturnsbutton.UseVisualStyleBackColor = false;
            this.igmreturnsbutton.Click += new System.EventHandler(this.igmreturnsbutton_Click);
            // 
            // ignitionreset
            // 
            this.ignitionreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ignitionreset.AutoSize = true;
            this.ignitionreset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ignitionreset.BackColor = System.Drawing.Color.Transparent;
            this.ignitionreset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ignitionreset.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ignitionreset.ForeColor = System.Drawing.Color.Blue;
            this.ignitionreset.Location = new System.Drawing.Point(338, 666);
            this.ignitionreset.Name = "ignitionreset";
            this.ignitionreset.Size = new System.Drawing.Size(97, 47);
            this.ignitionreset.TabIndex = 67;
            this.ignitionreset.Text = "Reset";
            this.ignitionreset.UseVisualStyleBackColor = false;
            this.ignitionreset.Click += new System.EventHandler(this.ignitionreset_Click);
            // 
            // Ignition_Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 730);
            this.Controls.Add(this.ignitionreset);
            this.Controls.Add(this.igmreturnsbutton);
            this.Controls.Add(this.maintainig);
            this.Controls.Add(this.igmaintaincombobox);
            this.Controls.Add(this.ignitionlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ignition_Maintenance";
            this.Text = "Ignition_Maintenance";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ignition_Maintenance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Label ignitionlabel;
        private System.Windows.Forms.ComboBox igmaintaincombobox;
        private System.Windows.Forms.RichTextBox maintainig;
        private System.Windows.Forms.Button igmreturnsbutton;
        private System.Windows.Forms.Button ignitionreset;
    }
}