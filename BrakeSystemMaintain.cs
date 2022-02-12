using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace AutoGarage
{
    public partial class BrakeSystemMaintain : Form
    {
        public BrakeSystemMaintain()
        {
            InitializeComponent();
            brakesystem.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, brakesystem.Width, brakesystem.Height, 50, 50));
            brakemain.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, brakemain.Width, brakemain.Height, 50, 50));

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
            List<string> brakemaintain = new List<string> { " ", "How the Brake System Works", "Types of Brakes and Brake Components", "How to:Check and Fill Brake Fluid", "How to: Change Brake Pads and Rotors", "How to: Bleed the Brake System" };
            brakesystem.DataSource = brakemaintain;
        }
        Timer B = new Timer();
        Timer Ba = new Timer();
        private string access;
        private string mode;
        private string resourceName = "AutoGarage.boutput.txt";

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                B.Stop();
            }

            else
            {
                Opacity += 0.01;
            }
        }

        void fadeOut(object sender, EventArgs e)
        {
            Ba.Interval = 10;

            if (Opacity == 0)
            {
                Ba.Stop();
                Close();
            }

            else
            {
                Opacity -= 0.01;
            }
        }

        private void BrakeSystemMaintain_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            B.Interval = 10;
            B.Tick += new EventHandler(fadeIn);
            B.Start();
            brakesystem.Enabled = false;

            this.BackgroundImage = Properties.Resources.Anti_Lock_Brakes;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            

            PopulateComboBox();
            mode = "\"w\"";
            access = "(open " + "AutoGarage.boutput.txt " + "b" + mode + " " + ")";

            melo.LoadFromResource("AutoGarage", "AutoGarage.Brake.clp");
        }

        private void brakesystem_SelectedIndexChanged(object sender, EventArgs e)
        {

            brakereset.Enabled = true;
            brakesystem.Enabled = false;

            if (brakesystem.SelectedValue.ToString() != " ")
            {
                string z;



                if (brakesystem.SelectedValue.ToString() == "How the Brake System Works")
                {
                    melo.Eval(access);
                    z = "(BrakeWorking)";
                    melo.Eval(z);
                    melo.Eval("(close b)");
                    StreamReader sr = new StreamReader(resourceName);
                    brakemain.Text = sr.ReadToEnd();

                }

                if (brakesystem.SelectedValue.ToString() == "Types of Brakes and Brake Components")
                {
                    melo.Eval(access);
                    z = "(BrakeTypes)";
                    melo.Eval(z);
                    melo.Eval("(close b)");
                    StreamReader sr = new StreamReader(resourceName);
                    brakemain.Text = sr.ReadToEnd();



                }

                if (brakesystem.SelectedValue.ToString() == "How to: Inspect the Brakes")
                {
                    melo.Eval(access);
                    z = "(BrakeInspect)";
                    melo.Eval(z);
                    melo.Eval("(close b)");
                    StreamReader sr = new StreamReader(resourceName);
                    brakemain.Text = sr.ReadToEnd();


                }

                if (brakesystem.SelectedValue.ToString() == "How to: Change Brake Pads and Rotors")
                {
                    melo.Eval(access);
                    z = "(BrakePad)";
                    melo.Eval(z);
                    melo.Eval("(close b)");
                    StreamReader sr = new StreamReader(resourceName);
                    brakemain.Text = sr.ReadToEnd();

                }

                if (brakesystem.SelectedValue.ToString() == "How to:Check and Fill Brake Fluid")
                {
                    melo.Eval(access);
                    z = "(BrakeFluid)";
                    melo.Eval(z);
                    melo.Eval("(close b)");
                    StreamReader sr = new StreamReader(resourceName);
                    brakemain.Text = sr.ReadToEnd();

                }

                if (brakesystem.SelectedValue.ToString() == "How to: Bleed the Brake System")
                {
                    melo.Eval(access);
                    z = "(BrakeBleed)";
                    melo.Eval(z);
                    melo.Eval("(close b)");
                    StreamReader sr = new StreamReader(resourceName);
                    brakemain.Text = sr.ReadToEnd();

                }


                
            }
        }

       

      

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Escape)
            {
                if (Opacity == 1)
                {
                    Ba.Tick += new EventHandler(fadeOut);
                    Ba.Start();
                    return true;

                }
                else
                {
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.GetType() == typeof(BrakeSystemMaintain))
                        {
                            f.Activate();
                        }
                    }
                    return true;
                }
            }

           
                brakemain.Enabled = false;
               

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void brakereset_Click(object sender, EventArgs e)
        {
            brakereset.Enabled = false;
            PopulateComboBox();
            brakemain.Clear();

            brakesystem.Enabled = true;
        }

        private void brakereturn_Click_1(object sender, EventArgs e)
        {
            Ba.Tick += new EventHandler(fadeOut);
            Ba.Start();
        }
    }
}
