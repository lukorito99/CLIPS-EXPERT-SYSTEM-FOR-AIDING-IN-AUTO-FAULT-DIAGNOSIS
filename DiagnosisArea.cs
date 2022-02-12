using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AutoGarage
{
    public partial class DiagnosisArea : Form
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

        Timer D = new Timer();
        Timer Da = new Timer();

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                D.Stop();
            }

            else
            {
                Opacity += 0.01;
            }
        }

        void fadeOut(object sender, EventArgs e)
        {
            Da.Interval = 10;
            if (Opacity == 0)
            {
                Da.Stop();
                Close();
            }

            else
            {
                Opacity -= 0.01;
            }
        }

        private void PopulateComboBox()
        {
            foreach (var item in Diagnosis_Options)
            {
                selectdiagnosiscombobox.Items.Add(item);
            }
        }

        public DiagnosisArea()
        {
            InitializeComponent();

            selectdiagnosiscombobox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, selectdiagnosiscombobox.Width, selectdiagnosiscombobox.Height, 60, 60));
           
        }

        private List<string> Diagnosis_Options = new List<string> { "Vehicle Fluids Identification", "Vehicle Fuels Identification", "Air Conditioning System", "Overall Vehicle Maintenance", "The Cooling System", "The Drivetrain", "Engine Diagnosis", "Ignition System", "The Exhaust System", "The Fuel System", "The Brake System" };



        private void DiagnosisArea_Load(object sender, EventArgs e)
        {
            
            Opacity = 0;
            D.Interval = 10;
            D.Tick += new EventHandler(fadeIn);
            D.Start();

            this.BackgroundImage = Properties.Resources.amgside;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            PopulateComboBox();

           
        }

        private void selectdiagnosiscombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if ((string)selectdiagnosiscombobox.SelectedItem == "Vehicle Fluids Identification")
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.GetType() == typeof(Car_Fluids))
                    {
                        f.Activate();
                        
                        return;
                        
                    }
                }


                Car_Fluids c = new Car_Fluids();
                c.Show();
                
            }

            if(selectdiagnosiscombobox.SelectedItem.ToString() == "Vehicle Fuels Identification")
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.GetType() == typeof(VehicleFuels))
                    {
                        f.Activate();
                        return;
                    }
                }




                VehicleFuels p = new VehicleFuels();
                p.Show();
            }
            
            if ((string)selectdiagnosiscombobox.SelectedItem == "Air Conditioning System")
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.GetType() == typeof(airconditioning))
                    {
                        f.Activate();
                        return;
                    }
                }

                


                airconditioning ac = new airconditioning();
                ac.Show();
            }

            if((string)selectdiagnosiscombobox.SelectedItem == "Overall Vehicle Maintenance")
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.GetType() == typeof(Driver_Basics))
                    {
                        f.Activate();
                        return;
                    }
                }

                

                Driver_Basics db = new Driver_Basics();
                db.Show();

               
            }

            if((string)selectdiagnosiscombobox.SelectedItem == "The Cooling System")
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.GetType() == typeof(CoolingSystemDiagnosis))
                    {
                        f.Activate();
                        return;
                    }
                }


                CoolingSystemDiagnosis cd = new CoolingSystemDiagnosis();
                cd.Show();
              
            }

            if((string)selectdiagnosiscombobox.SelectedItem == "The Drivetrain")
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.GetType() == typeof(DriveTrain))
                    {
                        f.Activate();
                        return;
                    }
                }


                DriveTrain dr = new DriveTrain();
                dr.Show();
              
            }

            if((string)selectdiagnosiscombobox.SelectedItem =="Engine Diagnosis")
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.GetType() == typeof(The_Engine))
                    {
                        f.Activate();
                        return;
                    }
                }


                The_Engine g = new The_Engine();
                g.Show();
               

            }

            if ((string)selectdiagnosiscombobox.SelectedItem == "Ignition System")
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.GetType() == typeof(The_Ignition))
                    {
                        f.Activate();
                        return;
                    }
                }


                The_Ignition i = new The_Ignition();
                i.Show();
               
            }

            if ((string)selectdiagnosiscombobox.SelectedItem == "The Exhaust System")
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.GetType() == typeof(ExhaustSystem))
                    {
                        f.Activate();
                        return;
                    }
                }


                ExhaustSystem eh = new ExhaustSystem();
                eh.Show();

            }


            if ((string)selectdiagnosiscombobox.SelectedItem == "The Fuel System")
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.GetType() == typeof(FuelSystem))
                    {
                        f.Activate();
                        return;
                    }
                }


                FuelSystem F = new FuelSystem();
                F.Show();
            }


            if ((string)selectdiagnosiscombobox.SelectedItem == "The Brake System")
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.GetType() == typeof(BrakeSystem))
                    {
                        f.Activate();
                        return;
                    }
                }


                BrakeSystem b = new BrakeSystem();
                b.Show();
            }

        }

        private void selectdiagnosislabel_Click(object sender, EventArgs e)
        {

        }

        private void returnhomebutton_Click(object sender, EventArgs e)
        {

            Da.Tick += new EventHandler(fadeOut);
            Da.Start();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Escape)
            {
                Da.Tick += new EventHandler(fadeOut);
                Da.Start();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
