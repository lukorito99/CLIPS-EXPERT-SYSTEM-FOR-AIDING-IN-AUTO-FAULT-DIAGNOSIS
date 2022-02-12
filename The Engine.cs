using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace AutoGarage
{
    public partial class The_Engine : Form
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
        public The_Engine()
        {
            InitializeComponent();
            checklightcomboBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, checklightcomboBox.Width, checklightcomboBox.Height, 30, 30));
            checkappearancecomboBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, checkappearancecomboBox.Width,checkappearancecomboBox.Height, 30, 30));
            flashingcomboBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, flashingcomboBox.Width, flashingcomboBox.Height, 30, 30));
            valvecomboBox1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, valvecomboBox1.Width, valvecomboBox1.Height, 30, 30));
            gasketcomboBox1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, gasketcomboBox1.Width, gasketcomboBox1.Height, 30, 30));
            soundcomboBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, soundcomboBox.Width, soundcomboBox.Height, 30, 30));
            beltcomboBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, beltcomboBox.Width, beltcomboBox.Height, 30, 30));


           
            








          
        }

        private CLIPSNET.Environment melo = new CLIPSNET.Environment();

        Timer te = new Timer();
        Timer tf = new Timer();
        private string access;
        private string mode;
        private string resourceName = "AutoGarage.engineoutput.txt";
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                te.Stop();
            }

            else
            {
                Opacity += 0.01;
            }
        }
        void fadeOut(object sender, EventArgs e)
        {
            tf.Interval = 10;
            if (Opacity == 0)
            {
                tf.Stop();
                Close();
            }

            else
            {
                Opacity -= 0.01;
            }
        }
       

            

        private void valvegasket_Click(object sender, EventArgs e)
        {
          
            reset.Enabled = true;

            melo.Eval(access);
            melo.Run();
            melo.Eval("(close ef)");
            StreamReader sr = new StreamReader(resourceName);
            enginerichTextBox1.Text = sr.ReadToEnd();

            if (enginerichTextBox1.TextLength != 0)
            {
                enginerichTextBox1.Font = new System.Drawing.Font("Segoe UI", 18.00F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                


            }

            else
            {
                enginerichTextBox1.Font = new System.Drawing.Font("SimSun", 24.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                var x = "You have NOT selected any symptoms or Symptoms chosen do not point to an underlying  problem with the Engine." + "If selection has been done;Please seek the services of a professional for further diagnosis.";



                enginerichTextBox1.Text = x;

            }
            melo.Eval("(retract *)");
            valvegasket.Enabled = false;
        }

       
           

        private void maintenance_Click(object sender, EventArgs e)
        {
            if (reset.Enabled == false)
            {
                reset.Enabled = true;
            }

            foreach ( Form f in Application.OpenForms)
            {
                if(f.GetType() == typeof(Engine_Maintenance))
                {
                    f.Activate();
                    return;
                }
            }
            Engine_Maintenance em = new Engine_Maintenance();
            em.Show();
            
        }

        private void checklightcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (checklightcomboBox.SelectedValue.ToString() != " ")
            {
                string c = "(Check (check-engine-light " + checklightcomboBox.SelectedValue.ToString() + "))";
                melo.AssertString(c);
            }

            checklightcomboBox.Enabled = false;
            valvecomboBox1.Enabled = false;
            gasketcomboBox1.Enabled = false;
            beltcomboBox.Enabled = false;
            soundcomboBox.Enabled = false;
          
        }

        private void PopulateComboBox()
        {
            List<string> Powerloss = new List<string> { " ", "bend", "straight" };
            valvecomboBox1.DataSource = Powerloss;
            List<string> Gasket = new List<string> { " ", "blown", "okay" };
            gasketcomboBox1.DataSource = Gasket;


            List<string> checklight = new List<string> { " ", "ON", "OFF" };
            checklightcomboBox.DataSource = checklight;
            List<string> checkappearance = new List<string> { " ", "amber", "yellow", "orange","no-color" };
            checkappearancecomboBox.DataSource = checkappearance;

            List<string> flash = new List<string> { " ", "YES", "NO" };
            flashingcomboBox.DataSource = flash;

            List<string> timingbelt = new List<string> { "  ", "broken", "worn", "okay", "cracked", "striped" };
            beltcomboBox.DataSource = timingbelt;

            List<string> sound = new List<string> { " ", "screeching-noise", "slapping-noise" };
            soundcomboBox.DataSource = sound;
        }

        private void The_Engine_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            te.Interval = 10;
            te.Tick += new EventHandler(fadeIn);
            te.Start();
            
            
            this.BackgroundImage = Properties.Resources.enginex;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            mode = "\"w\"";
            access = "(open " + "AutoGarage.engineoutput.txt " + "ef" + mode + " " + ")";


            PopulateComboBox();    

            melo.LoadFromResource("AutoGarage", "AutoGarage.engine.clp");

            checkappearancecomboBox.Enabled = false;
            soundcomboBox.Enabled = false;
            beltcomboBox.Enabled = false;
            gasketcomboBox1.Enabled = false;
            valvecomboBox1.Enabled = false;
            flashingcomboBox.Enabled = false;


        }

        private void checkappearancecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (checkappearancecomboBox.SelectedValue.ToString() != " ")
            {
                string d = "(Check (appearance " + checkappearancecomboBox.SelectedValue.ToString() + "))";
                melo.AssertString(d);
            }

            checkappearancecomboBox.Enabled = false;
            valvecomboBox1.Enabled = false;
            gasketcomboBox1.Enabled = false;
            beltcomboBox.Enabled = false;
            soundcomboBox.Enabled = false;
        }

        private void flashingcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (flashingcomboBox.SelectedValue.ToString() != " ")
            {

                string y = "(Check (flashing " + flashingcomboBox.SelectedValue.ToString() + "))";
                melo.AssertString(y);
            }

            flashingcomboBox.Enabled = false;
            valvecomboBox1.Enabled = false;
            gasketcomboBox1.Enabled = false;
            beltcomboBox.Enabled = false;
            soundcomboBox.Enabled = false;
        }

        private void valvecomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (valvecomboBox1.SelectedValue.ToString() != " ")
            {
                string n = "(Power_loss (valve-status " + valvecomboBox1.SelectedValue.ToString() + "))";
                melo.AssertString(n);
            }

            valvecomboBox1.Enabled = false;
            checkappearancecomboBox.Enabled = false;
            soundcomboBox.Enabled = false;
            beltcomboBox.Enabled = false;
            flashingcomboBox.Enabled = false;
            checklightcomboBox.Enabled = false;

        }

        private void gasketcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
            if (gasketcomboBox1.SelectedValue.ToString() != " ")
            {

                string b = "(Power_loss (gasket-status " + gasketcomboBox1.SelectedValue.ToString() + "))";
                melo.AssertString(b);
            }

            gasketcomboBox1.Enabled = false;
            checkappearancecomboBox.Enabled = false;
            soundcomboBox.Enabled = false;
            beltcomboBox.Enabled = false;
            flashingcomboBox.Enabled = false;
            checklightcomboBox.Enabled = false;
        }

        private void soundcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (soundcomboBox.SelectedValue.ToString() != " ")
            {
               

                string u;

                if (soundcomboBox.SelectedValue.ToString() == "slapping-noise")
                {
                    u = "(Timing_Belts (sound " + soundcomboBox.SelectedValue.ToString() + "))";
                    melo.AssertString(u);
                }

                if (soundcomboBox.SelectedValue.ToString() == "screeching-noise")
                {
                    u = "(Drive_Belts (sound " + soundcomboBox.SelectedValue.ToString() + "))";
                    melo.AssertString(u);
                }

            }

            soundcomboBox.Enabled = false;
            flashingcomboBox.Enabled = false;
            checklightcomboBox.Enabled = false;
            checkappearancecomboBox.Enabled = false;
            valvecomboBox1.Enabled = false;
            gasketcomboBox1.Enabled = false;

        }

        private void beltcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (beltcomboBox.SelectedValue.ToString() != " ")
            {
                

                string z;
                if (beltcomboBox.SelectedValue.ToString() == "broken" || beltcomboBox.SelectedValue.ToString() == "cracked" || beltcomboBox.SelectedValue.ToString() == "worn")
                {
                    z = "(Timing_Belts (belt-status " + beltcomboBox.SelectedValue.ToString() + "))";
                    melo.AssertString(z);
                }

                if (beltcomboBox.SelectedValue.ToString() == "striped" || beltcomboBox.SelectedValue.ToString() == "cracked")
                {
                    z = "(Drive_Belts (belt-status " + beltcomboBox.SelectedValue.ToString() + "))";
                    melo.AssertString(z);
                }
            }

            beltcomboBox.Enabled = false;
            flashingcomboBox.Enabled = false;
            checklightcomboBox.Enabled = false;
            checkappearancecomboBox.Enabled = false;
            valvecomboBox1.Enabled = false;
            gasketcomboBox1.Enabled = false;
        }

        private void panel_Click(object sender, EventArgs e)
        {
            tf.Tick += new EventHandler(fadeOut);
            tf.Start();
        }

        private void Gasketstatuslabel_Click(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            reset.Enabled = false;
            enginerichTextBox1.Clear();
            PopulateComboBox();
            checklightcomboBox.Enabled = true;
            checkappearancecomboBox.Enabled = true;
            beltcomboBox.Enabled = true;
            flashingcomboBox.Enabled = true;
            valvecomboBox1.Enabled = true;
            gasketcomboBox1.Enabled = true;
            soundcomboBox.Enabled = true;
            
            
            valvegasket.Enabled = true;
           
        }

        private void enginerichTextBox1_TextChanged(object sender, EventArgs e)
        {

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
                    tf.Tick += new EventHandler(fadeOut);
                    tf.Start();
                    return true;

                }
                else
                {
                   
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.GetType() == typeof(The_Engine))
                        {
                            f.Activate();
                        }
                    }
                    return true;

                }
            }

            if (keyData == Keys.Enter)
            {
                reset.Enabled = true;

                melo.Eval(access);
                melo.Run();
                melo.Eval("(close ef)");
                StreamReader sr = new StreamReader(resourceName);
                enginerichTextBox1.Text = sr.ReadToEnd();

                if (enginerichTextBox1.TextLength != 0)
                {
                    enginerichTextBox1.Font = new System.Drawing.Font("Segoe UI", 18.00F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));



                }

                else
                {
                    enginerichTextBox1.Font = new System.Drawing.Font("SimSun", 24.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    var x = "You have NOT selected any symptoms or Symptoms chosen do not point to an underlying  problem with the Engine." + "If selection has been done;Please seek the services of a professional for further diagnosis.";



                    enginerichTextBox1.Text = x;

                }
                melo.Eval("(retract *)");
                valvegasket.Enabled = false;

                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
