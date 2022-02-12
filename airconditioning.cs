using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace AutoGarage
{
    public partial class airconditioning : Form
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
        public airconditioning()
        {
            InitializeComponent();
            airconditioningdiagnosiscombobox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, airconditioningdiagnosiscombobox.Width, airconditioningdiagnosiscombobox.Height, 50, 50));
            acrichbox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, acrichbox.Width, acrichbox.Height, 60, 60));
        }

        private CLIPSNET.Environment melo = new CLIPSNET.Environment();

        private void PopulateComboBox()
        {
            List<string> ACOptions = new List<string> {"  " ,"How the A/C System Works",
            "Common A/C System Problems",
            "Checking For Leaks in Your A/C System",
            "Adding Refrigerant",
            "Fixing Smelly A/C System" };


        airconditioningdiagnosiscombobox.DataSource = ACOptions;
        }


        Timer Ac = new Timer();
        Timer Ab = new Timer();
        private string access;
        private string mode;
        private string resourceName = "AutoGarage.acoutput.txt";
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                Ac.Stop();
            }

            else
            {
                Opacity += 0.01;
            }
        }

        private void airconditioning_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            Ac.Interval = 10;
            Ac.Tick += new EventHandler(fadeIn);
            Ac.Start();
            
            this.BackgroundImage = Properties.Resources.carac3;
            this.BackgroundImageLayout = ImageLayout.Stretch;

           

            PopulateComboBox();

            mode = "\"w\"";
            access = "(open " + "AutoGarage.acoutput.txt " + "ac" + mode + " " + ")";

            melo.LoadFromResource("AutoGarage", "AutoGarage.AirConditioning.clp");

           
        }

        private void airconditioningdiagnosiscombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            acreset.Enabled = true;
            if((string)airconditioningdiagnosiscombobox.SelectedItem == "How the A/C System Works")
            {

                melo.Eval(access);
                string v = "(AC-Working)";
                melo.Eval(v);
                melo.Eval("(close ac)");
                StreamReader sr = new StreamReader(resourceName);
                acrichbox.Text = sr.ReadToEnd();

            }

            if((string)airconditioningdiagnosiscombobox.SelectedItem == "Common A/C System Problems")
            {
                melo.Eval(access);
                string z = "(AC_Problems)";
                melo.Eval(z);
                melo.Eval("(close ac)");
                StreamReader sr = new StreamReader(resourceName);
                acrichbox.Text = sr.ReadToEnd();

            }

            if((string)airconditioningdiagnosiscombobox.SelectedItem == "Checking For Leaks in Your A/C System")
            {
                melo.Eval(access);
                string w = "(LeakCheck)";
                melo.Eval(w);
                melo.Eval("(close ac)");
                StreamReader sr = new StreamReader(resourceName);
                acrichbox.Text = sr.ReadToEnd();
            }

            if((string)airconditioningdiagnosiscombobox.SelectedItem == "Adding Refrigerant")
            {
                melo.Eval(access);
                string q = "(RefrigerantAdd)";
                melo.Eval(q);
                melo.Eval("(close ac)");
                StreamReader sr = new StreamReader(resourceName);
                acrichbox.Text = sr.ReadToEnd();

            }

            if((string)airconditioningdiagnosiscombobox.SelectedItem == "Fixing Smelly A/C System")
            {
                melo.Eval(access);
                string u = "(SmellyAC)";
                melo.Eval(u);
                
                melo.Eval("(close ac)");
                StreamReader sr = new StreamReader(resourceName);
                acrichbox.Text = sr.ReadToEnd();

            }

            airconditioningdiagnosiscombobox.Enabled = false;

        }

        

        private void airdiagnosislabel_Click(object sender, EventArgs e)
        {

        }

        private void returnselectbutton_Click(object sender, EventArgs e)
        {



            
            Ab.Tick += new EventHandler(fadeOut);
            Ab.Start();  
        }

        private void acrichbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void acreset_Click(object sender, EventArgs e)
        {
            acrichbox.Clear();
            acreset.Enabled = false;
            acreset.Update();
            PopulateComboBox();
            airconditioningdiagnosiscombobox.Enabled = true;
        }

        

        void fadeOut(object sender, EventArgs e)
        {
            Ab.Interval = 5;

            if (Opacity <= 0)
            {
                
                Ab.Stop();
                Close();

            }

            else
            {
                Opacity -= 0.01;
                
            }

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Escape)
            {
                if (Opacity == 1)
                {
                    Ab.Tick += new EventHandler(fadeOut);
                    Ab.Start();
                    return true;

                }
                else
                {
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.GetType() == typeof(airconditioning))
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
