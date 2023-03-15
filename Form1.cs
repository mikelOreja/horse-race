using System.Diagnostics;
using System.Linq.Expressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;



namespace carrera
{
    public partial class Form1 : Form
    {

        Label res = new Label();
        
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void empezar_Click(object sender, EventArgs e)
        {
            while (progCab1.Value < progCab1.Maximum && progCab2.Value < progCab2.Maximum && progCab3.Value < progCab3.Maximum && progCab4.Value < progCab4.Maximum)
            {
                Thread caballo1 = new Thread(tarea1);
                Thread caballo2 = new Thread(tarea2);
                Thread caballo3 = new Thread(tarea3);
                Thread caballo4 = new Thread(tarea4);
                caballo1.Priority = ThreadPriority.Normal;
                caballo2.Priority = ThreadPriority.BelowNormal;
                caballo3.Priority = ThreadPriority.AboveNormal;
                caballo4.Priority = ThreadPriority.Highest;

                caballo1.Start();

                caballo2.Start();

                caballo3.Start();
              
                caballo4.Start();
            }

            String result = "";
            String ganador = "";

            if (progCab1.Value == 100)
            {
                ganador += "Ganador: caballo1" + "\n";
            }
            if (progCab2.Value == 100)
            {
                ganador += "Ganador: caballo2" + "\n";
            }
            if (progCab3.Value == 100)
            {
                ganador += "Ganador: caballo3" + "\n";
            }
            if (progCab4.Value == 100)
            {
                ganador += "Ganador: caballo4" + "\n";
            }

            result += ganador;
            result += "Caballo 1: " + progCab1.Value.ToString() + "\n";
            result += "Caballo 2: " + progCab2.Value.ToString() + "\n";
            result += "Caballo 3: " + progCab3.Value.ToString() + "\n";
            result += "Caballo 4: " + progCab4.Value.ToString() + "\n";

            if (progCab1.Value == 100 || progCab2.Value == 100 || progCab3.Value == 100 || progCab4.Value == 100)
            {
                res.Text = result;
                res.Location = new Point(620, 180);
                res.AutoSize = true;
                res.Font = new Font("Calibri", 10);
                res.BorderStyle = BorderStyle.Fixed3D;
                res.ForeColor = Color.Green;
                res.Padding = new Padding(6);

                // Adding this control to the form
                this.Controls.Add(res);
            }


        }


        /*private void sacarResultado()
        {
            CheckForIllegalCrossThreadCalls = false;
            String result = "";
            String ganador = "";

            if (progCab1.Value == 100)
            {
                ganador += "Ganador: caballo1" + "\n";
            }
            if (progCab2.Value == 100)
            {
                ganador += "Ganador: caballo2" + "\n";
            }
            if (progCab3.Value == 100)
            {
                ganador += "Ganador: caballo3" + "\n";
            }
            if (progCab4.Value == 100)
            {
                ganador += "Ganador: caballo4" + "\n";
            }

            result += ganador;
            result += "Caballo 1: " + progCab1.Value.ToString() + "\n";
            result += "Caballo 2: " + progCab2.Value.ToString() + "\n";
            result += "Caballo 3: " + progCab3.Value.ToString() + "\n";
            result += "Caballo 4: " + progCab4.Value.ToString() + "\n";

            //Prp¡obar asi
            if (progCab1.Value == 100 || progCab2.Value == 100 || progCab3.Value == 100 || progCab4.Value == 100)
            {
                res.Text = result;
                res.Location = new Point(620, 180);
                res.AutoSize = true;
                res.Font = new Font("Calibri", 10);
                res.BorderStyle = BorderStyle.Fixed3D;
                res.ForeColor = Color.Green;
                res.Padding = new Padding(6);

                // Adding this control to the form
                this.Controls.Add(res);
            }
        }*/


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progCab1_Click(object sender, EventArgs e)
        {

        }

        
        private void tarea1()
        {
            var random = new Random();
            int avance = random.Next(0, 10); 
            if(progCab1.Value + avance > 100)
            {
                try
                {
                    progCab1.Value = 100;
                }
                catch (Exception e) { }
            }
            else
            {
                try
                {
                    progCab1.Value = progCab1.Value + avance;
                }
                catch (Exception e) { }
                
            }
        }


        private void tarea2()
        {
            var random = new Random();
            int avance = random.Next(0, 10);
            if (progCab2.Value + avance > 100)
            {
                try
                {
                    progCab2.Value = 100;
                }
                catch (Exception e) { }
            }
            else
            {
                try
                {
                    progCab2.Value = progCab2.Value + avance;
                }
                catch (Exception e) { }
            }
        }

        private void tarea3()
        {
            var random = new Random();
            int avance = random.Next(0, 10);
            if (progCab3.Value + avance > 100)
            {
                try
                {
                    progCab3.Value = 100;
                }
                catch (Exception e) { }
            }
            else
            {
                try
                {
                    progCab3.Value = progCab3.Value + avance;
                }
                catch (Exception ) { }
            }
        }

        private void tarea4()
        {
            
            var random = new Random();
            int avance = random.Next(0, 10);

            if (progCab4.Value + avance > 100)
            {
                progCab4.Value = 100;
            }
            else
            {
                progCab4.Value = progCab4.Value + avance;
               
            }
        }


        private void reiniciar_Click(object sender, EventArgs e)
        {
            progCab1.Value= 0;
            progCab2.Value = 0;
            progCab3.Value = 0;
            progCab4.Value = 0;
            this.Controls.Remove(res);
        }

        private void resul_Click(object sender, EventArgs e)
        {

        }
    }
}