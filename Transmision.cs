using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace AutoGarage
{
    public partial class Transmision : Form
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

        private CLIPSNET.Environment melo = new CLIPSNET.Environment();

        private void PopulateComboBox()
        {

            List<string> Transmission = new List<string> { " ", "screeching", "clanging", "grinding", "no-sound" };
            Transmissioncombo.DataSource = Transmission;
        }


        public Transmision()
        {
            InitializeComponent();
            Transmissioncombo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Transmissioncombo.Width, Transmissioncombo.Height, 40, 40));
            transmissioninfo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, transmissioninfo.Width, transmissioninfo.Height, 40, 40));
        }

        Timer T = new Timer();
        Timer Ta = new Timer();
        private string access;
        private string mode;
        private string resourceName = "AutoGarage.drivetrainoutput.txt";

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                T.Stop();
            }

            else
            {
                Opacity += 0.01;
            }
        }

        void fadeOut(object sender, EventArgs e)
        {
            Ta.Interval = 10;
            if (Opacity == 0)
            {
                Ta.Stop();
                Close();
            }

            else
            {
                Opacity -= 0.01;
            }
        }
        private void Transmision_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            T.Interval = 10;
            T.Tick += new EventHandler(fadeIn);
            T.Start();
            
            this.BackgroundImage = Properties.Resources.BenzCLSTransmission;
            this.BackgroundImageLayout = ImageLayout.Stretch;


            mode = "\"w\"";
            access = "(open " + "AutoGarage.drivetrainoutput.txt " + "dt" + mode + " " + ")";
            PopulateComboBox();
            melo.LoadFromResource("AutoGarage", "AutoGarage.drivetrain.clp");
        }

        private void Transmissioncombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if(Transmissioncombo.SelectedValue.ToString() != null)
            {
                string z = "(Transmission (sound  " + Transmissioncombo.SelectedValue.ToString() + ") )";
                melo.AssertString(z);
            }
            Transmissioncombo.Enabled = false;
        }

        private void transmissionreturn_Click(object sender, EventArgs e)
        {
            Ta.Tick += new EventHandler(fadeOut);
            Ta.Start();
        }

        private void transmissionreset_Click(object sender, EventArgs e)
        {
            transmissionreset.Enabled = false;
            transmissioninfo.Clear();

            PopulateComboBox();
            Transmissioncombo.Enabled = true;
           
            transmissiondiagnosis.Enabled = true;
        }

        private void transmissiondiagnosis_Click(object sender, EventArgs e)
        {
            transmissionreset.Enabled = true;
            transmissiondiagnosis.Enabled = false;
            melo.Eval(access);
           
            melo.Run();
            melo.Eval("(close dt)");
            StreamReader sr = new StreamReader(resourceName);
            transmissioninfo.Text = sr.ReadToEnd();

            if (transmissioninfo.TextLength!=0)
            {

                this.transmissioninfo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


            }

            else
            {
                transmissioninfo.Font = new System.Drawing.Font("SimSun", 24.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                var x = "You have NOT selected any symptoms or Symptoms chosen do not point to an underlying  problem with the  Transmission." + "If Selection has been done;Please seek the services of a professional for further diagnosis.";



                transmissioninfo.Text = x;

            }
            melo.Eval("(retract *)");
        }

        private void transmissioninfo_TextChanged(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Escape)
            {
                if (Opacity == 1)
                {
                    Ta.Tick += new EventHandler(fadeOut);
                    Ta.Start();
                    return true;

                }
                else
                {
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.GetType() == typeof(Transmision))
                        {
                            f.Activate();
                        }
                    }
                    return true;
                }
            }
            if(keyData == Keys.Enter)
            {
                transmissionreset.Enabled = true;
                transmissiondiagnosis.Enabled = false;
                melo.Eval(access);

                melo.Run();
                melo.Eval("(close dt)");
                StreamReader sr = new StreamReader(resourceName);
                transmissioninfo.Text = sr.ReadToEnd();

                if (transmissioninfo.TextLength != 0)
                {

                    this.transmissioninfo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                }

                else
                {
                    transmissioninfo.Font = new System.Drawing.Font("SimSun", 24.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    var x = "You have NOT selected any symptoms or Symptoms chosen do not point to an underlying  problem with the  Transmission." + "If Selection has been done;Please seek the services of a professional for further diagnosis.";



                    transmissioninfo.Text = x;

                }
                melo.Eval("(retract *)");

                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
