using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace AutoGarage
{
    public partial class CoolingSystemDiagnosis : Form
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

        private string access;
        private string mode;
        private string resourceName = "AutoGarage.coolingoutput.txt";

        public CoolingSystemDiagnosis()
        {
            InitializeComponent();
            
            coolingcombobox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, coolingcombobox.Width, coolingcombobox.Height, 40, 40));
            coolingsrichTextBox1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, coolingsrichTextBox1.Width, coolingsrichTextBox1.Height, 40, 40));
          
        }

        private CLIPSNET.Environment melo = new CLIPSNET.Environment();

        private void PopulateComboBox()
        {
            List<string> cooling = new List<string> { " ", "How the Cooling System Works", "Common Cooling System Problems", "How to: Check and Add Coolant", "Locating Leaks", "How to:Flush and Fill the Cooling System", "How to:Replace a Hose" };
            coolingcombobox.DataSource = cooling;
        }

         

        private void coolingcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            coolingbutton.Enabled = true;

            if (coolingcombobox.SelectedValue.ToString() != " ")
            {
                if (coolingcombobox.SelectedValue.ToString() == "How the Cooling System Works")
                {
                    melo.Eval(access);
                    string a = "(CoolingWork)";
                    melo.Eval(a);
                    melo.Eval("(close cool)");
                    StreamReader sr = new StreamReader(resourceName);
                    coolingsrichTextBox1.Text = sr.ReadToEnd();


                }

                if (coolingcombobox.SelectedValue.ToString() == "Common Cooling System Problems")
                {
                    melo.Eval(access);
                    string b = "(CoolingProblem)";
                    melo.Eval(b);
                    melo.Eval("(close cool)");
                    StreamReader sr = new StreamReader(resourceName);
                    coolingsrichTextBox1.Text = sr.ReadToEnd();

                }

                if (coolingcombobox.SelectedValue.ToString() == "How to: Check and Add Coolant")
                {
                    melo.Eval(access);
                    string c = "(CoolantAddition)";
                    melo.Eval(c);
                    melo.Eval("(close cool)");
                    StreamReader sr = new StreamReader(resourceName);
                    coolingsrichTextBox1.Text = sr.ReadToEnd();
                }

                if (coolingcombobox.SelectedValue.ToString() == "Locating Leaks")
                {
                    melo.Eval(access);
                    string d = "(LeakLocation)";
                    melo.Eval(d);
                    melo.Eval("(close cool)");
                    StreamReader sr = new StreamReader(resourceName);
                    coolingsrichTextBox1.Text = sr.ReadToEnd();
                }

                if (coolingcombobox.SelectedValue.ToString() == "How to:Flush and Fill the Cooling System")
                {
                    melo.Eval(access);
                    string f = "(Flush)";
                    melo.Eval(f);
                    melo.Eval("(close cool)");
                    StreamReader sr = new StreamReader(resourceName);
                    coolingsrichTextBox1.Text = sr.ReadToEnd();
                }

                if (coolingcombobox.SelectedValue.ToString() == "How to:Replace a Hose")
                {
                    melo.Eval(access);
                    string g = "(Hose)";
                    melo.Eval(g);
                    melo.Eval("(close cool)");
                    StreamReader sr = new StreamReader(resourceName);
                    coolingsrichTextBox1.Text = sr.ReadToEnd();


                }
                
            }
            coolingcombobox.Enabled = false;

        }
        Timer C = new Timer();
        Timer Co = new Timer();
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                C.Stop();
            }

            else
            {
                Opacity += 0.01;
            }
        }

        void fadeOut(object sender, EventArgs e)
        {
            Co.Interval = 10;
            if (Opacity == 0)
            {
                Co.Stop();
                Close();
            }

            else
            {
                Opacity -= 0.01;
            }
        }

        private void CoolingSystemDiagnosis_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            C.Interval = 10;
            C.Tick += new EventHandler(fadeIn);
            C.Start();
            
            this.BackgroundImage = Properties.Resources.coolingsystem1;
            this.BackgroundImageLayout = ImageLayout.Stretch;


            mode = "\"w\"";
            access = "(open " + "AutoGarage.coolingoutput.txt " + "cool" + mode + " " + ")";
            melo.LoadFromResource("AutoGarage", "AutoGarage.cooling.clp");


            PopulateComboBox();

        }

        private void coolingreturnselectbutton_Click(object sender, EventArgs e)
        {
            Co.Tick += new EventHandler(fadeOut);
            Co.Start();
            
        }

        private void coolingbutton_Click(object sender, EventArgs e)
        {
            coolingbutton.Enabled = false;
            coolingsrichTextBox1.Clear();
            PopulateComboBox();
            coolingcombobox.Enabled = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Escape)
            {
                if (Opacity == 1)
                {
                    Co.Tick += new EventHandler(fadeOut);
                    Co.Start();
                    return true;

                }
                else
                {
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.GetType() == typeof(CoolingSystemDiagnosis))
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
