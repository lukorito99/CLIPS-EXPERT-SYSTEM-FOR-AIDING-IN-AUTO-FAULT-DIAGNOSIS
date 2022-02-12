using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace AutoGarage
{
    public partial class BrakeSystem : Form
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

        public BrakeSystem()
        {
            InitializeComponent();
            
            soundbrakecomboBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, soundbrakecomboBox.Width, soundbrakecomboBox.Height, 40, 40));
            shuddercombo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, shuddercombo.Width, shuddercombo.Height, 40, 40));
            PullcomboBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, PullcomboBox.Width, PullcomboBox.Height, 40, 40));
            effortcombo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, effortcombo.Width, effortcombo.Height, 40, 40));



            brakerichbox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, brakerichbox.Width, brakerichbox.Height, 50, 50));
        }

        private CLIPSNET.Environment melo = new CLIPSNET.Environment();

        private string access;
        private string mode;
        private string resourceName = "AutoGarage.boutput.txt";

        private void airdiagnosislabel_Click(object sender, EventArgs e)
        {

        }

        private void soundbrakecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string z;

            soundbrakecomboBox.Enabled = false;

            if (soundbrakecomboBox.SelectedValue.ToString()!= null)
            {
                

                z = "(BrakeProblems(sound  " + soundbrakecomboBox.SelectedValue.ToString() + "))";
                melo.AssertString(z);

                

            }

            
        }

       private void PopulateComboBox()
        {
            List<string> sound = new List<string> { " ", "metal-on-metal-grinding", "squeal", "no-sound" };
            soundbrakecomboBox.DataSource = sound;

            List<string> vibration = new List<string> { " ", "YES", "NO" };
            shuddercombo.DataSource = vibration;

            List<string> pulling = new List<string> { "", "YES", "NO" };
            PullcomboBox.DataSource = pulling;

            List<string> push = new List<string> { " ", "hard", "normal" };
            effortcombo.DataSource = push;
        }

        Timer B = new Timer();
        Timer Ba = new Timer();
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
        private void BrakeSystem_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            B.Interval = 10;
            B.Tick += new EventHandler(fadeIn);
            B.Start();

            this.BackgroundImage = Properties.Resources.brakepad4;
            this.BackgroundImageLayout = ImageLayout.Stretch;





            mode = "\"w\"";
            access = "(open " + "AutoGarage.boutput.txt " + "b" + mode + " " + ")";

            PopulateComboBox();

            melo.LoadFromResource("AutoGarage", "AutoGarage.Brake.clp");
        }

        private void shuddercombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string z;

            shuddercombo.Enabled = false;

            if (shuddercombo.SelectedValue.ToString() != null )
            {
                

                z = "(BrakeProblems(vibration  " + shuddercombo.SelectedValue.ToString() + "))";
                melo.AssertString(z);

                

            }

           
        }

        private void PullcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string z;

            PullcomboBox.Enabled = false;

            if (PullcomboBox.SelectedValue.ToString() != null)
            {
              

                z = "(BrakeProblems(sound  " + PullcomboBox.SelectedValue.ToString() + "))";
                melo.AssertString(z);

                
            }

            
        }

        private void effortcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string z;

            effortcombo.Enabled = false;

            if (effortcombo.SelectedValue.ToString() != null)
            {
               

                z = "(BrakeProblems(push  " + effortcombo.SelectedValue.ToString() + "))";
                melo.AssertString(z);

               

            }

            
        }

        private void brakeid_Click(object sender, EventArgs e)
        {
            Brakereset.Enabled = true;

            melo.Eval(access);
            melo.Run();
            melo.Eval("(close b)");
            StreamReader sr = new StreamReader(resourceName);
            brakerichbox.Text = sr.ReadToEnd();


            if (brakerichbox.TextLength!=0)
            {
                brakerichbox.Font=new System.Drawing.Font("Segoe UI", 18.00F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                

                
            }

            else
            {
                brakerichbox.Font= new System.Drawing.Font("SimSun", 24.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                var x="You have NOT selected any symptoms or Symptoms chosen do not point to an underlying  problem with the Brake System." + "If selection has been done;Please seek the services of a professional for further diagnosis.";

                

                brakerichbox.Text=x;
;           }
            melo.Eval("(retract *)");
            brakeid.Enabled = false;
            
        }

        private void brakepanel_Click(object sender, EventArgs e)
        {
            Ba.Tick += new EventHandler(fadeOut);
            Ba.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Brakereset.Enabled == false)
            {
                Brakereset.Enabled = true;
            }

            foreach (Form f in Application.OpenForms)
            {
                if(f.GetType() == typeof(BrakeSystemMaintain))
                {
                    f.Activate();
                    return;
                }
            }
            BrakeSystemMaintain B = new BrakeSystemMaintain();
            B.Show();
        }

        private void brakerichbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Brakereset_Click(object sender, EventArgs e)
        {
            Brakereset.Enabled = false;
            brakeid.Enabled = true;
            PopulateComboBox();

            PullcomboBox.Enabled = true;

            soundbrakecomboBox.Enabled = true;
            effortcombo.Enabled = true;
            shuddercombo.Enabled = true;

            brakerichbox.Clear();
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
                        if (f.GetType() == typeof(BrakeSystem))
                        {
                            f.Activate();
                        }
                    }
                    return true;
                }
            }

            if(keyData == Keys.Enter)
            {
                Brakereset.Enabled = true;

                melo.Eval(access);
                melo.Run();
                melo.Eval("(close b)");
                StreamReader sr = new StreamReader(resourceName);
                brakerichbox.Text = sr.ReadToEnd();


                if (brakerichbox.TextLength != 0)
                {
                    brakerichbox.Font = new System.Drawing.Font("Segoe UI", 18.00F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));



                }

                else
                {
                    brakerichbox.Font = new System.Drawing.Font("SimSun", 24.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    var x = "You have NOT selected any symptoms or Symptoms chosen do not point to an underlying  problem with the Brake System." + "If selection has been done;Please seek the services of a professional for further diagnosis.";



                    brakerichbox.Text = x;
                    ;
                }
                melo.Eval("(retract *)");
                brakeid.Enabled = false;




                melo.Eval("(reset)");
                brakeid.Enabled = false;
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
