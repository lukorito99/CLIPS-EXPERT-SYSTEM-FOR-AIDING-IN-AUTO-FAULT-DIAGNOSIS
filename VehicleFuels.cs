using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;

namespace AutoGarage
{
    public partial class VehicleFuels : Form
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

        public VehicleFuels()
        {
            InitializeComponent();
            fuelrich.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, fuelrich.Width, fuelrich.Height, 60, 60));

           
        }

        Timer vf = new Timer();
        Timer Bi = new Timer();
        Timer Ca = new Timer();
        private string access;
        private string mode;
        private string resourceName = "AutoGarage.fuels.txt";



        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                vf.Stop();
            }

            else
            {
                Opacity += 0.01;
            }
        }

        void fadeOut(object sender, EventArgs e)
        {
            vf.Interval = 3;
            if (Opacity == 0)
            {
                vf.Stop();
                Close();
            }

            else
            {
                Opacity -= 0.05;
            }
        }


        void BackgroundImageChange(object sender, EventArgs e)
        {
            List<Bitmap> ImageCollection = new List<Bitmap> { };
            ImageCollection.Add(Properties.Resources.Diesel);
           
            ImageCollection.Add(Properties.Resources.PumpingGas);
            
            ImageCollection.Add(Properties.Resources.FuelGauge);
            ImageCollection.Add(Properties.Resources.FuelEfficient);
           
            ImageCollection.Add(Properties.Resources.VolkFuel);



            var i = DateTime.Now.Second % ImageCollection.Count;


            this.BackgroundImage = ImageCollection[i];
            this.BackgroundImageLayout = ImageLayout.Stretch;
            


        }


        private void VehicleFuels_Load(object sender, EventArgs e)
        {
            Opacity = 0;

            vf.Interval = 5;
            vf.Tick += new EventHandler(fadeIn);
            vf.Start();

            Bi.Interval = 12000;//after 12000 millisecs(12 secs)
            Bi.Tick += new EventHandler(BackgroundImageChange);
            Bi.Start();

            mode = "\"w\"";
            access = "(open " + "AutoGarage.fuels.txt " + "vf" + mode + " " + ")";
          

            this.BackgroundImage = Properties.Resources.VolkFuel;
            this.BackgroundImageLayout = ImageLayout.Stretch;


            melo.Eval("(clear)");
            melo.LoadFromResource("AutoGarage", "AutoGarage.VehicleFuels.txt");

            this.BackgroundImage = Properties.Resources.VolkFuel;
            this.BackgroundImageLayout = ImageLayout.Stretch;

          


        }

      


        private void fuelreturn_Click(object sender, EventArgs e)
        {
            Ca.Tick += new EventHandler(fadeOut);
            Ca.Start();
        }

        private void fuelview_Click(object sender, EventArgs e)
        {
            
            

            melo.Eval(access);
            melo.Eval("(FuelTraits)");
            melo.Eval("(close vf)");
            StreamReader sr = new StreamReader(resourceName);
            fuelrich.Text = sr.ReadToEnd();


        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Escape)
            {
                if (Opacity == 1)
                {
                    Ca.Tick += new EventHandler(fadeOut);
                    Ca.Start();
                    return true;

                }
                else
                {
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.GetType() == typeof(VehicleFuels))
                        {
                            f.Activate();
                        }
                    }
                    return true;
                }
            }


            if (keyData == Keys.Enter)
            {


                
                melo.Eval(access);
                melo.Eval("(FuelTraits)");
                melo.Eval("(close vf)");
                IEnumerable<string> line = File.ReadAllLines(resourceName);

                fuelrich.Text = string.Join(Environment.NewLine, line);



                return true;
            }






            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
