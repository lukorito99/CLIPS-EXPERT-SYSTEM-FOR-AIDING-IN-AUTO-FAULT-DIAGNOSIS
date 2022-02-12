using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace AutoGarage
{
    public partial class The_Ignition : Form
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

        Timer I = new Timer();
        Timer Ia = new Timer();
        private string access;
        private string mode;
        private string resourceName = "AutoGarage.ignitionoutput.txt";
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                I.Stop();
            }

            else
            {
                Opacity += 0.01;
            }
        }

        void fadeOut(object sender, EventArgs e)
        {
            Ia.Interval = 10;
            if (Opacity == 0)
            {
                Ia.Stop();
                Close();
            }

            else
            {
                Opacity -= 0.01;
            }
        }
        public The_Ignition()
        {
            InitializeComponent(); 
            accelerationcomboBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, accelerationcomboBox.Width, accelerationcomboBox.Height, 40, 40));
            fuelcomboBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, fuelcomboBox.Width, fuelcomboBox.Height, 40, 40));
            idlecomboBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, idlecomboBox.Width, idlecomboBox.Height, 40, 40));
            enginemisfirecombo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, enginemisfirecombo.Width, enginemisfirecombo.Height, 40, 40));

            ignitionrichTextBox1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, ignitionrichTextBox1.Width, ignitionrichTextBox1.Height, 40, 40));
        }

        private void stalllabel_Click(object sender, EventArgs e)
        {

        }

        private void ignitionsbutton_Click(object sender, EventArgs e)
        {
            Ia.Tick += new EventHandler(fadeOut);
            Ia.Start();
        }

        private CLIPSNET.Environment melo = new CLIPSNET.Environment();

        private void PopulateComboBox()
        {
            List<string> acc = new List<string> { " ", "sluggish", "irregular", "normal" };
            accelerationcomboBox.DataSource = acc;

            List<string> misfire = new List<string> { " ", "YES", "NO" };
            enginemisfirecombo.DataSource = misfire;

            List<string> idle = new List<string> { " ", "rough", "smooth" };
            idlecomboBox.DataSource = idle;

            List<string> fuel = new List<string> { " ", "increased", "optimum" };
            fuelcomboBox.DataSource = fuel;
        }
        private void The_Ignition_Load(object sender, EventArgs e)
        {

            Opacity = 0;
            I.Interval = 10;
            I.Tick += new EventHandler(fadeIn);
            I.Start();

            mode = "\"w\"";
            access = "(open " + "AutoGarage.ignitionoutput.txt " + "ig" + mode + " " + ")";
            this.BackgroundImage = Properties.Resources.ignition4;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            PopulateComboBox();

            melo.LoadFromResource("AutoGarage", "AutoGarage.ignition.clp");

        }

      

       
       
        

        private void accelerationcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            accelerationcomboBox.Enabled = false;
            if (accelerationcomboBox.SelectedValue.ToString() != " ")
            {

                string y = "(Plug(acceleration " + accelerationcomboBox.SelectedValue.ToString() + " ))";

                melo.AssertString(y);
            }
        }

        private void idlecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            idlecomboBox.Enabled = false;
            if (idlecomboBox.SelectedValue.ToString() != " ")
            {

                string z = "(Plug (idle " + idlecomboBox.SelectedValue.ToString() + "))";
                melo.AssertString(z);
            }
        }

        private void fuelcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fuelcomboBox.Enabled = false;
            if(fuelcomboBox.SelectedValue.ToString() != " ")
            {
                string t = "(Plug (fuel-consumption " + fuelcomboBox.SelectedValue.ToString() + "))";

                melo.AssertString(t);
            }
        }

        private void enginemisfirecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            enginemisfirecombo.Enabled = false;
            if(enginemisfirecombo.SelectedValue.ToString() != " ")
            {
                string r = "(Plug (engine-misfire " + enginemisfirecombo.SelectedValue.ToString() + "))";
                melo.AssertString(r);
            }
        }

        private void plug_Click(object sender, EventArgs e)
        {
            plug.Enabled = false;
            igreset.Enabled = true;
            melo.Eval(access);
            melo.Run();
            melo.Eval("(close ig)");
            StreamReader sr = new StreamReader(resourceName);
            ignitionrichTextBox1.Text = sr.ReadToEnd();

            if (ignitionrichTextBox1.TextLength == 0)
            {
                ignitionrichTextBox1.Font = new System.Drawing.Font("SimSun", 24.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                var x = "You have NOT selected any symptoms or Symptoms chosen do not point to an underlying  problem with the Ignition System." + "If selection has been done;Please seek the services of a professional for further diagnosis.";



                ignitionrichTextBox1.Text = x;

            }

            else
            {
                ignitionrichTextBox1.Font = new System.Drawing.Font("Segoe UI", 18.00F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                


            }
            melo.Eval("(retract *)");
        }

        private void igmbutton_Click(object sender, EventArgs e)
        {
            if (igreset.Enabled == false)
            {
                igreset.Enabled = true;
            }

            foreach ( Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(Ignition_Maintenance))
                {
                    f.Activate();
                    return;
                }
            }
            Ignition_Maintenance i = new Ignition_Maintenance();
            i.Show();
        }

        private void igreset_Click(object sender, EventArgs e)
        {
            plug.Enabled = true;
            ignitionrichTextBox1.Clear();
            igreset.Enabled = false;

            PopulateComboBox();
            fuelcomboBox.Enabled = true;
            accelerationcomboBox.Enabled = true;
            enginemisfirecombo.Enabled = true;
            idlecomboBox.Enabled = true;

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Escape)
            {
                if (Opacity == 1)
                {
                    Ia.Tick += new EventHandler(fadeOut);
                    Ia.Start();
                    return true;

                }
                else
                {
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.GetType() == typeof(The_Ignition))
                        {
                            f.Activate();
                        }
                    }
                    return true;
                }
            }

            if (keyData == Keys.Enter)
            {
                plug.Enabled = false;
                igreset.Enabled = true;
                melo.Eval(access);
                melo.Run();
                melo.Eval("(close ig)");
                StreamReader sr = new StreamReader(resourceName);
                ignitionrichTextBox1.Text = sr.ReadToEnd();

                if (ignitionrichTextBox1.TextLength == 0)
                {
                    ignitionrichTextBox1.Font = new System.Drawing.Font("SimSun", 24.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    var x = "You have NOT selected any symptoms or Symptoms chosen do not point to an underlying  problem with the Ignition System." + "If selection has been done;Please seek the services of a professional for further diagnosis.";



                    ignitionrichTextBox1.Text = x;

                }

                else
                {
                    ignitionrichTextBox1.Font = new System.Drawing.Font("Segoe UI", 18.00F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    PopulateComboBox();


                }
                melo.Eval("(retract *)");

                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
