using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace AutoGarage
{
    public partial class Engine_Maintenance : Form
    {
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
        Timer E = new Timer();
        Timer Ea = new Timer();
        private string access;
        private string mode;
        private string resourceName = "AutoGarage.engineoutput.txt";
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                E.Stop();
            }

            else
            {
                Opacity += 0.01;
            }
        }

        void fadeOut(object sender, EventArgs e)
        {
            Ea.Interval = 10;
            if (Opacity == 0)
            {
                Ea.Stop();
                Close();
            }

            else
            {
                Opacity -= 0.01;
            }
        }
        public Engine_Maintenance()
        {
            InitializeComponent();
            maintaincombobox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, maintaincombobox.Width, maintaincombobox.Height, 50, 50));
            maintain.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, maintain.Width, maintain.Height, 50, 50));

        }

        private void PopulateComboBox()
        {
            List<string> Maintain = new List<string> { " ", "How to check and add engine oil", "Oil Types And The Best Type For Your Vehicle", "Correct reading of oil gauge", "How To Change Oil", "How to: Inspect and Change Accessory Belts" };
            maintaincombobox.DataSource = Maintain;
        }

        private void Engine_Maintenance_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            E.Interval = 10;
            E.Tick += new EventHandler(fadeIn);
            E.Start();


            this.BackgroundImage = Properties.Resources.engine1;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            mode = "\"w\"";
            access = "(open " + "AutoGarage.engineoutput.txt " + "ef" + mode + " " + ")";
            PopulateComboBox();
            melo.LoadFromResource("AutoGarage", "AutoGarage.engine.clp");
        }

        private void returnbutton_Click(object sender, EventArgs e)
        {
            
            Ea.Tick += new EventHandler(fadeOut);
            Ea.Start();

            
            
        }

        private void maintaincombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;

            string z;
            if(maintaincombobox.SelectedValue.ToString() != " ")
            {
               

                if(maintaincombobox.SelectedValue.ToString() == "How to check and add engine oil")
                {
                    melo.Eval(access);
                    z = "(EngineOil_Procedure)";
                    melo.Eval(z);
                    melo.Eval("(close ef)");

                    StreamReader sr = new StreamReader(resourceName);
                    maintain.Text = sr.ReadToEnd();

                }

                if (maintaincombobox.SelectedValue.ToString() == "Oil Types And The Best Type For Your Vehicle")
                {
                    melo.Eval(access);
                    z = "(Oil_Types)";
                    melo.Eval(z);
                    melo.Eval("(close ef)");


                    StreamReader sr = new StreamReader(resourceName);
                    maintain.Text = sr.ReadToEnd();

                }

                if (maintaincombobox.SelectedValue.ToString() == "How To Change Oil")
                {
                    melo.Eval(access);
                    z = "(ChangingOil)";
                    melo.Eval(z);
                    melo.Eval("(close ef)");


                    StreamReader sr = new StreamReader(resourceName);
                    maintain.Text = sr.ReadToEnd();

                }

                if (maintaincombobox.SelectedValue.ToString() == "Correct reading of oil gauge")
                {
                    melo.Eval(access);
                    z = "(Oilgauge_reading)";
                    melo.Eval(z);
                    melo.Eval("(close ef)");


                    StreamReader sr = new StreamReader(resourceName);
                    maintain.Text = sr.ReadToEnd();
                }

                if (maintaincombobox.SelectedValue.ToString() == "How to: Inspect and Change Accessory Belts")
                {
                    melo.Eval(access);
                    z = "(Inspect)";
                    melo.Eval(z);
                    melo.Eval("(close ef)");


                    StreamReader sr = new StreamReader(resourceName);
                    maintain.Text = sr.ReadToEnd();

                }
            }
            maintaincombobox.Enabled = false;
        }

        private void airdiagnosislabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;


            maintain.Clear();
            PopulateComboBox();
            maintaincombobox.Enabled = true;
        }

        private void maintain_TextChanged(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Escape)
            {
                if (Opacity == 1)
                {
                    Ea.Tick += new EventHandler(fadeOut);
                    Ea.Start();
                    return true;

                }
                else
                {
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.GetType() == typeof(Engine_Maintenance))
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
