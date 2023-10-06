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
    public partial class interfas : Form
    {
        public interfas()
        {
            InitializeComponent();
        }


        //ecuacion pendiente intercepto
        private void Btn_calcular_f1_Click(object sender, EventArgs e)
        {
            //quitar los espacios y poner en minusculas la ecuacion 1 
            string ec1sinEspacios = ec_1.Text.Replace(" ", "");
            string ec1minusculas = ec1sinEspacios.ToLower();

            //extraer la pendiente y el intercepto de la ecuacion 1
            int posicionm1 = ec1minusculas.IndexOf("=") + 1;
            int posicionx1 = ec1minusculas.IndexOf("x") - 2;
            string pendiente1 = ec1minusculas.Substring(posicionm1, posicionx1);
            int posicionb1 = ec1minusculas.IndexOf("+") + 1;
            string intercepto1 = ec1minusculas.Substring(posicionb1);

            //quitar los espacios y poner en minusculas la ecuacion 2 
            string ec2sinEspacios = ec_2.Text.Replace(" ", "");
            string ec2minusculas = ec2sinEspacios.ToLower();

            //extraer la pendiente y el intercepto de la ecuacion 2
            int posicionm2 = ec2minusculas.IndexOf("=") + 1;
            int posicionx2 = ec2minusculas.IndexOf("x") - 2;
            string pendiente2 = ec2minusculas.Substring(posicionm2, posicionx2);
            int posicionb2 = ec2minusculas.IndexOf("+") + 1;
            string intercepto2 = ec2minusculas.Substring(posicionb2);

            //validar si los substrings si contienen numeros y si la ecuacion esta en el formato correcto 

            if(float.TryParse(pendiente1, out float pend1) && float.TryParse(pendiente2, out float pend2) &&
               float.TryParse(intercepto1, out float inte1) && float.TryParse(intercepto2, out float inte2))
            {
                //validar si las rectas son perpendiculares 
                if (pend1 * pend2 == -1)
                {
                    float x = (inte2 - inte1) / (pend1 - pend2);
                    float y = pend1 * x + inte1;
                    lbl_respuesta.Text = "Las rectas son perpendiculares y  se intersectan en el punto " + (x, y);
                }
                //validar si las rectas son paralelas 
                else if(pend1 == pend2)                
                {
                    lbl_respuesta.Text = "sus rectas son paralelas, asi que no se cruzan en ningun punto";
                }
                else
                {
                    float x = (inte2 - inte1) / (pend1 - pend2);
                    float y = pend1 * x + inte1;

                    lbl_respuesta.Text = "Las rectas se intersectan en el punto   " + (x , y); 
                }
            }
            else
            {
                MessageBox.Show ("ERROR ingrese las ecuaciones con el formato correcto");
            }
        }


        //ecuacion punto pendiente 
        private void btn_calcular_f2_Click(object sender, EventArgs e)
        {
            //quitar los espacios y poner en minusculas la ecuacion 1 
            string ec1sinEspacios = ecu_1.Text.Replace(" ", "");
            string ec1minusculas = ec1sinEspacios.ToLower();

            //extraer las coordenadas y la pendiente de la ecuacion 1
            int posicionm1 = ec1minusculas.IndexOf("=") + 1;
            int posicionx = ec1minusculas.IndexOf("x") -5;
            string pendiente1 = ec1minusculas.Substring(posicionm1, posicionx );
            int posiciony1 = ec1minusculas.IndexOf("y") + 1;
            int posicionig1 = ec1minusculas.IndexOf("=") - 1;
            string coory = ec1minusculas.Substring(posiciony1, posicionig1);
            string coorx = ec1minusculas.Substring(7, 2);

            //quitar los espacios y poner en minusculas la ecuacion 2 
            string ec2sinEspacios = ecu_2.Text.Replace(" ", "");
            string ec2minusculas = ec2sinEspacios.ToLower();

            //extraer las coordenadas y la pendiente de la ecuacion 2
            int posicionm2 = ec2minusculas.IndexOf("=") + 1;
            int posicionx2 = ec2minusculas.IndexOf("x") - 5;
            string pendiente2 = ec2minusculas.Substring(posicionm2, posicionx2);

            int posiciony2 = ec2minusculas.IndexOf("y") + 1;
            int posicionig2 = ec2minusculas.IndexOf("=") - 1;
            string coory2 = ec2minusculas.Substring(posiciony1, posicionig1);
            string coorx2 = ec2minusculas.Substring(7, 2);

            //validar si los substrings si contienen numeros y si la ecuacion si tiene el formato correcto
            if (float.TryParse(pendiente1, out float m1) && float.TryParse(pendiente2, out float m2) &&
               float.TryParse(coorx, out float x1) && float.TryParse(coorx2, out float x2)&&
               float.TryParse(coory, out float y1) && float.TryParse(coory2, out float y2))
            {
                //validar si las rectas son perpendiculares 
                if (m1 * m2 == -1)
                {
                    float x = (y2 - y1 + m1 * x1 - m2 * x2) / (m1 - m2);
                    float y = m1 * (x - x1) + y1;
                    lbl_respuesta.Text = "Las rectas son perpendiculares y  se intersectan en el punto " + (x, y);
                }
                //validar si las rectas son paralelas 
                else if (m1 == m2)
                {
                    lbl_respuesta.Text = "sus rectas son paralelas, asi que no se cruzan en ningun punto";
                }
                else
                {
                    float x = (y2 - y1 + m1 * x1 - m2 * x2) / (m1 - m2);
                    float y = m1 * (x - x1) + y1;
                    lbl_respuesta.Text = "Las rectas se intersectan en el punto   " + (x, y);
                }
            }
            else
            {
                MessageBox.Show("ERROR ingrese las ecuaciones con el formato correcto\n" +
                    " y recuerde que solo puede ingresar magnitudes entre 0 y 9");
            }
        }
    }
    
}
