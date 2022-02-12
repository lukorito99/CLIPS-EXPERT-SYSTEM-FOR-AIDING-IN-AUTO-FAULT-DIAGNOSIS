using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace AutoGarage
{
    public partial class DriveTrain : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(

             int nLeftRect, //x-coordinate of upper left conner
            int nTopRect,//y-coordinate of upper left conner
            int nRightRect, //x-coordinate of lower right conner
            int nBottomRect,//y-coordinate of lower right conner
            int nWidthEllipse,//width of ellipse
            int nHeightEllipse//height of ellipse



      );
        public DriveTrain()
        {
            InitializeComponent();

            drivetraincombobox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, drivetraincombobox.Width, drivetraincombobox.Height, 50, 50));
            drivetrainrichTextBox1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, drivetrainrichTextBox1.Width, drivetrainrichTextBox1.Height, 40, 40));
        }

        private CLIPSNET.Environment melo = new CLIPSNET.Environment();
       

        private void PopulateComboBox()
        {
            List<string> transmission = new List<string> {" ", "How the Drivetrain Works", "Common drivetrain problems", "Leaking;One of drivetrain problems", "Symptoms of Bad Transmission Fluid", "How to:Check and Fill an Automatic Transmission", "How to Check and Fill a Manual Transmission", "How to:Check and Maintain CV Joints and U-Joints" };
            drivetraincombobox.DataSource = transmission;
        }
        Timer Dt = new Timer();
        Timer Dta = new Timer();
        private string access;
        private string mode;
        private string resourceName = "AutoGarage.drivetrainoutput.txt";


        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                Dt.Stop();
            }

            else
            {
                Opacity += 0.01;
            }
        }

        void fadeOut(object sender, EventArgs e)
        {
            Dta.Interval = 10;
            if (Opacity == 0)
            {
                Dta.Stop();
                Close();
            }

            else
            {
                Opacity -= 0.01;
            }
        }
        private void DriveTrain_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            Dt.Interval = 10;
            Dt.Tick += new EventHandler(fadeIn);
            Dt.Start();

            
            this.BackgroundImage = Properties.Resources.bmwdrivetrain;
            this.BackgroundImageLayout = ImageLayout.Stretch;


            mode = "\"w\"";
            access = "(open " + "AutoGarage.drivetrainoutput.txt " + "dt" + mode + " " + ")";
            PopulateComboBox();
            melo.LoadFromResource("AutoGarage", "AutoGarage.drivetrain.clp");
        }

        private void drivetraincombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (drivetraincombobox.SelectedValue.ToString() != " ")
            {
                button1.Enabled = true;
                if (drivetraincombobox.SelectedValue.ToString() == "How the Drivetrain Works")
                {
                    melo.Eval(access);
                    string a = "(DrivetrainWorking)";
                    melo.Eval(a);
                    melo.Eval("(close dt)");
                    StreamReader sr = new StreamReader(resourceName);
                    drivetrainrichTextBox1.Text = sr.ReadToEnd();
                }

                if (drivetraincombobox.SelectedValue.ToString() == "Common drivetrain problems")
                {
                    melo.Eval(access);
                    string b = "(Problems)";
                    melo.Eval(b);
                    melo.Eval("(close dt)");
                    StreamReader sr = new StreamReader(resourceName);
                    drivetrainrichTextBox1.Text = sr.ReadToEnd();
                }

                if (drivetraincombobox.SelectedValue.ToString() == "Leaking;One of drivetrain problems")
                {
                    melo.Eval(access);
                    string c = "(Leaking)";
                    melo.Eval(c);
                    melo.Eval("(close dt)");
                    StreamReader sr = new StreamReader(resourceName);
                    drivetrainrichTextBox1.Text = sr.ReadToEnd();

                }

                if (drivetraincombobox.SelectedValue.ToString() == "How to:Check and Fill an Automatic Transmission")
                {
                    melo.Eval(access);
                    string d = "(AutoTrans)";
                    melo.Eval(d);
                    melo.Eval("(close dt)");
                    StreamReader sr = new StreamReader(resourceName);
                    drivetrainrichTextBox1.Text = sr.ReadToEnd();
                }

                if (drivetraincombobox.SelectedValue.ToString() == "How to Check and Fill a Manual Transmission")
                {
                    melo.Eval(access);
                    string f = "(ManualTrans)";
                    melo.Eval(f);
                    melo.Eval("(close dt)");
                    StreamReader sr = new StreamReader(resourceName);
                    drivetrainrichTextBox1.Text = sr.ReadToEnd();
                }

                if (drivetraincombobox.SelectedValue.ToString() == "How to:Check and Maintain CV Joints and U-Joints")
                {
                    melo.Eval(access);
                    string g = "(CV-and-U-joints)";
                    melo.Eval(g);
                    melo.Eval("(close dt)");
                    StreamReader sr = new StreamReader(resourceName);
                    drivetrainrichTextBox1.Text = sr.ReadToEnd();
                }

                if(drivetraincombobox.SelectedValue.ToString() == "Symptoms of Bad Transmission Fluid")
                {
                    melo.Eval(access);
                    string h = "(BadTransmissionFluid)";
                    melo.Eval(h);
                    melo.Eval("(close dt)");
                    StreamReader sr = new StreamReader(resourceName);
                    drivetrainrichTextBox1.Text = sr.ReadToEnd();
                }
            }

            drivetraincombobox.Enabled = false;
        }

        private void drivetrainlabel_Click(object sender, EventArgs e)
        {

        }

        private void drivetrainbutton_Click(object sender, EventArgs e)
        {
            Dta.Tick += new EventHandler(fadeOut);
            Dta.Start();
        }

        private void drivetrainrichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            drivetrainrichTextBox1.Clear();
            PopulateComboBox();
            drivetraincombobox.Enabled = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Enabled == false)
            {
                button1.Enabled = true;
            }

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(Transmision))
                {
                    f.Activate();
                    return;
                }
            }
            
            Transmision t = new Transmision();
            t.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Escape)
            {
                if (Opacity == 1)
                {
                    Dta.Tick += new EventHandler(fadeOut);
                    Dta.Start();
                    return true;

                }
                else
                {
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.GetType() == typeof(DriveTrain))
                        {
                            f.Activate();
                        }
                    }
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
