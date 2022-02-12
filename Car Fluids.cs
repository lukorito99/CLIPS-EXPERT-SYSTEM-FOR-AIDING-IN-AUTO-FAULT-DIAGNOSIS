using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;


namespace AutoGarage
{
    public partial class Car_Fluids : Form
    {
        public Car_Fluids()
        {
            InitializeComponent();
            oilsappcomboBox1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, oilsappcomboBox1.Width, oilsappcomboBox1.Height, 30, 30));
        
            othercombo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, othercombo.Width, othercombo.Height, 30, 30));
            fluidssmellcomboBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, fluidssmellcomboBox.Width, fluidssmellcomboBox.Height, 30, 30));

            vehiclefluidsrichTextBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, vehiclefluidsrichTextBox.Width, vehiclefluidsrichTextBox.Height, 50, 50));



        }


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

        Timer C = new Timer();
        Timer Ca = new Timer();
        Timer Bi = new Timer();
        private string access;
        private string mode;
        private string resourceName = "AutoGarage.carfluids.txt";



        private void PopulateComboBox()
        {
            foreach (var f in Controls)
            {
                if (f == oilsappcomboBox1)
                {

                    List<string> Oilsappearanceslots = new List<string> { " ", "tan", "light-brown", "dark-brown", "thick-like-honey", "blackened-by-deposits" };
                    oilsappcomboBox1.DataSource = Oilsappearanceslots;
                }

                if (f == othercombo)
                {
                    List<string> Fluid_appearance = new List<string> { "  ", "light-amber", "clear", "red", "bright-color", "oily", "neon-yellow", "green", "amber", "blue","orange" };
                    othercombo.DataSource = Fluid_appearance;
                }

                if (f == fluidssmellcomboBox)
                {
                    List<string> Fluid_smell = new List<string> { " ", "cleanser-odour", "no-smell", "sweet-like", "burnt-smell", "fishlike", "baby-oil","relatively-odorless" };
                    fluidssmellcomboBox.DataSource = Fluid_smell;
                }

               

              


               
            }








        }
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
            Ca.Interval = 5;
            if (Opacity == 0)
            {
                Ca.Stop();
                Close();
            }

            else
            {
                Opacity -= 0.01;
            }
        }


        void BackgroundImageChange(object sender, EventArgs e)
        {
            List<System.Drawing.Bitmap> ImageCollection = new List<System.Drawing.Bitmap> { };
            ImageCollection.Add(Properties.Resources.FluidType);
            ImageCollection.Add(Properties.Resources.Coolant);
            ImageCollection.Add(Properties.Resources.Transmission_Fluid);
            ImageCollection.Add(Properties.Resources.CarFluids);
            ImageCollection.Add(Properties.Resources.VehicleFluid);


            
            var i = DateTime.Now.Second % ImageCollection.Count;
            
            
            this.BackgroundImage = ImageCollection[i];
            this.BackgroundImageLayout = ImageLayout.Stretch;
            

        }

      


        private void Car_Fluids_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            C.Interval = 5;
            C.Tick += new EventHandler(fadeIn);
            C.Start();

            Bi.Interval = 12000;//after 12000 millisecs(12 secs)
            Bi.Tick += new EventHandler(BackgroundImageChange);
            Bi.Start();

            mode = "\"w\"";
            access = "(open " + "AutoGarage.carfluids.txt " + "cf" + mode + " " + ")";
            PopulateComboBox();


            this.BackgroundImage = Properties.Resources.VehicleFluid;
            this.BackgroundImageLayout = ImageLayout.Stretch;



            melo.LoadFromResource("AutoGarage", "AutoGarage.auto.clp");
        }

        private void otherlabel_Click(object sender, EventArgs e)
        {

        }

        private void touchlabel_Click(object sender, EventArgs e)
        {

        }

        private void oilsrichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void oilsappcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            oilsappcomboBox1.Enabled = false;

            fluidssmellcomboBox.Enabled = false;
            othercombo.Enabled = false;
            


            if (oilsappcomboBox1.SelectedItem.ToString() != " ")
            {
                string q = "(Oils (appearance " + oilsappcomboBox1.SelectedItem.ToString() + "))";
                melo.AssertString(q);
            }
        }

        private void othercombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            othercombo.Enabled = false;
           
            oilsappcomboBox1.Enabled = false;

            string z;

            if (othercombo.SelectedValue.ToString() != " ")
            {

                if (othercombo.SelectedValue.ToString() == "light-amber" || othercombo.SelectedValue.ToString() == "clear")
                {
                    z = "(Fluids (appearance " + othercombo.SelectedValue.ToString() + "))";
                    melo.AssertString(z);
                }


                if (othercombo.SelectedValue.ToString() == "red" || othercombo.SelectedValue.ToString() == "bright-color" || othercombo.SelectedValue.ToString() == "oily" || othercombo.SelectedValue.ToString() == "transparent")

                {
                    z = "(TransmissionFluids (appearance " + othercombo.SelectedValue.ToString() + "))";
                    melo.AssertString(z);
                }


                if (othercombo.SelectedValue.ToString()
                 == "green" || othercombo.SelectedValue.ToString()
                 == "neon-yellow")
                {
                    z = "(Coolants (appearance " + othercombo.SelectedValue.ToString()
                        + "))";
                    melo.AssertString(z);
                }

                if (othercombo.SelectedValue.ToString()
                   == "clear")
                {
                    z = "(Water (appearance " + othercombo.SelectedValue.ToString()
                        + "))";
                    melo.AssertString(z);
                }
               


            }

        }

        private void fluidssmellcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fluidssmellcomboBox.Enabled = false;
           
            oilsappcomboBox1.Enabled = false;

            if (fluidssmellcomboBox.SelectedValue.ToString() != " ")
            {
                string w;

                if (fluidssmellcomboBox.SelectedValue.ToString()
                    == "fishlike" || fluidssmellcomboBox.SelectedValue.ToString()
                    == "baby-oil")
                {
                    w = "(Fluids (smell " + fluidssmellcomboBox.SelectedValue.ToString() + "))";
                    melo.AssertString(w);
                }

                if (fluidssmellcomboBox.SelectedValue.ToString()
                   == "burnt-smell" || fluidssmellcomboBox.SelectedValue.ToString() == "relatively-odorless")
                {
                    w = "(TransmissionFluids (smell " + fluidssmellcomboBox.SelectedValue.ToString() + "))";
                    melo.AssertString(w);
                }

                if (fluidssmellcomboBox.SelectedValue.ToString()
                    == "sweet-like"||fluidssmellcomboBox.SelectedValue.ToString()== "cleanser-odour")
                {
                    w = "(Coolants (smell " + fluidssmellcomboBox.SelectedValue.ToString() + "))";
                    melo.AssertString(w);
                }

                if (fluidssmellcomboBox.SelectedValue.ToString() == "no-smell")
                {
                    w = "(Water (smell " + fluidssmellcomboBox.SelectedValue.ToString() + "))";
                    melo.AssertString(w);
                }



               



            }
        }

       
     

       
       

        private void fluidsbutton_Click(object sender, EventArgs e)
        {
            Ca.Tick += new EventHandler(fadeOut);
            Ca.Start();


        }

        

        private void carfluidreset_Click(object sender, EventArgs e)
        {
            carfluidreset.Enabled = false;
            PopulateComboBox();

           

            if (vehiclefluidsrichTextBox.Text != null)
            {
                vehiclefluidsrichTextBox.Clear();
            }

          



            view2.Enabled = true;


            oilsappcomboBox1.Enabled = true;

            fluidssmellcomboBox.Enabled = true;
            othercombo.Enabled = true;

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
                        if (f.GetType() == typeof(Car_Fluids))
                        {
                            f.Activate();
                        }
                    }
                    return true;
                }
            }

       
            if (keyData == Keys.Enter)
            {
                                  
                         
                        carfluidreset.Enabled = true;
                        view2.Enabled = false;
                melo.Eval(access);
                melo.Run();
                melo.Eval("(close cf)");
                StreamReader sr = new StreamReader(resourceName);
                vehiclefluidsrichTextBox.Text = sr.ReadToEnd();


                if (vehiclefluidsrichTextBox.TextLength != 0)
                {
                    vehiclefluidsrichTextBox.Font = new System.Drawing.Font("Segoe UI", 18.00F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));



                }

                else
                {
                    vehiclefluidsrichTextBox.Font = new System.Drawing.Font("SimSun", 22.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    var x = "You have NOT selected any symptoms or Symptoms chosen do not describe vehicle fluids." + "If selection has been done;Please seek the services of a professional for further diagnosis.";



                    vehiclefluidsrichTextBox.Text = x;

                }
                melo.Eval("(reset)");


                return true;
            }
                
            

              
                
            
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void view2_Click(object sender, EventArgs e)
        {
            carfluidreset.Enabled = true;
            view2.Enabled = false;

            melo.Eval(access);
            melo.Run();
            melo.Eval("(close cf)");
            StreamReader sr = new StreamReader(resourceName);
            vehiclefluidsrichTextBox.Text = sr.ReadToEnd();


            if (vehiclefluidsrichTextBox.TextLength!=0)
            {
                vehiclefluidsrichTextBox.Font= new System.Drawing.Font("Segoe UI", 18.00F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               


            }

            else
            {
                vehiclefluidsrichTextBox.Font= new System.Drawing.Font("SimSun", 22.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                var x = "You have NOT selected any symptoms or Symptoms chosen do not describe vehicle fluids." + "If selection has been done;Please seek the services of a professional for further diagnosis.";



                vehiclefluidsrichTextBox.Text = x;

            }
            melo.Eval("(reset)");
        }
    }
}
