namespace AutoGarage
{
    partial class Car_Fluids
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
            this.oilslabel = new System.Windows.Forms.Label();
            this.oilsappcomboBox1 = new System.Windows.Forms.ComboBox();
            this.appearancediagnosislabel = new System.Windows.Forms.Label();
            this.fluidslabel = new System.Windows.Forms.Label();
            this.otherlabel = new System.Windows.Forms.Label();
            this.othercombo = new System.Windows.Forms.ComboBox();
            this.fluidssmellcomboBox = new System.Windows.Forms.ComboBox();
            this.smelllabel = new System.Windows.Forms.Label();
            this.vehiclefluidsrichTextBox = new System.Windows.Forms.RichTextBox();
            this.fluidsbutton = new System.Windows.Forms.Button();
            this.view2 = new System.Windows.Forms.Button();
            this.carfluidreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fluiddiagnosislabel
            // 
            this.fluiddiagnosislabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.fluiddiagnosislabel.AutoSize = true;
            this.fluiddiagnosislabel.BackColor = System.Drawing.Color.Transparent;
            this.fluiddiagnosislabel.Font = new System.Drawing.Font("Segoe Print", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fluiddiagnosislabel.ForeColor = System.Drawing.Color.Blue;
            this.fluiddiagnosislabel.Location = new System.Drawing.Point(518, -2);
            this.fluiddiagnosislabel.Name = "fluiddiagnosislabel";
            this.fluiddiagnosislabel.Size = new System.Drawing.Size(384, 76);
            this.fluiddiagnosislabel.TabIndex = 15;
            this.fluiddiagnosislabel.Text = "Fluids  Diagnosis";
            this.fluiddiagnosislabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oilslabel
            // 
            this.oilslabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.oilslabel.AutoSize = true;
            this.oilslabel.BackColor = System.Drawing.Color.Transparent;
            this.oilslabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oilslabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.oilslabel.Location = new System.Drawing.Point(69, 86);
            this.oilslabel.Name = "oilslabel";
            this.oilslabel.Size = new System.Drawing.Size(345, 45);
            this.oilslabel.TabIndex = 16;
            this.oilslabel.Text = "Vehicle Oils Diagnosis";
            this.oilslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oilsappcomboBox1
            // 
            this.oilsappcomboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.oilsappcomboBox1.BackColor = System.Drawing.Color.White;
            this.oilsappcomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.oilsappcomboBox1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oilsappcomboBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.oilsappcomboBox1.FormattingEnabled = true;
            this.oilsappcomboBox1.Location = new System.Drawing.Point(69, 209);
            this.oilsappcomboBox1.Name = "oilsappcomboBox1";
            this.oilsappcomboBox1.Size = new System.Drawing.Size(374, 32);
            this.oilsappcomboBox1.TabIndex = 18;
            this.oilsappcomboBox1.SelectedIndexChanged += new System.EventHandler(this.oilsappcomboBox1_SelectedIndexChanged);
            // 
            // appearancediagnosislabel
            // 
            this.appearancediagnosislabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.appearancediagnosislabel.AutoSize = true;
            this.appearancediagnosislabel.BackColor = System.Drawing.Color.Transparent;
            this.appearancediagnosislabel.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appearancediagnosislabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.appearancediagnosislabel.Location = new System.Drawing.Point(69, 141);
            this.appearancediagnosislabel.Name = "appearancediagnosislabel";
            this.appearancediagnosislabel.Size = new System.Drawing.Size(269, 47);
            this.appearancediagnosislabel.TabIndex = 17;
            this.appearancediagnosislabel.Text = "Fluid Appearance ";
            this.appearancediagnosislabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fluidslabel
            // 
            this.fluidslabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.fluidslabel.AutoSize = true;
            this.fluidslabel.BackColor = System.Drawing.Color.Transparent;
            this.fluidslabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fluidslabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.fluidslabel.Location = new System.Drawing.Point(65, 321);
            this.fluidslabel.Name = "fluidslabel";
            this.fluidslabel.Size = new System.Drawing.Size(377, 45);
            this.fluidslabel.TabIndex = 23;
            this.fluidslabel.Text = "Vehicle Fluids Diagnosis";
            this.fluidslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // otherlabel
            // 
            this.otherlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.otherlabel.AutoSize = true;
            this.otherlabel.BackColor = System.Drawing.Color.Transparent;
            this.otherlabel.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.otherlabel.Location = new System.Drawing.Point(63, 376);
            this.otherlabel.Name = "otherlabel";
            this.otherlabel.Size = new System.Drawing.Size(269, 47);
            this.otherlabel.TabIndex = 24;
            this.otherlabel.Text = "Fluid Appearance ";
            this.otherlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.otherlabel.Click += new System.EventHandler(this.otherlabel_Click);
            // 
            // othercombo
            // 
            this.othercombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.othercombo.BackColor = System.Drawing.Color.White;
            this.othercombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.othercombo.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othercombo.ForeColor = System.Drawing.Color.DarkCyan;
            this.othercombo.FormattingEnabled = true;
            this.othercombo.Location = new System.Drawing.Point(69, 444);
            this.othercombo.Name = "othercombo";
            this.othercombo.Size = new System.Drawing.Size(377, 32);
            this.othercombo.TabIndex = 25;
            this.othercombo.SelectedIndexChanged += new System.EventHandler(this.othercombo_SelectedIndexChanged);
            // 
            // fluidssmellcomboBox
            // 
            this.fluidssmellcomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.fluidssmellcomboBox.BackColor = System.Drawing.Color.White;
            this.fluidssmellcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fluidssmellcomboBox.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fluidssmellcomboBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.fluidssmellcomboBox.FormattingEnabled = true;
            this.fluidssmellcomboBox.Location = new System.Drawing.Point(69, 557);
            this.fluidssmellcomboBox.Name = "fluidssmellcomboBox";
            this.fluidssmellcomboBox.Size = new System.Drawing.Size(377, 32);
            this.fluidssmellcomboBox.TabIndex = 27;
            this.fluidssmellcomboBox.SelectedIndexChanged += new System.EventHandler(this.fluidssmellcomboBox_SelectedIndexChanged);
            // 
            // smelllabel
            // 
            this.smelllabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.smelllabel.AutoSize = true;
            this.smelllabel.BackColor = System.Drawing.Color.Transparent;
            this.smelllabel.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smelllabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.smelllabel.Location = new System.Drawing.Point(62, 485);
            this.smelllabel.Name = "smelllabel";
            this.smelllabel.Size = new System.Drawing.Size(182, 47);
            this.smelllabel.TabIndex = 26;
            this.smelllabel.Text = "Fluid Smell ";
            this.smelllabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vehiclefluidsrichTextBox
            // 
            this.vehiclefluidsrichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.vehiclefluidsrichTextBox.BackColor = System.Drawing.Color.White;
            this.vehiclefluidsrichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vehiclefluidsrichTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiclefluidsrichTextBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.vehiclefluidsrichTextBox.Location = new System.Drawing.Point(935, 139);
            this.vehiclefluidsrichTextBox.Name = "vehiclefluidsrichTextBox";
            this.vehiclefluidsrichTextBox.ReadOnly = true;
            this.vehiclefluidsrichTextBox.Size = new System.Drawing.Size(395, 514);
            this.vehiclefluidsrichTextBox.TabIndex = 28;
            this.vehiclefluidsrichTextBox.Text = "";
            // 
            // fluidsbutton
            // 
            this.fluidsbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.fluidsbutton.AutoSize = true;
            this.fluidsbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fluidsbutton.BackColor = System.Drawing.Color.Transparent;
            this.fluidsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fluidsbutton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fluidsbutton.ForeColor = System.Drawing.Color.OrangeRed;
            this.fluidsbutton.Location = new System.Drawing.Point(684, 680);
            this.fluidsbutton.Name = "fluidsbutton";
            this.fluidsbutton.Size = new System.Drawing.Size(316, 42);
            this.fluidsbutton.TabIndex = 40;
            this.fluidsbutton.Text = "Return To Selection Panel";
            this.fluidsbutton.UseVisualStyleBackColor = false;
            this.fluidsbutton.Click += new System.EventHandler(this.fluidsbutton_Click);
            // 
            // view2
            // 
            this.view2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.view2.AutoSize = true;
            this.view2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.view2.BackColor = System.Drawing.Color.Transparent;
            this.view2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.view2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view2.ForeColor = System.Drawing.Color.OrangeRed;
            this.view2.Location = new System.Drawing.Point(471, 680);
            this.view2.Name = "view2";
            this.view2.Size = new System.Drawing.Size(199, 42);
            this.view2.TabIndex = 42;
            this.view2.Text = "View Diagnosis";
            this.view2.UseVisualStyleBackColor = false;
            this.view2.Click += new System.EventHandler(this.view2_Click);
            // 
            // carfluidreset
            // 
            this.carfluidreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.carfluidreset.AutoSize = true;
            this.carfluidreset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.carfluidreset.BackColor = System.Drawing.Color.Transparent;
            this.carfluidreset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.carfluidreset.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carfluidreset.ForeColor = System.Drawing.Color.OrangeRed;
            this.carfluidreset.Location = new System.Drawing.Point(371, 680);
            this.carfluidreset.Name = "carfluidreset";
            this.carfluidreset.Size = new System.Drawing.Size(86, 42);
            this.carfluidreset.TabIndex = 44;
            this.carfluidreset.Text = "Reset";
            this.carfluidreset.UseVisualStyleBackColor = false;
            this.carfluidreset.Click += new System.EventHandler(this.carfluidreset_Click);
            // 
            // Car_Fluids
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.carfluidreset);
            this.Controls.Add(this.view2);
            this.Controls.Add(this.fluidsbutton);
            this.Controls.Add(this.vehiclefluidsrichTextBox);
            this.Controls.Add(this.fluidssmellcomboBox);
            this.Controls.Add(this.smelllabel);
            this.Controls.Add(this.othercombo);
            this.Controls.Add(this.otherlabel);
            this.Controls.Add(this.fluidslabel);
            this.Controls.Add(this.oilsappcomboBox1);
            this.Controls.Add(this.appearancediagnosislabel);
            this.Controls.Add(this.oilslabel);
            this.Controls.Add(this.fluiddiagnosislabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(850, 726);
            this.Name = "Car_Fluids";
            this.Text = "Car Fluids";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Car_Fluids_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        private System.Windows.Forms.Label fluiddiagnosislabel;
        private System.Windows.Forms.Label oilslabel;
        private System.Windows.Forms.ComboBox oilsappcomboBox1;
        private System.Windows.Forms.Label appearancediagnosislabel;
        private System.Windows.Forms.Label fluidslabel;
        private System.Windows.Forms.Label otherlabel;
        private System.Windows.Forms.ComboBox othercombo;
        private System.Windows.Forms.ComboBox fluidssmellcomboBox;
        private System.Windows.Forms.Label smelllabel;
        private System.Windows.Forms.RichTextBox vehiclefluidsrichTextBox;
        private System.Windows.Forms.Button fluidsbutton;
        private System.Windows.Forms.Button view2;
        private System.Windows.Forms.Button carfluidreset;
    }
}