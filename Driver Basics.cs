using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace AutoGarage
{
    public partial class Driver_Basics : Form
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

        public Driver_Basics()
        {
            InitializeComponent();
            driverbasiccombobox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, driverbasiccombobox.Width, driverbasiccombobox.Height, 40, 40));
            driverbasicsrichTextBox1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, driverbasicsrichTextBox1.Width, driverbasicsrichTextBox1.Height, 40, 40));
            
        }

        private CLIPSNET.Environment melo = new CLIPSNET.Environment();
        

        private List<string> D_Basics = new List<string> {" ", "Finding a Good Mechanic",
            "Routine Maintenance Checks","Vehicle Maintenance Tips","Being Prepared As a Driver",
            "Road Safety and Emergency Safety","Avoiding Lockout","Safely Raising A Car","Proper Changing Of Tire","How To Jump Start A Battery","How To Check and Change Fuse" };

        private void PopulateComboBox()
        {
            
            driverbasiccombobox.DataSource = D_Basics;
            
        }

        Timer db = new Timer();
        Timer dba = new Timer();
        private string access;
        private string mode;
        private string resourceName = "AutoGarage.driverbasicsoutput.txt";
        


        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                db.Stop();

            }

            else
            {
                Opacity += 0.01;
            }
        }

        void fadeOut(object sender, EventArgs e)
        {
            dba.Interval = 10;

            if (Opacity == 0)
            {
                dba.Stop();
                Close();

            }

            else
            {
                Opacity -= 0.01;
            }
        }
        private void Driver_Basics_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            
            db.Interval = 10;
            db.Tick += new EventHandler(fadeIn);
            db.Start();

            this.BackgroundImage = Properties.Resources.gearstick3;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            mode = "\"w\"";
            access = "(open " + "AutoGarage.driverbasicsoutput.txt " + "dbr" + mode + " " + ")";


            PopulateComboBox();
            
            melo.LoadFromResource("AutoGarage", "AutoGarage.driverbasics.clp");
        }

        private void driverbasiccombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            driverreset.Enabled = true;
            driverbasiccombobox.Enabled = false;


            if (driverbasiccombobox.SelectedValue.ToString() != " ")
            { 
              
             

                if (driverbasiccombobox.SelectedValue.ToString() == D_Basics[1])
                {
                    melo.Eval(access);
                    string a = "(LocateMech)";
                    melo.Eval(a);
                    melo.Eval("(close dbr)");
                    StreamReader sr = new StreamReader(resourceName);
                    driverbasicsrichTextBox1.Text = sr.ReadToEnd();




                }

                if (driverbasiccombobox.SelectedValue.ToString() == D_Basics[2])
                {
                    melo.Eval(access);
                    string b = "(Routine)";
                    melo.Eval(b);
                    melo.Eval("(close dbr)");
                    StreamReader sr = new StreamReader(resourceName);
                    driverbasicsrichTextBox1.Text = sr.ReadToEnd();


                }

                if (driverbasiccombobox.SelectedValue.ToString() == D_Basics[3])
                {
                    melo.Eval(access);
                    string c = "(MaintenanceTips)";
                    melo.Eval(c);
                    melo.Eval("(close dbr)");
                    StreamReader sr = new StreamReader(resourceName);
                    driverbasicsrichTextBox1.Text = sr.ReadToEnd();
                }

                if (driverbasiccombobox.SelectedValue.ToString() == D_Basics[4])
                {
                    melo.Eval(access);
                    string d = "(Prepared)";
                    melo.Eval(d);
                    melo.Eval("(close dbr)");
                    StreamReader sr = new StreamReader(resourceName);
                    driverbasicsrichTextBox1.Text = sr.ReadToEnd();
                }

                if (driverbasiccombobox.SelectedValue.ToString() == D_Basics[5])
                {
                    melo.Eval(access);
                    string f = "(RoadSafety)";
                     
                    melo.Eval(f);
                    melo.Eval("(close dbr)");
                    StreamReader sr = new StreamReader(resourceName);
                    driverbasicsrichTextBox1.Text = sr.ReadToEnd();
                }

                if (driverbasiccombobox.SelectedValue.ToString() == D_Basics[6])
                {
                    melo.Eval(access);
                    string g = "(LockoutAvoid)";
                    melo.Eval(g);
                    melo.Eval("(close dbr)");
                    StreamReader sr = new StreamReader(resourceName);
                    driverbasicsrichTextBox1.Text = sr.ReadToEnd();
                }

                if (driverbasiccombobox.SelectedValue.ToString() == D_Basics[7])
                {
                    melo.Eval(access);
                    string h = "(SafeRaise)";
                    melo.Eval(h);
                    melo.Eval("(close dbr)");
                    StreamReader sr = new StreamReader(resourceName);
                    driverbasicsrichTextBox1.Text = sr.ReadToEnd();
                }

                if (driverbasiccombobox.SelectedValue.ToString() == D_Basics[8])
                {
                    melo.Eval(access);
                    string i = "(TireChange)";
                    melo.Eval(i);
                    melo.Eval("(close dbr)");
                    StreamReader sr = new StreamReader(resourceName);
                    driverbasicsrichTextBox1.Text = sr.ReadToEnd();
                }

                if (driverbasiccombobox.SelectedValue.ToString() == D_Basics[9])
                {
                    melo.Eval(access);
                    string j = "(JumpStart)";
                    melo.Eval(j);
                    melo.Eval("(close dbr)");
                    StreamReader sr = new StreamReader(resourceName);
                    driverbasicsrichTextBox1.Text = sr.ReadToEnd();


                }

                if (driverbasiccombobox.SelectedValue.ToString()
                    == D_Basics[10])
                {
                    melo.Eval(access);
                    string k = "(FuseCheck)";
                    melo.Eval(k);
                    melo.Eval("(close dbr)");
                    StreamReader sr = new StreamReader(resourceName);
                    driverbasicsrichTextBox1.Text = sr.ReadToEnd();
                }
            }

                                
        }

        private void basicdriverlabel_Click(object sender, EventArgs e)
        {

        }

        private void driverbasicsbutton_Click(object sender, EventArgs e)
        {
            melo.Eval("(close dbr)");
            dba.Tick += new EventHandler(fadeOut);
            dba.Start();
        }

        private void driverbasicsrichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void driverreset_Click(object sender, EventArgs e)
        {
            driverreset.Enabled = false;

            driverbasicsrichTextBox1.Clear();
            PopulateComboBox();
            driverbasiccombobox.Enabled = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Escape)
            {
                melo.Eval("(close dbr)");
                dba.Tick += new EventHandler(fadeOut);
                dba.Start();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
