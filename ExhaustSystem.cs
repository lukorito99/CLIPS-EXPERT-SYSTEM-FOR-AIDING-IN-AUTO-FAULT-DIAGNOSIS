using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace AutoGarage
{
    public partial class ExhaustSystem : Form
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

        Timer Eh = new Timer();
        Timer Ea = new Timer();
        private string access;
        private string mode;
        private string resourceName = "AutoGarage.exhaustoutput.txt";

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                Eh.Stop();
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
        private void PopulateComboBox()
        {
            List<string> Maintain = new List<string> { " ", "How the Exhaust System Works", "Common Exhaust System Problems", "How to:Replace an Exhaust Gasket", "How to:Change an Oxygen Sensor" };
            exhaustcombobox.DataSource = Maintain;
        }

        public ExhaustSystem()
        {
            InitializeComponent();
            exhaustcombobox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, exhaustcombobox.Width, exhaustcombobox.Height, 50, 50));
            exhaust.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, exhaust.Width, exhaust.Height, 60, 60));
        }

        private void ExhaustSystem_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            Eh.Interval = 10;
            Eh.Tick += new EventHandler(fadeIn);
            Eh.Start();
            
            this.BackgroundImage = Properties.Resources.carexhaust6;
            this.BackgroundImageLayout = ImageLayout.Stretch;


            mode = "\"w\"";
            access = "(open " + "AutoGarage.exhaustoutput.txt " + "eh" + mode + " " + ")";

            PopulateComboBox();
            melo.LoadFromResource("AutoGarage","AutoGarage.exhaust.clp");
        }

        private void exhaustcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string z;
            if(exhaustcombobox.SelectedValue.ToString()!= " ")
            {
                exhaustreset.Enabled = true;

                if(exhaustcombobox.SelectedValue.ToString() == "How the Exhaust System Works")
                {
                    //melo.Eval(access);
                    z = "(ExhaustWorking)";
                    melo.Eval(access);
                    melo.Eval(z);
                    melo.Eval("(close eh)");

                    StreamReader sr = new StreamReader(resourceName);
                    exhaust.Text = sr.ReadToEnd();
                }


                if (exhaustcombobox.SelectedValue.ToString() == "Common Exhaust System Problems")
                {
                    melo.Eval(access);
                    z = "(ExhaustProblems)";
                    
                    melo.Eval(z);
                    melo.Eval("(close eh)");
                    StreamReader sr = new StreamReader(resourceName);
                    exhaust.Text = sr.ReadToEnd();

                }

                if (exhaustcombobox.SelectedValue.ToString() == "How to:Replace an Exhaust Gasket")
                {
                    melo.Eval(access);
                    z = "(ExhaustReplace)";
                    
                    melo.Eval("(close eh)");
                    StreamReader sr = new StreamReader(resourceName);
                    exhaust.Text = sr.ReadToEnd();

                }

                if (exhaustcombobox.SelectedValue.ToString() == "How to:Change an Oxygen Sensor")
                {
                    melo.Eval(access);
                    z = "(OxygenSensorChange)";
                    melo.Eval(z);
                    melo.Eval("(close eh)");
                    StreamReader sr = new StreamReader(resourceName);
                    exhaust.Text = sr.ReadToEnd();

                }



            }

            exhaustcombobox.Enabled = false;
        }

        private void returnexhaust_Click(object sender, EventArgs e)
        {
            Ea.Tick += new EventHandler(fadeOut);
            Ea.Start();
            
        }

        private void exhaustreset_Click(object sender, EventArgs e)
        {
            exhaust.Clear();
            exhaustreset.Enabled = false;
            PopulateComboBox();
            exhaustcombobox.Enabled = true;
        }

        private void exhaust_TextChanged(object sender, EventArgs e)
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
                        if (f.GetType() == typeof(ExhaustSystem))
                        {
                            f.Activate();
                        }
                    }
                    return true;
                }
                
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void airdiagnosislabel_Click(object sender, EventArgs e)
        {

        }
    }
}
