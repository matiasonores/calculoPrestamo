using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraPrestamo
{
   public partial class calculadoraPrestamo : Form
   {
      decimal montoPrestamo, taza;
      int meses, con;

      private void btn_limpiar_Click(object sender, EventArgs e)
      {
         lb_calculo.Items.Clear();
      }

      private void btn_salir_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      public calculadoraPrestamo()
      {
         InitializeComponent();
      }

      private void btn_calcular_Click(object sender, EventArgs e)
      {
         //Actualizar valores de las variables

         if(decimal.TryParse(txt_monto.Text, out montoPrestamo))
         {
            if(int.TryParse(txt_meses.Text, out meses))
            {
               if(decimal.TryParse(txt_taza.Text, out taza))
               {
                  //Si la carga de datos es éxitosa
                  lb_calculo.Items.Clear();
                  con = 1;
                  while (con <= meses)
                  {
                     montoPrestamo += montoPrestamo * taza;
                     lb_calculo.Items.Add("En el " + (con) + "º mes el préstamo es: " + montoPrestamo.ToString("c"));
                     con++;
                  }

                  txt_final.Text = montoPrestamo.ToString("c");
               }
               else
                  MessageBox.Show("Ingrese un valor númerico");
               
            }
            else
               MessageBox.Show("Ingrese un valor númerico");
            
         }
         else
            MessageBox.Show("Ingrese un valor númerico");
      }
   }
}
