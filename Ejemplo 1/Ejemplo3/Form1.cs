using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo3
{
    public partial class Form1 : Form
    {
        int x, y; //variables globales q permiten determinar la ubicación del click
        private Random rndm = new Random(); // randomiza valores

        public Form1()
        {
            InitializeComponent();
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point punto = new Point(e.X, e.Y); //estamos tomando las coordenadas del click mediante el parámetro e
            //tomamos las coordenadas del objeto point y lo guardamos en las variables
            x = punto.X;
            y = punto.Y;
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Pen lapiz = new Pen(Color.FromArgb(rndm.Next(256), rndm.Next(256), rndm.Next(256)));// delimita la randomizacion a 256
            //se selecciona la cantidad de rojo, azul y verde con numeros aleatorios para conseguir un color aleatorio en c/ click

            if (listBox1.SelectedIndex == 0) //si selecciona circulo
            {
                SolidBrush sb = new SolidBrush(Color.FromArgb(rndm.Next(256), rndm.Next(256), rndm.Next(256))); //pincel
                int rndmvalue = rndm.Next(100);
                g.DrawEllipse(lapiz, x - rndmvalue, y - rndmvalue, rndmvalue*2, rndmvalue*2); //dibuja la elipse de un tamaño randomizado
                //dio el click
                g.FillEllipse(sb, x - rndmvalue, y - rndmvalue, rndmvalue * 2, rndmvalue * 2); //rellena la elipse dibujada
            }

            if (listBox1.SelectedIndex == 1)
            {
                SolidBrush sb = new SolidBrush(Color.FromArgb(rndm.Next(256), rndm.Next(256), rndm.Next(256)));
                int rndmvalue = rndm.Next(100);
                g.DrawRectangle(lapiz, x - rndmvalue, y - rndmvalue, rndmvalue * 2, rndmvalue * 2); //dibuja el cuadrado de un tamaño randomizado
                g.FillRectangle(sb, x - rndmvalue, y - rndmvalue, rndmvalue * 2, rndmvalue * 2);
            }
        }
    }

    }

