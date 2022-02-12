
namespace AutoGarage
{
    partial class VehicleFuels
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
            this.fluiddiagnosislabel = new System.Windows.Forms.Label();
            this.fuelrich = new System.Windows.Forms.RichTextBox();
            this.fuelreturn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.fuelview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fluiddiagnosislabel
            // 
            this.fluiddiagnosislabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.fluiddiagnosislabel.AutoSize = true;
            this.fluiddiagnosislabel.BackColor = System.Drawing.Color.Transparent;
            this.fluiddiagnosislabel.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fluiddiagnosislabel.ForeColor = System.Drawing.Color.Chocolate;
            this.fluiddiagnosislabel.Location = new System.Drawing.Point(28, 29);
            this.fluiddiagnosislabel.Name = "fluiddiagnosislabel";
            this.fluiddiagnosislabel.Size = new System.Drawing.Size(616, 85);
            this.fluiddiagnosislabel.TabIndex = 16;
            this.fluiddiagnosislabel.Text = "Identifying Vehicle Fuels";
            this.fluiddiagnosislabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fuelrich
            // 
            this.fuelrich.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fuelrich.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelrich.ForeColor = System.Drawing.Color.Green;
            this.fuelrich.Location = new System.Drawing.Point(763, 61);
            this.fuelrich.Name = "fuelrich";
            this.fuelrich.ReadOnly = true;
            this.fuelrich.Size = new System.Drawing.Size(575, 415);
            this.fuelrich.TabIndex = 37;
            this.fuelrich.Text = "";
            // 
            // fuelreturn
            // 
            this.fuelreturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.fuelreturn.AutoSize = true;
            this.fuelreturn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fuelreturn.BackColor = System.Drawing.Color.Transparent;
            this.fuelreturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fuelreturn.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelreturn.ForeColor = System.Drawing.Color.Chocolate;
            this.fuelreturn.Location = new System.Drawing.Point(763, 506);
            this.fuelreturn.Name = "fuelreturn";
            this.fuelreturn.Size = new System.Drawing.Size(111, 47);
            this.fuelreturn.TabIndex = 39;
            this.fuelreturn.Text = "Return";
            this.fuelreturn.UseVisualStyleBackColor = false;
            this.fuelreturn.Click += new System.EventHandler(this.fuelreturn_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(29, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(615, 33);
            this.label4.TabIndex = 41;
            this.label4.Text = "--------------------------------------------------";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fuelview
            // 
            this.fuelview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.fuelview.AutoSize = true;
            this.fuelview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fuelview.BackColor = System.Drawing.Color.Transparent;
            this.fuelview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fuelview.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelview.ForeColor = System.Drawing.Color.Chocolate;
            this.fuelview.Location = new System.Drawing.Point(896, 506);
            this.fuelview.Name = "fuelview";
            this.fuelview.Size = new System.Drawing.Size(89, 47);
            this.fuelview.TabIndex = 40;
            this.fuelview.Text = "View";
            this.fuelview.UseVisualStyleBackColor = false;
            this.fuelview.Click += new System.EventHandler(this.fuelview_Click);
            // 
            // VehicleFuels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fuelview);
            this.Controls.Add(this.fuelreturn);
            this.Controls.Add(this.fuelrich);
            this.Controls.Add(this.fluiddiagnosislabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VehicleFuels";
            this.Text = "VehicleFuels";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VehicleFuels_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fluiddiagnosislabel;
        private System.Windows.Forms.RichTextBox fuelrich;
        private System.Windows.Forms.Button fuelreturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button fuelview;
    }
}