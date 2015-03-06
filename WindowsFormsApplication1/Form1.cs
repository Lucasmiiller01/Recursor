using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class Recursor : Form
    {
        private double number;
        private double total;
       

       // private double total;
        public Recursor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button Clicou = sender as Button;
            string Caixa_t = Caixa.Text;
            total = 1;
            number = Convert.ToDouble(Caixa_t);
            for (Double i = number; i > 0; i--)
            {
                total *= i;
                
                
            }
            Result.Text = (total).ToString(); 
      


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button Clicou = sender as Button;
            
            number = Convert.ToDouble(Caixa.Text);
            total = contar(number);
            Result.Text = (total).ToString(); 
        }
         double contar (double batata)
        {
            if(batata < 1) return batata = 1;
                return contar(batata - 1) * batata;
        }

         private void Caixa_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (e.KeyChar == (char)Keys.Space)
             {
                 e.Handled = true;
             }
             else
             {
                 if (e.KeyChar.ToString().IndexOfAny(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }) == -1)
                 {
                     e.Handled = true;
                 }
             }

         }

         private void Form1_Load(object sender, EventArgs e)
         {

         }
            
            
       
    }
}
