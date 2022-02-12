using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;
using System.Collections.Generic;


namespace AutoGarage
{
    public partial class AutoForm : Form
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


        //Timer V = new Timer();
        Timer Bi = new Timer();
        //SoundPlayer player = new SoundPlayer(Properties.Resources.Violet__Evergarden_A_Place_to_Call_Home);
        //SoundPlayer player1 = new SoundPlayer(Properties.Resources.Violet_Evergarden_Always_Watching_Over_You);
        //bool Check = true;

        DateTime dt = DateTime.Now.ToLocalTime();
        public AutoForm()
        {
            InitializeComponent();
            
           

        }

        

        Timer AutoDiag = new Timer();

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                AutoDiag.Stop();
            }

            else
            {
                Opacity += 0.01;
            }
        }

        /*void ChangeAudio(object sender, EventArgs e)
        {
            if (!Check)
            {
                player.Stop();
                player1.PlayLooping();
                Check = true;
            }

            else
            {
                player1.Stop();
                player.PlayLooping();
                Check = false;
            }



        }*/

        void BackgroundImageChange(object sender, EventArgs e)
        {
            List<System.Drawing.Bitmap> ImageCollection = new List<System.Drawing.Bitmap> { };
            ImageCollection.Add(Properties.Resources.gearstick1);
            ImageCollection.Add(Properties.Resources.gearstick9);
            ImageCollection.Add(Properties.Resources.gearstick4);
            ImageCollection.Add(Properties.Resources.gearstick10);
            ImageCollection.Add(Properties.Resources.gearstick11);

            

            var i = DateTime.Now.Second % ImageCollection.Count;

            this.BackgroundImage = ImageCollection[i];
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }
        private void AutoForm_Load(object sender, EventArgs e)
        {
            dateinfo.Text = dt.ToLongDateString();
            
            
            Opacity = 0;
            AutoDiag.Interval = 10;
            AutoDiag.Tick += new EventHandler(fadeIn);
            AutoDiag.Start();

            
            //player.PlayLooping();
            //Check = false;

            //V.Interval = 135000;//after 135 secs
            //V.Tick += new EventHandler(ChangeAudio);
            //V.Start();


            Bi.Interval = 12000;//after 12000 millisecs(12 secs)
            Bi.Tick += new EventHandler(BackgroundImageChange);
            Bi.Start();

            this.BackgroundImage = Properties.Resources.gearstick1;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            

        }


        private void Beginbutton_Click(object sender, EventArgs e)
        {
            

            foreach (Form f in Application.OpenForms)
            {

                if (f.GetType() == typeof(decision_window))
                {
                    f.Activate();
                   
                    return;
                }
            }


                foreach (Form f in Application.OpenForms)
                {
                    if (f.GetType() == typeof(DiagnosisArea))
                    {
                        f.Activate();
                    
                    return;
                    }
                }


                DiagnosisArea d = new DiagnosisArea();
                
                d.Show();


        }

        private void Endbutton_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(decision_window))
                {
                    f.Activate();
                   

                    return;
                    
                }
            }

            

            decision_window d = new decision_window();
            d.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, d.Width, d.Height, 40, 40));
            d.Show();

             





        }

        private void autodiagnosislabel_Click(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            

            if (keyData == Keys.Escape)
            {

                if (Opacity == 1)
                {
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.GetType() == typeof(decision_window))
                        {
                            f.Activate();
                            



                        }
                    }



                    decision_window d = new decision_window();
                    d.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, d.Width, d.Height, 40, 40));
                    d.Show();
                    return true;
                }
                else
                {
                    foreach (Form f in Application.OpenForms)
                    {
                        if(f.GetType() == typeof(AutoForm))
                        {
                            f.Activate();
                        }
                    }
                    return true;
                }
            }

            if (keyData == Keys.Enter)
            {
                if (Opacity == 1)
                {

                    foreach (Form f in Application.OpenForms)
                    {

                        if (f.GetType() == typeof(decision_window))
                        {
                            f.Activate();
                            
                            
                        }
                    }


                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.GetType() == typeof(DiagnosisArea))
                        {
                            f.Activate();
                            
                            
                        }
                    }


                    DiagnosisArea d = new DiagnosisArea();

                    d.Show();
                    
                }
                return true;


            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
