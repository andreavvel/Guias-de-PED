using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo4
{
    public partial class Form1 : Form
    {
        Graphics area; //Work area
        public Form1()
        {
            InitializeComponent();
            area = areadibujo.CreateGraphics();//Establishing the drawing area for the picturebox
        }

        private void btndibujar_Click(object sender, EventArgs e)
        {
            Pen lapicero = new Pen(Color.Black); //Default color

            if (txtcantidad.Text != "" || txtespaciado.Text != "" || txtx1.Text != "" || txtx2.Text != "")
            {
                switch (cmbcolor.SelectedIndex) //Color depending on selected cmbbox
                {
                    case 0: lapicero = new Pen(Color.Yellow); break;
                    case 1: lapicero = new Pen(Color.Red); break;
                    case 2: lapicero = new Pen(Color.Blue); break;
                    case 3: lapicero = new Pen(Color.Black); break;
                    default: MessageBox.Show("Selecciona un color", "Color inválido", MessageBoxButtons.OK); break;
                }
                int iteraciones = int.Parse(txtcantidad.Text); //Amount of lines to draw
                int espacio = int.Parse(txtespaciado.Text); //Space between lines (in pixels)

                area.Clear(Color.White); //Clears the area to white so that the lines aren't on top of each other


                for (int i = 0; i < iteraciones; i++)
                {
                    area.DrawLine(lapicero, int.Parse(txtx1.Text), int.Parse(txty1.Text) + (espacio * i), int.Parse(txtx2.Text), int.Parse(txty2.Text) + (espacio * i));
                    //x doesn't change and y changes every iteration, that's why we multiply the space by 1
                }
            }
            else
            { 
                MessageBox.Show("Rellena todos los campos", "Parámetros incompletos", MessageBoxButtons.OK);
            }
        }
    }
}
