using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace AutoGarage
{
    public partial class SecondFuelSystemDiagnosis : Form
    {
        public SecondFuelSystemDiagnosis()
        {
            InitializeComponent();
            acccombo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, acccombo.Width, acccombo.Height, 40, 40));
            revcombo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, revcombo.Width, revcombo.Height, 40, 40));
            enginestartcombo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, enginestartcombo.Width, enginestartcombo.Height, 40, 40));
            engineundercombo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, engineundercombo.Width, engineundercombo.Height, 40, 40));
            engineonidlecombo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, engineonidlecombo.Width,engineonidlecombo.Height, 40, 40));
            engineidlecombo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, engineidlecombo.Width, engineidlecombo.Height, 40, 40));
            performancecombo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, performancecombo.Width, performancecombo.Height, 40, 40));

            enginecombo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, enginecombo.Width, enginecombo.Height, 40, 40));
            checkcomboBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, checkcomboBox.Width, checkcomboBox.Height, 40, 40));
            vehiclecombo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, vehiclecombo.Width, vehiclecombo.Height, 40, 40));

            secondfueldiag.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, secondfueldiag.Width, secondfueldiag.Height, 50, 50));
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
        private void checkenginelightlabel_Click(object sender, EventArgs e)
        {

        }

        private void PopulateComboBox()
        {
            List<string> check = new List<string> { " ", "ON", "OFF" };
            checkcomboBox.DataSource = check;
            List<string> enstart = new List<string> { " ", "difficult", "easy" };
            enginestartcombo.DataSource = enstart;
            List<string> performance = new List<string> { " ", "sluggish", "optimum" };
            performancecombo.DataSource = performance;
            List<string> idle = new List<string> { " ", "poor", "good" };
            engineidlecombo.DataSource = idle;
            List<string> rev = new List<string> { " ", "YES", "NO" };
            revcombo.DataSource = rev;
            List<string> speed = new List<string> { "", "rough", "okay" };
            vehiclecombo.DataSource = speed;
            List<string> en = new List<string> { " ", "runs", "stalls" };
            enginecombo.DataSource = en;
            List<string> acc = new List<string> { " ", "hesitant", "smooth", "jerking" };
            acccombo.DataSource = acc;
            List<string> under = new List<string> { " ", "hesitant", "drags","operates-as-expected" };
            engineundercombo.DataSource = under;
            List<string> onidle = new List<string> { " ", "restricted", "excessive", "normal" };
            engineonidlecombo.DataSource = onidle;
        }

        Timer Sf = new Timer();
        Timer Sfa = new Timer();
        private string access;
        private string mode;
        private string resourceName = "AutoGarage.fueloutput.txt";
        
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                Sf.Stop();
            }

            else
            {
                Opacity += 0.01;
            }
        }
        void fadeOut(object sender, EventArgs e)
        {
            Sfa.Interval = 10;
            if (Opacity == 0)
            {
                Sfa.Stop();
                Close();
            }

            else
            {
                Opacity -= 0.01;
            }
        }
        private void SecondFuelSystemDiagnosis_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            Sf.Interval = 10;
            Sf.Tick += new EventHandler(fadeIn);
            Sf.Start();


            this.BackgroundImage = Properties.Resources.filling_machine;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            mode = "\"w\"";
            access = "(open " + "AutoGarage.fueloutput.txt " + "f" + mode + " " + ")";

            PopulateComboBox();

            melo.LoadFromResource("AutoGarage", "AutoGarage.Fuel.clp");

        }

        private void engineidlecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkcomboBox.Enabled = false;
            performancecombo.Enabled = false;
            enginestartcombo.Enabled = false;

          

            enginecombo.Enabled = false;
            acccombo.Enabled = false;
            engineonidlecombo.Enabled = false;
            engineundercombo.Enabled = false;

            string z;
            if(engineidlecombo.SelectedValue.ToString()!=" ")
            {
                engineidlecombo.Enabled = false;
                z = "(Injector (engine-idle " + engineidlecombo.SelectedValue.ToString() + "))";
                melo.AssertString(z);
            }
        }

        private void revcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string z;
            if (revcombo.SelectedValue.ToString() != " ")
            {
                revcombo.Enabled = false;
                z = "(Injector (rev-fluctuation " + revcombo.SelectedValue.ToString() + "))";
                melo.AssertString(z);
            }
        }

        private void enginestartcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string z;
            if (enginestartcombo.SelectedValue.ToString() != " ")
            {
                enginestartcombo.Enabled = false;
                z = "(Poorfuel(engine-starting " + enginestartcombo.SelectedValue.ToString() + "))";
                melo.AssertString(z);
            }
        }

        private void performancecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string z;
            if (performancecombo.SelectedValue.ToString() != " ")
            {
                performancecombo.Enabled = false;
                z = "(Poorfuel(engine-performance " + performancecombo.SelectedValue.ToString() + "))";
                melo.AssertString(z);
            }
        }

        private void vehiclecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string z;
            if (vehiclecombo.SelectedValue.ToString() != " ")
            {
                vehiclecombo.Enabled = false;
                z = "(Injector (performance-in-speed " + vehiclecombo.SelectedValue.ToString() + "))";
                melo.AssertString(z);
            }
        }

        private void checkcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            enginecombo.Enabled = false;



            vehiclecombo.Enabled = false;
            revcombo.Enabled = false;
            acccombo.Enabled = false;
            engineonidlecombo.Enabled = false;
            engineundercombo.Enabled = false;

            string z;
            if (checkcomboBox.SelectedValue.ToString() != " ")
            {
                checkcomboBox.Enabled = false;
                z = "(Poorfuel(check-engine-light " + checkcomboBox.SelectedValue.ToString() + "))";
                melo.AssertString(z);
            }
        }

        private void enginecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkcomboBox.Enabled = false;
            performancecombo.Enabled = false;
            enginestartcombo.Enabled = false;

            engineidlecombo.Enabled = false;
            revcombo.Enabled = false;
            vehiclecombo.Enabled = false;

            

            string z;
            if (enginecombo.SelectedValue.ToString() != " ")
            {
                enginecombo.Enabled = false;
                z = "(MAF (engine-after-start " + enginecombo.SelectedValue.ToString() + "))";
                melo.AssertString(z);
            }
        }

        private void acccombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string z;
            if (acccombo.SelectedValue.ToString() != " ")
            {
                acccombo.Enabled = false;
                z = "(MAF (acceleration " + acccombo.SelectedValue.ToString() + "))";
                melo.AssertString(z);
            }
        }

        private void engineundercombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string z;
            if (engineundercombo.SelectedValue.ToString() != " ")
            {
                engineundercombo.Enabled = false;
                z = "(MAF (engine-under-load " + engineundercombo.SelectedValue.ToString() + "))";
                melo.AssertString(z);
            }
        }

        private void engineonidlecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string z;
            if (engineonidlecombo.SelectedValue.ToString() != " ")
            {
                engineonidlecombo.Enabled = false;
                z = "(MAF (engine-on-idle " + engineonidlecombo.SelectedValue.ToString() + "))";
                melo.AssertString(z);
            }
        }

      

         


  
          
        private void DirtyMAF_Click(object sender, EventArgs e)
        {
            secondreset.Enabled = true;
            melo.Eval(access);
            melo.Run();
            melo.Eval("(close f)");
           
            StreamReader sr = new StreamReader(resourceName);
            secondfueldiag.Text = sr.ReadToEnd();
            
            
            if (secondfueldiag.TextLength == 0)
            {
                secondfueldiag.Font = new System.Drawing.Font("SimSun", 24.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                var x = "You have NOT selected any symptoms or Symptoms chosen do not point to an underlying  problem with the Ignition System." + "If selection has been done;Please seek the services of a professional for further diagnosis.";



                secondfueldiag.Text = x;

            }

            else
            {
                secondfueldiag.Font = new System.Drawing.Font("Segoe UI", 18.00F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));



            }
            melo.Eval("(retract *)");

            DirtyMAF.Enabled = false;
        }

        private void secondpanel_Click(object sender, EventArgs e)
        {
            Sfa.Tick += new EventHandler(fadeOut);
            Sfa.Start();
        }

        private void secondreset_Click(object sender, EventArgs e)
        {
            secondreset.Enabled = false;
            secondfueldiag.Clear();

            
            DirtyMAF.Enabled = true;

            PopulateComboBox();
            checkcomboBox.Enabled = true;
            performancecombo.Enabled = true;
            enginestartcombo.Enabled = true;

            engineidlecombo.Enabled = true;
            revcombo.Enabled = true;
            vehiclecombo.Enabled = true;

            enginecombo.Enabled = true;
            acccombo.Enabled = true;
            engineonidlecombo.Enabled = true;
            engineundercombo.Enabled = true;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Escape)
            {
                if (Opacity == 1)
                {
                    Sfa.Tick += new EventHandler(fadeOut);
                    Sfa.Start();
                    return true;

                }
                else
                {
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.GetType() == typeof(SecondFuelSystemDiagnosis))
                        {
                            f.Activate();
                        }
                    }
                    return true;
                }
            }

            if (keyData == Keys.Enter)
            {
                secondreset.Enabled = true;
                melo.Eval(access);
                melo.Run();
                melo.Eval("(close f)");
                StreamReader sr = new StreamReader(resourceName);
                secondfueldiag.Text = sr.ReadToEnd();

                if (secondfueldiag.TextLength == 0)
                {
                    secondfueldiag.Font = new System.Drawing.Font("SimSun", 24.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    var x = "You have NOT selected any symptoms or Symptoms chosen do not point to an underlying  problem with the Ignition System." + "If selection has been done;Please seek the services of a professional for further diagnosis.";



                    secondfueldiag.Text = x;

                }

                else
                {
                    PopulateComboBox();
                    secondfueldiag.Font = new System.Drawing.Font("Segoe UI", 18.00F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));



                }
                melo.Eval("(retract *)");

                DirtyMAF.Enabled = false;

                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
