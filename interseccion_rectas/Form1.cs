using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interseccion_rectas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_calcular_Click(object sender, EventArgs e)
        {
            //quitar los espacios y poner en minusculas la ecuacion 1 
            string ec1sinEspacios = ec_1.Text.Replace(" ", "");
            string ec1minusculas = ec1sinEspacios.ToLower();

            //extraer la pendiente y el intercepto de la ecuacion 1
            int posicionm1 = ec1minusculas.IndexOf("=")+1;
            int posicionx1 = ec1minusculas.IndexOf("x")-1;
            string pendiente1 = ec1minusculas.Substring(posicionm1, posicionx1);
            int posicionb1 = ec1minusculas.IndexOf("+") + 1;
            string intercepto1 = ec1minusculas.Substring(posicionb1);

            //quitar los espacios y poner en minusculas la ecuacion 2 
            string ec2sinEspacios = ec_2.Text.Replace(" ", "");
            string ec2minusculas = ec2sinEspacios.ToLower();

            //extraer la pendiente y el intercepto de la ecuacion 2
            int posicionm2 = ec2minusculas.IndexOf("=") + 1;
            int posicionx2 = ec2minusculas.IndexOf("x") - 1;
            string pendiente2 = ec2minusculas.Substring(posicionm2, posicionx2);
            int posicionb2 = ec2minusculas.IndexOf("+") + 1;
            string intercepto2 = ec2minusculas.Substring(posicionb2);

            //validar si el substring si contiene numeros y operar 
            if (float.TryParse(pendiente1, out float pend1) && float.TryParse(pendiente2, out float pend2) &&
                float.TryParse(intercepto1, out float inter1) && float.TryParse(intercepto2, out float inter2))
            {
                if (pend1 == pend2)
                {
                    lbl_respuesta.Text = "sus rectas son paralelas, asi que no se cruzan en ningun punto";
                }
                if (pend1 * pend2 == -1)
                {
                    float x = (inter2 - inter1) / (pend1 - pend2);
                    float y = pend1 * x + inter1;
                    lbl_respuesta.Text = string.Format("Las rectas son perpendiculares y  se intersectan en el punto   ", "(", x, y, ")");
                }
                else
                {
                    float x = (inter2 - inter1) / (pend1 - pend2);
                    float y = pend1 * x + inter1;

                    lbl_respuesta.Text = string.Format("Las rectas se intersectan en el punto   ", "(", x, y, ")");
                }
            }
            else
            {
                lbl_respuesta.Text = "ERROR ingrese el formato correcto de las ecuacion";
            }

















            /*
            if (float.TryParse(ec_1.Text, out float num1) && float.TryParse(ec_2.Text, out float num2))
            {
                float suma = num1 + num2;
                lbl_respuesta.Text = suma.ToString();
            }
            else
            {
                lbl_respuesta.Text = "ingrese numros";
            }
            */
        }
    }
}
