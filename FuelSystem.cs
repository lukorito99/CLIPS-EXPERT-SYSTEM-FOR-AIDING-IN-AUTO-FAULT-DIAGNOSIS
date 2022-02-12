using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace AutoGarage
{
    public partial class FuelSystem : Form
    {
        public FuelSystem()
        {
            InitializeComponent();
            acccomboBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, acccomboBox.Width, acccomboBox.Height, 40, 40));
            enginerescombo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, enginerescombo.Width, enginerescombo.Height, 40, 40));
            enginestartcombo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, enginestartcombo.Width, enginestartcombo.Height, 40, 40));
            enginestartstacombo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, enginestartstacombo.Width, enginestartstacombo.Height, 40, 40));
            Enginebehcombo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Enginebehcombo.Width, Enginebehcombo.Height, 40, 40));
            soundcomboBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, soundcomboBox.Width, soundcomboBox.Height, 40, 40));
            fuelconcombo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, fuelconcombo.Width, fuelconcombo.Height, 40, 40));

            Powercombo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0,  Powercombo.Width, Powercombo.Height, 40, 40));
            throttlecombo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0,throttlecombo.Width, throttlecombo.Height, 40, 40));
            startercombo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, startercombo.Width, startercombo.Height, 40, 40));

            
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(

          int nLeftRect, //x-coordinate of upper left conner
          int nTopRect,//y-coordinate of upper left conner
          int nRightRect, //x-coordinate of lower right conner
          int nBottomRect,//y-coordinate of lower right conner
          int nWidthEllipse,//width of ellipse
          int nHeightEllipse//height of ellipse




   );

        private CLIPSNET.Environment melo = new CLIPSNET.Environment();

        private void PopulateComboBox()
        {
            List<string> sound = new List<string> { " ", "loud-electrical-clicking", "whining-noise" };
            soundcomboBox.DataSource = sound;
            List<string> starter = new List<string> { " ", "normal", "poor" };
            startercombo.DataSource = starter;
            List<string> enginestart = new List<string> { " ", "hard", "easy" };
            enginestartcombo.DataSource = enginestart;
            List<string> acc = new List<string> { " ", " sluggish", "smooth" };
            acccomboBox.DataSource = acc;
            List<string> fuelcon = new List<string> { " ", "increased", "normal" };
            fuelconcombo.DataSource = fuelcon;
            List<string> power = new List<string> { " ", "sudden-decrease", "okay" };
            Powercombo.DataSource = power;
            List<string> res = new List<string> { " ", "adequate", "inadequate" };
            enginerescombo.DataSource = res;
            List<string> throttle = new List<string> { " ", "hesitant", "responsive" };
            throttlecombo.DataSource = throttle;
            List<string> enginest = new List<string> { " ", "hard", "easy" };
            enginestartstacombo.DataSource = enginest;
            List<string> behaviour = new List<string> { " ", "repeated-stalling", "struggle-to-maintain-idle","normal" };
            Enginebehcombo.DataSource = behaviour;

        }
        Timer F = new Timer();
        Timer Fa = new Timer();
        private string access;
        private string mode;
        private string resourceName = "AutoGarage.fueloutput.txt";

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                F.Stop();
            }

            else
            {
                Opacity += 0.01;
            }
        }

        void fadeOut(object sender, EventArgs e)
        {
            Fa.Interval = 10;
            if (Opacity == 0)
            {
                Fa.Stop();
                Close();
            }

            else
            {
                Opacity -= 0.01;
            }
        }

        private void FuelSystem_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            F.Interval = 10;
            F.Tick += new EventHandler(fadeIn);
            F.Start();

            this.BackgroundImage = Properties.Resources.fuel1;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            mode = "\"w\"";
            access = "(open " + "AutoGarage.fueloutput.txt " + "f" + mode + " " + ")";

            PopulateComboBox();
            
            melo.LoadFromResource("AutoGarage", "AutoGarage.Fuel.clp");

        }

        private void soundcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string z;
            throttlecombo.Enabled = false;
            Enginebehcombo.Enabled = false;
            enginestartstacombo.Enabled = false;
            enginerescombo.Enabled = false;

            if(soundcomboBox.SelectedValue.ToString()!= " ")
            {
                soundcomboBox.Enabled = false;
                z = "(fuel-pump(sound " + soundcomboBox.SelectedValue.ToString() + "))";
                melo.AssertString(z);
            }


        }

        private void startercombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string z;
            throttlecombo.Enabled = false;
            Enginebehcombo.Enabled = false;
            enginestartstacombo.Enabled = false;
            enginerescombo.Enabled = false;
            if (startercombo.SelectedValue.ToString() != " ")
            {
                startercombo.Enabled = false;
                z = "(fuel-pump(starter-motor-performance " + startercombo.SelectedValue.ToString() + "))";
                melo.AssertString(z);
            }
        }

        private void enginestartcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string z;
            throttlecombo.Enabled = false;
            Enginebehcombo.Enabled = false;
            enginestartstacombo.Enabled = false;
            enginerescombo.Enabled = false;
            if (enginestartcombo.SelectedValue.ToString() != " ")
            {
                enginestartcombo.Enabled = false;
                z = "(fuel-pump(engine-start-status " + enginestartcombo.SelectedValue.ToString() + "))";
                melo.AssertString(z);
            }
        }

        private void acccomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string z;
            throttlecombo.Enabled = false;
            Enginebehcombo.Enabled = false;
            enginestartstacombo.Enabled = false;
            enginerescombo.Enabled = false;
            if (acccomboBox.SelectedValue.ToString() != " ")
            {
                acccomboBox.Enabled = false;
                z = "(fuel-pump(acceleration " + acccomboBox.SelectedValue.ToString() + "))";
                melo.AssertString(z);
            }


        }

        private void fuelconcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string z;
            throttlecombo.Enabled = false;
            Enginebehcombo.Enabled = false;
            enginestartstacombo.Enabled = false;
            enginerescombo.Enabled = false;
            if (fuelconcombo.SelectedValue.ToString() != " ")
            {
                fuelconcombo.Enabled = false;
                z = "(fuel-pump(fuel-consumption " + fuelconcombo.SelectedValue.ToString() + "))";
                melo.AssertString(z);
            }
        }

        private void Powercombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string z;
            throttlecombo.Enabled = false;
            Enginebehcombo.Enabled = false;
            enginestartstacombo.Enabled = false;
            enginerescombo.Enabled = false;
            if (Powercombo.SelectedValue.ToString() != " ")
            {
                Powercombo.Enabled = false;
                z = "(fuel-pump(power-status-while-driving " + Powercombo.SelectedValue.ToString() + "))";
                melo.AssertString(z);
            }
        }

        private void viewfuelpump_Click(object sender, EventArgs e)
        {
            fuelreset.Enabled = true;
            
            melo.Eval(access);
            melo.Run();
            melo.Eval("(close f)");
            StreamReader sr = new StreamReader(resourceName);
            fuelA.Text = sr.ReadToEnd();

            if (fuelA.TextLength == 0)
            {
                fuelA.Font = new System.Drawing.Font("SimSun", 24.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                var x = "You have NOT selected any symptoms or Symptoms chosen do not point to an underlying  problem with the Ignition System." + "If selection has been done;Please seek the services of a professional for further diagnosis.";



                fuelA.Text = x;

            }

            else
            {
                fuelA.Font = new System.Drawing.Font("Segoe UI", 18.00F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));



            }
            melo.Eval("(retract *)");
            viewfuelpump.Enabled = false;
            
        }

        private void enginerescombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string z;
            soundcomboBox.Enabled = false;
            enginestartcombo.Enabled = false;
            fuelconcombo.Enabled = false;
            Powercombo.Enabled = false;
            startercombo.Enabled = false;

            acccomboBox.Enabled = false;
            if (enginerescombo.SelectedValue.ToString()!= " ")
            {
                enginerescombo.Enabled = false;
                z = "(fuel-filter(engine-responsiveness " + enginerescombo.SelectedValue.ToString() + "))";
                melo.AssertString(z);
            }
        }

        private void throttlecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            soundcomboBox.Enabled = false;
            enginestartcombo.Enabled = false;
            fuelconcombo.Enabled = false;
            Powercombo.Enabled = false;
            startercombo.Enabled = false;
            
            acccomboBox.Enabled = false;

            string z;
            if (throttlecombo.SelectedValue.ToString() != " ")
            {
                throttlecombo.Enabled = false;
                z = "(fuel-filter(throttle-application " + throttlecombo.SelectedValue.ToString() + "))";
                melo.AssertString(z);
            }
        }

        private void enginestartstacombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string z;
            soundcomboBox.Enabled = false;
            enginestartcombo.Enabled = false;
            fuelconcombo.Enabled = false;
            Powercombo.Enabled = false;
            startercombo.Enabled = false;

            acccomboBox.Enabled = false;
            if (enginestartstacombo.SelectedValue.ToString() != " ")
            {
                enginestartstacombo.Enabled = false;
                z = "(fuel-filter(engine-start-status " + enginestartstacombo.SelectedValue.ToString() + "))";
                melo.AssertString(z);
            }
        }

        private void Enginebehcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string z;
            soundcomboBox.Enabled = false;
            enginestartcombo.Enabled = false;
            fuelconcombo.Enabled = false;
            Powercombo.Enabled = false;
            startercombo.Enabled = false;

            acccomboBox.Enabled = false;
            if (Enginebehcombo.SelectedValue.ToString() != " ")
            {
                Enginebehcombo.Enabled = false;
                z = "(fuel-filter(engine-behavior " + Enginebehcombo.SelectedValue.ToString() + "))";
                melo.AssertString(z);
            }
        }

          

        private void panel_Click(object sender, EventArgs e)
        {
            Fa.Tick += new EventHandler(fadeOut);
            Fa.Start();
        }

        private void second_Click(object sender, EventArgs e)
        {
            if (fuelreset.Enabled == false)
            {
                fuelreset.Enabled = true;
            }

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(SecondFuelSystemDiagnosis))
                {
                    f.Activate();
                    return;
                }
            }
            SecondFuelSystemDiagnosis s = new SecondFuelSystemDiagnosis();
            s.Show();
        }

        private void fuelmaintain_Click(object sender, EventArgs e)
        {
            if (fuelreset.Enabled == false)
            {
                fuelreset.Enabled = true;
            }

            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(FuelSystemMaintenance))
                {
                    f.Activate();
                    return;
                }
            }
            FuelSystemMaintenance fs = new FuelSystemMaintenance();
            fs.Show();
            
        }

        private void Acceleration_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void fuelreset_Click(object sender, EventArgs e)
        {
            fuelreset.Enabled = false;
           

            fuelA.Clear();

            PopulateComboBox();
            soundcomboBox.Enabled = true;
            enginestartcombo.Enabled = true;
            fuelconcombo.Enabled = true;
            Powercombo.Enabled = true;
            startercombo.Enabled = true;
            enginerescombo.Enabled = true;
            Enginebehcombo.Enabled = true;
            acccomboBox.Enabled = true;
            throttlecombo.Enabled = true;
            enginestartstacombo.Enabled = true;

            viewfuelpump.Enabled = true;
           



        }

        private void checkenginelightlabel_Click(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Escape)
            {
                if (Opacity == 1)
                {
                    Fa.Tick += new EventHandler(fadeOut);
                    Fa.Start();
                    return true;

                }
                else
                {
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.GetType() == typeof(FuelSystem))
                        {
                            f.Activate();
                        }
                    }
                    return true;
                }
            }

            if(keyData == Keys.Enter)
            {
                    fuelreset.Enabled = true;
                fuelreset.Enabled = true;

                melo.Eval(access);
                melo.Run();
                melo.Eval("(close f)");
                StreamReader sr = new StreamReader(resourceName);
                fuelA.Text = sr.ReadToEnd();

                if (fuelA.TextLength == 0)
                {
                    fuelA.Font = new System.Drawing.Font("SimSun", 24.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    var x = "You have NOT selected any symptoms or Symptoms chosen do not point to an underlying  problem with the Ignition System." + "If selection has been done;Please seek the services of a professional for further diagnosis.";



                    fuelA.Text = x;

                }

                else
                {
                    fuelA.Font = new System.Drawing.Font("Segoe UI", 18.00F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));



                }
                melo.Eval("(retract *)");
                viewfuelpump.Enabled = false;

                return true;
                
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
