using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace AutoGarage
{
    public partial class FuelSystemMaintenance : Form
    {
        public FuelSystemMaintenance()
        {
            InitializeComponent();
            fuelcombo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, fuelcombo.Width, fuelcombo.Height, 50, 50));
            fuelrichbox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, fuelrichbox.Width, fuelrichbox.Height, 50, 50));
        }

        private CLIPSNET.Environment melo = new CLIPSNET.Environment();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(

          int nLeftRect, //x-coordinate of upper left conner
          int nTopRect,//y-coordinate of upper left conner
          int nRightRect, //x-coordinate of lower right conner
          int nBottomRect,//y-coordinate of lower right conner
          int nWidthEllipse,//width of ellipse
          int nHeightEllipse//height of ellipse




   );
        private void PopulateComboBox()
        {
            List<string> fuel = new List<string> { " ", "How the Fuel System Works", "The air-intake system", "How to:Change the Fuel Filter", "Clogged or Failed IAC", "How to:Inspect and Replace the Air Filter", "How to:Inspect and Replace the PCV Valve" };
            fuelcombo.DataSource = fuel;
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

        
        private void FuelSystemMaintenance_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            F.Interval = 10;
            F.Tick += new EventHandler(fadeIn);
            F.Start();

            this.BackgroundImage = Properties.Resources.shell;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            mode = "\"w\"";
            access = "(open " + "AutoGarage.fueloutput.txt " + "f" + mode + " " + ")";
            PopulateComboBox();

            melo.LoadFromResource("AutoGarage", "AutoGarage.Fuel.clp");
        }

        private void secondfuelpanel_Click(object sender, EventArgs e)
        {
            Fa.Tick += new EventHandler(fadeOut);
            Fa.Start();
        }

        private void fuelcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            fuelmaintenancreset.Enabled = true;
            string z;
            if (fuelcombo.SelectedValue.ToString() != " ")
            {
                if (fuelcombo.SelectedValue.ToString() == "How the Fuel System Works")
                {
                    melo.Eval(access);
                    z = "(FuelSystemWorking)";
                    melo.Eval(z);
                    melo.Eval("(close f");
                    StreamReader sr = new StreamReader(resourceName);
                    fuelrichbox.Text = sr.ReadToEnd();

                }



                if (fuelcombo.SelectedValue.ToString() == "The air-intake system")
                {
                    melo.Eval(access);
                    z = "(Airintake)";
                    melo.Eval(z);
                    melo.Eval("(close f");
                    StreamReader sr = new StreamReader(resourceName);
                    fuelrichbox.Text = sr.ReadToEnd();
                }



                if (fuelcombo.SelectedValue.ToString() == "How to:Change the Fuel Filter")
                {
                    melo.Eval(access);
                    z = "(ChangeFilter)";
                    melo.Eval(z);
                    melo.Eval("(close f");
                    StreamReader sr = new StreamReader(resourceName);
                    fuelrichbox.Text = sr.ReadToEnd();
                }

                if (fuelcombo.SelectedValue.ToString() == "Clogged or Failed IAC")
                {
                    melo.Eval(access);
                    z = "(FailedIAC)";
                    melo.Eval(z);
                    melo.Eval("(close f");
                    StreamReader sr = new StreamReader(resourceName);
                    fuelrichbox.Text = sr.ReadToEnd();
                }


                if (fuelcombo.SelectedValue.ToString() == "How to:Inspect and Replace the Air Filter")
                {
                    melo.Eval(access);
                    z = "(AirFilter)";
                    melo.Eval(z);
                    melo.Eval("(close f");
                    StreamReader sr = new StreamReader(resourceName);
                    fuelrichbox.Text = sr.ReadToEnd();
                }

                if (fuelcombo.SelectedValue.ToString() == "How to:Inspect and Replace the PCV Valve")
                {
                    melo.Eval(access);
                    z = "(PCV-valve)";
                    melo.Eval(z);
                    melo.Eval("(close f");
                    StreamReader sr = new StreamReader(resourceName);
                    fuelrichbox.Text = sr.ReadToEnd();
                }

            }

            fuelcombo.Enabled = false;
        }

        private void fuelmaintenancreset_Click(object sender, EventArgs e)
        {
            fuelmaintenancreset.Enabled = false;
            fuelmaintenancreset.Focus();
            fuelrichbox.Clear();
            PopulateComboBox();
            fuelcombo.Enabled = true;

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
                        if (f.GetType() == typeof(FuelSystemMaintenance))
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