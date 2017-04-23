using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1jMonagan
{
    public partial class Form1 : Form
    //Jerrad Monagan
    //COP2010
    //Project1


    {
        public Form1()
        {
            InitializeComponent();
        }
        double dbllength =0;
        double dblwidth =0;
        double dblradius=0;
        double dblarea= 0;
        double dblperimeter = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
                
        }
 
        private void btn1_Click(object sender, EventArgs e) //calcutlates rectagle area and perimeter
        {
            txt2.Clear();
            try
            {
               dbllength = double.Parse(txt1.Text);
               dblwidth =  double.Parse (txt3.Text);
               dblarea = dbllength * dblwidth;
               dblperimeter = (2*dbllength + 2*dblwidth);
               dblarea = Math.Round(dblarea, 4);
               dblperimeter = Math.Round(dblperimeter, 4);
               txt4.Text = dblarea.ToString();
               txt5.Text = dblperimeter.ToString();
            }//end try

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }//end catch


        }//end btn1_Click

        private void btn2_Click(object sender, EventArgs e) //claculates circle area nad perimeter
        {
            txt1.Clear();
            txt3.Clear();
            try
            {
                dblradius = double.Parse(txt2.Text);
                dblarea = Math.PI*(dblradius*dblradius);
                dblperimeter = Math.PI*2*dblradius;
                dblarea = Math.Round(dblarea, 4);
                dblperimeter = Math.Round(dblperimeter, 4);
                txt4.Text = dblarea.ToString();
                txt5.Text = dblperimeter.ToString();
            }//end try

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }//end catch

            
        }//end btn2_Click
    }//end form 1
}//end namespace
