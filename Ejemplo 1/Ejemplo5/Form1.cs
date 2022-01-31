using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo5
{
    public partial class Form1 : Form
    {
        enum Posicion // set of constants that can be added to a variable
        {
            izquierda, derecha, arriba, abajo
        }

        private int x; //coordinate in x axis
        private int y; //coordinate in y axis
        private Posicion objposicion; //variable from the enum Posicion

        public Form1()
        {
            InitializeComponent();
            x = 50;
            y = 50;
            objposicion = Posicion.abajo; // the object moves down by default
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap("birrete.png"), x, y, 65, 65);
            //The image birrete is drawn  and we establish the initial point and its size
        }

        private void timermov_Tick(object sender, EventArgs e)
        {
            if (objposicion == Posicion.derecha)
            { x += 10; }//move 10 pixels to the right
            else if (objposicion == Posicion.izquierda)
            { x -= 10; } //move 10 ixels to the left
            else if (objposicion == Posicion.arriba)
            { y -= 10; } // 10 pixels upwards
            else if (objposicion == Posicion.abajo)
            { y += 10; }//10 pixels downwards

            Invalidate(); // invalidates the control surface and redraws the control ?? 
            if (x == 0 || y == 0 || x== 520 || y == 400)
            {
                timermov.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) // if left key is pressed
            {
                objposicion = Posicion.izquierda;
            }
            else if (e.KeyCode == Keys.Right) // if right key is pressed
            {
                objposicion = Posicion.derecha;
            }
            else if(e.KeyCode == Keys.Up) // if up key is pressed
            {
                objposicion = Posicion.arriba;
            }
            else if(e.KeyCode==Keys.Down) //if down key is pressed
            {
                objposicion = Posicion.abajo;
            }
            
        }
    }
}
