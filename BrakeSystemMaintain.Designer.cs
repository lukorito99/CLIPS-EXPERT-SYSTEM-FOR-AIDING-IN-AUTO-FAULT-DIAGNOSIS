
namespace AutoGarage
{
    partial class BrakeSystemMaintain
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
            this.brakesystem = new System.Windows.Forms.ComboBox();
            this.brakemain = new System.Windows.Forms.RichTextBox();
            this.brakereset = new System.Windows.Forms.Button();
            this.brakereturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // airdiagnosislabel
            // 
            this.airdiagnosislabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.airdiagnosislabel.AutoSize = true;
            this.airdiagnosislabel.BackColor = System.Drawing.Color.Transparent;
            this.airdiagnosislabel.Font = new System.Drawing.Font("Segoe Print", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airdiagnosislabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.airdiagnosislabel.Location = new System.Drawing.Point(19, 9);
            this.airdiagnosislabel.Name = "airdiagnosislabel";
            this.airdiagnosislabel.Size = new System.Drawing.Size(638, 76);
            this.airdiagnosislabel.TabIndex = 17;
            this.airdiagnosislabel.Text = " Brake System Maintenance";
            this.airdiagnosislabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brakesystem
            // 
            this.brakesystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brakesystem.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brakesystem.ForeColor = System.Drawing.Color.Blue;
            this.brakesystem.FormattingEnabled = true;
            this.brakesystem.Location = new System.Drawing.Point(26, 91);
            this.brakesystem.Name = "brakesystem";
            this.brakesystem.Size = new System.Drawing.Size(625, 55);
            this.brakesystem.TabIndex = 18;
            this.brakesystem.SelectedIndexChanged += new System.EventHandler(this.brakesystem_SelectedIndexChanged);
            // 
            // brakemain
            // 
            this.brakemain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.brakemain.BackColor = System.Drawing.Color.White;
            this.brakemain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.brakemain.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brakemain.ForeColor = System.Drawing.Color.ForestGreen;
            this.brakemain.Location = new System.Drawing.Point(26, 163);
            this.brakemain.Name = "brakemain";
            this.brakemain.ReadOnly = true;
            this.brakemain.Size = new System.Drawing.Size(625, 491);
            this.brakemain.TabIndex = 20;
            this.brakemain.Text = "";
            // 
            // brakereset
            // 
            this.brakereset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.brakereset.AutoSize = true;
            this.brakereset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.brakereset.BackColor = System.Drawing.Color.Transparent;
            this.brakereset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brakereset.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brakereset.ForeColor = System.Drawing.Color.Blue;
            this.brakereset.Location = new System.Drawing.Point(27, 676);
            this.brakereset.Name = "brakereset";
            this.brakereset.Size = new System.Drawing.Size(97, 47);
            this.brakereset.TabIndex = 21;
            this.brakereset.Text = "Reset";
            this.brakereset.UseVisualStyleBackColor = false;
            this.brakereset.Click += new System.EventHandler(this.brakereset_Click);
            // 
            // brakereturn
            // 
            this.brakereturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.brakereturn.AutoSize = true;
            this.brakereturn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.brakereturn.BackColor = System.Drawing.Color.Transparent;
            this.brakereturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brakereturn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brakereturn.ForeColor = System.Drawing.Color.Blue;
            this.brakereturn.Location = new System.Drawing.Point(140, 676);
            this.brakereturn.Name = "brakereturn";
            this.brakereturn.Size = new System.Drawing.Size(113, 47);
            this.brakereturn.TabIndex = 22;
            this.brakereturn.Text = "Return";
            this.brakereturn.UseVisualStyleBackColor = false;
            this.brakereturn.Click += new System.EventHandler(this.brakereturn_Click_1);
            // 
            // BrakeSystemMaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 747);
            this.Controls.Add(this.brakereturn);
            this.Controls.Add(this.brakereset);
            this.Controls.Add(this.brakemain);
            this.Controls.Add(this.brakesystem);
            this.Controls.Add(this.airdiagnosislabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BrakeSystemMaintain";
            this.Text = "BrakeSystemMaintain";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BrakeSystemMaintain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
       
        #endregion

        private System.Windows.Forms.Label airdiagnosislabel;
        private System.Windows.Forms.ComboBox brakesystem;
        private System.Windows.Forms.RichTextBox brakemain;
        private System.Windows.Forms.Button brakereset;
        private System.Windows.Forms.Button brakereturn;
    }
}