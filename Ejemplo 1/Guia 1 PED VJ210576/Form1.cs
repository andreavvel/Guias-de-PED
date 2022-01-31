using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_1_PED_VJ210576
{
    public partial class Ejemplo1 : Form
    {
        public double Num1, Num2, Resultado;
        public bool Is1, Is2, Es_op;
        int operacion;

        private void button1_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("0");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            limpiar_pantalla();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;
                operacion = 0;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;
                operacion = 1;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;
                operacion = 2;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                if (Num1 !=0)
                {
                    Is1 = true;
                    operacion = 3;
                }
                else
                {
                    MessageBox.Show("Error: no existe división por cero", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpiar_pantalla();
                    Is1 = Is2 = false;
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                if (operacion==0)
                {
                    if (Is1)
                    {
                        Num2 = obtener_valor();
                        actualizar_pantalla(operar(Num1, Num2, "+").ToString());
                        Is1 = false;
                    }
                }
                else if (operacion == 1)
                {
                    if (Is1)
                    {
                        Num2 = obtener_valor();
                        actualizar_pantalla(operar(Num1, Num2, "-").ToString());
                        Is1 = false;
                    }
                }
                else if (operacion == 2)
                {
                    if (Is1)
                    {
                        Num2 = obtener_valor();
                        actualizar_pantalla(operar(Num1, Num2, "*").ToString());
                        Is1 = false;
                    }
                }
                else if (operacion == 3)
                {
                    if (Is1)
                    {
                        Num2 = obtener_valor();
                        actualizar_pantalla(operar(Num1, Num2, "/").ToString());
                        Is1 = false;
                    }
                }
                else if (operacion == 4)
                {
                    if (Is1)
                    {
                        limpiar_pantalla();
                        actualizar_pantalla(operartrig(Num1,"sin").ToString());
                        Is1 = false;
                    }
                }
                else if (operacion == 5)
                {
                    if (Is1)
                    {
                        limpiar_pantalla();
                        actualizar_pantalla(operartrig(Num1, "cos").ToString());
                        Is1 = false;
                    }
                }
                else if (operacion == 6)
                {
                    if (Is1)
                    {
                        limpiar_pantalla();
                        actualizar_pantalla(operartrig(Num1, "tan").ToString());
                        Is1 = false;
                    }
                }
                else if (operacion == 7)
                {
                    if (Is1)
                    {
                        limpiar_pantalla();
                        actualizar_pantalla(operartrig(Num1, "log").ToString());
                        Is1 = false;
                    }
                }
                else if (operacion == 8)
                {
                    if (Is1)
                    {
                        limpiar_pantalla();
                        actualizar_pantalla(operartrig(Num1, "ln").ToString());
                        Is1 = false;
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una operación para realizar");
                }
            }
            catch
            {
                MessageBox.Show("Esta operacion requiere dos operandos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("3");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("4");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("5");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("6");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("7");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("8");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            actualizar_pantalla("9");
        }

        public Ejemplo1()
        {
            InitializeComponent();
            Is1 = Is2 = false;
        }

        private void sen_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;
                operacion = 4;
                actualizar_pantalla("sin(" + Num1 + ")");
            }
        }

        private void cos_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;
                operacion = 5;
                actualizar_pantalla( "cos(" +Num1 + ")");
            }
        }

        private void tan_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;
                operacion = 6;
                actualizar_pantalla("tan(" + Num1 + ")");
            }
        }

        private void log_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;
                operacion = 7;
                actualizar_pantalla("log(" + Num1 + ")");
            }
        }

        private void ln_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = obtener_valor();
                Is1 = true;
                operacion = 8;
                actualizar_pantalla("ln(" + Num1 + ")");
            }
        }
        public void limpiar_pantalla()
        {
            Pantalla.Text = "";
        }

        public double obtener_valor()
        {
            double valor = Convert.ToDouble(Pantalla.Text);
            limpiar_pantalla();
            return valor;
        }
        public void actualizar_pantalla(String texto)
        {
            Pantalla.Text = Pantalla.Text + texto;
        }
        public double operar(double operador1, double operador2, string signo)
        {
            double resultado = 0.0;
            switch(signo)
            {
                case "+":
                    resultado = operador1 + operador2;
                    break;
                case "-":
                    resultado = operador1 - operador2;
                    break;
                case "*":
                    resultado = operador1 * operador2;
                    break;
                case "/":
                    resultado = operador1 / operador2;
                    break;
                default:
                    break;
            }
            return resultado;
        }
        public double operartrig(double operador1, string operacion)
        {
            double resultado = 0.0;
            switch (operacion)
            {
                case "sin":
                    resultado = Math.Sin( operador1 );
                    break;
                case "cos":
                    resultado = Math.Cos( operador1);
                    break;
                case "tan":
                    resultado = Math.Tan(operador1);
                    break;
                case "log":
                    resultado = Math.Log10(operador1);
                    break;
                case "ln":
                    resultado = Math.Log(operador1);
                    break;
                default:
                    break;
            }
            return resultado;
        }
    }
}
