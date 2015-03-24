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
    public partial class Form1 : Form
    {
        string toanTu = "";
        double giaTriDau = 0;
        bool isTypingNumber;
        bool kiemTraToanTu=false ;
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
        
            Button a = (Button)sender;
          
            if (isTypingNumber)
                txtresual.Text = txtresual .Text + a.Text ;
            else
            {
                txtresual.Text =a.Text ;
                isTypingNumber =true ;
            }
            
            
        }

        private void toantu_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
           
           if (giaTriDau !=0)
           {
               btnbang.PerformClick();
               kiemTraToanTu = true;
               toanTu = b.Text;
           }
           else
           {
               toanTu = b.Text;
               giaTriDau = double.Parse(txtresual.Text);
               kiemTraToanTu = true;
           }
            isTypingNumber = false;            
        }
        private void btnbang_Click(object sender, EventArgs e)
        {        
            switch (toanTu)
            {
                case "+":
                     txtresual.Text= (giaTriDau + double.Parse(txtresual.Text)).ToString();
                    break ;
                case "-":
                     txtresual.Text  = (giaTriDau - double.Parse(txtresual.Text)).ToString(); break ;
                case "/":
                     txtresual.Text  = (giaTriDau / double.Parse(txtresual.Text)).ToString(); break ;
                
                case "*":
                     txtresual.Text  =(giaTriDau * double.Parse(txtresual.Text)).ToString(); break ;
                
            }
            giaTriDau =double .Parse (txtresual .Text );
            toanTu = "";
        }

        private void btncham_Click(object sender, EventArgs e)
        {
            if (txtresual .Text .Contains ("."))
                return ;
            txtresual.Text += btncham.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtresual.Text.Contains("-"))
                txtresual.Text  = txtresual.Text.Remove(0,1);
            else
                txtresual.Text  = "-" + txtresual.Text;
           
        }

        private void btnbackspace_Click(object sender, EventArgs e)
        {
            if (txtresual .Text .Length >0)
            txtresual.Text = txtresual.Text.Remove(txtresual.Text.Length - 1);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txtresual.Clear();
            isTypingNumber = false;
        }

        private void bntsqrt_Click(object sender, EventArgs e)
        {
            txtresual.Text = Math.Sqrt(double.Parse(txtresual.Text)).ToString();
        }

        private void btnphantram_Click(object sender, EventArgs e)
        {
            txtresual.Text = ((double.Parse(txtresual.Text)) / 100).ToString();
        }

        
  
    }
}
