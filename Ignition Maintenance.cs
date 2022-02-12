using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace AutoGarage
{
    public partial class Ignition_Maintenance : Form
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

        Timer Im = new Timer();
        Timer Ima = new Timer();
        private string access;
        private string mode;
        private string resourceName = "AutoGarage.ignitionoutput.txt";

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                Im.Stop();
            }

            else
            {
                Opacity += 0.01;
            }
        }

        void fadeOut(object sender, EventArgs e)
        {
            Ima.Interval = 10;
            if (Opacity == 0)
            {
                Ima.Stop();
                Close();
            }

            else
            {
                Opacity -= 0.01;
            }
        }
        public Ignition_Maintenance()
        {
            InitializeComponent();
            igmaintaincombobox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, igmaintaincombobox.Width, igmaintaincombobox.Height, 50, 50));
            maintainig.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, maintainig.Width, maintainig.Height, 50, 50));
        }

        private CLIPSNET.Environment melo = new CLIPSNET.Environment();
        private void maintaincombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if(igmaintaincombobox.SelectedValue.ToString() != " ")
            {
                ignitionreset.Enabled = true;
               
                string z;
                if(igmaintaincombobox.SelectedValue.ToString() == "How the Ignition System Works")
                {
                    z = "(Ignition-working)";
                    melo.Eval(access);
                    melo.Eval(z);
                    melo.Eval("(close ig)");
                    StreamReader sr = new StreamReader(resourceName);
                    maintainig.Text = sr.ReadToEnd();
                }

                if (igmaintaincombobox.SelectedValue.ToString() == "Take On Common ignition system problems")
                {
                    z = "(General)";
                    melo.Eval(access);
                    melo.Eval(z);
                    melo.Eval("(close ig)");
                    StreamReader sr = new StreamReader(resourceName);
                    maintainig.Text = sr.ReadToEnd();
                }

                if (igmaintaincombobox.SelectedValue.ToString() == "Signs of a failing ignition")
                {
                    z = "(IgnitionFail)";
                    melo.Eval(access);
                    melo.Eval(z);
                    melo.Eval("(close ig)");
                    StreamReader sr = new StreamReader(resourceName);
                    maintainig.Text = sr.ReadToEnd();
                }

                if (igmaintaincombobox.SelectedValue.ToString() == "How To Change spark plugs")
                {
                    z = "(Changing-spark-plugs)";
                    melo.Eval(access);
                    melo.Eval(z);
                    melo.Eval("(close ig)");
                    StreamReader sr = new StreamReader(resourceName);
                    maintainig.Text = sr.ReadToEnd();
                }

                if (igmaintaincombobox.SelectedValue.ToString() == "Changing spark plug wires")
                {
                    z = "(Changing-spark-plug-wires)";
                    melo.Eval(access);
                    melo.Eval(z);
                    melo.Eval("(close ig)");
                    StreamReader sr = new StreamReader(resourceName);
                    maintainig.Text = sr.ReadToEnd();
                }

                if (igmaintaincombobox.SelectedValue.ToString() == "Symptoms of Bad or Failing Spark Plugs")
                {
                    z = "(SparkFail)";
                    melo.Eval(access);
                    melo.Eval(z);
                    melo.Eval("(close ig)");
                    StreamReader sr = new StreamReader(resourceName);
                    maintainig.Text = sr.ReadToEnd();
                }


            }
            igmaintaincombobox.Enabled = false;
        }


        private void PopulateComboBox()
        {
            List<string> ignition = new List<string> { " ", "How the Ignition System Works", "Take On Common ignition system problems", "Signs of a failing ignition", "How To Change spark plugs", "Changing spark plug wires", "Symptoms of Bad or Failing Spark Plugs" };
            igmaintaincombobox.DataSource = ignition;
        }
        private void Ignition_Maintenance_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            Im.Interval = 10;
            Im.Tick += new EventHandler(fadeIn);
            Im.Start();
            
            this.BackgroundImage = Properties.Resources.sparkplug3;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            mode = "\"w\"";
            access = "(open " + "AutoGarage.ignitionoutput.txt " + "ig" + mode + " " + ")";
            PopulateComboBox();
            melo.LoadFromResource("AutoGarage", "AutoGarage.ignition.clp");
        }

        private void igmreturnsbutton_Click(object sender, EventArgs e)
        {
            Ima.Tick += new EventHandler(fadeOut);
            Ima.Start();
        }

        private void ignitionreset_Click(object sender, EventArgs e)
        {
            ignitionreset.Enabled = false;
            maintainig.Clear();
            PopulateComboBox();
            igmaintaincombobox.Enabled = true;
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Escape)
            {
                if (Opacity == 1)
                {
                    Ima.Tick += new EventHandler(fadeOut);
                    Ima.Start();
                    return true;

                }
                else
                {
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.GetType() == typeof(Ignition_Maintenance))
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
