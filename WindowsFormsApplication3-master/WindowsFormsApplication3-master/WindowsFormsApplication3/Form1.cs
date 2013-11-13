using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            string str ;
            string op2;
            string op3;
            string op4;


            
            if (apt1.Checked == true)
            {
                str = "ชาย" ;
           

            }
            else 
            {
                str = "หญิง" ;
           
            }

           // str = str + "2.อายุ ===";
            if (bpt1.Checked == true)
            {
                op2= "18-25 ปี" ;
            }
            else  if (bpt2.Checked == true)
            {
                op2= "26-35 ปี" ;
            }
            else  if (radioButton1.Checked == true)
            {
                op2="36-45 ปี" ;

            }
          else 
            {
                op2="46 ปีขึ้นไป" ;

            }
           // str = str + "3.การศึกษา ===";
            if (cpt1.Checked == true)
            {
                op3= "ต่ำกว่าปริญญาตรี" ;
            }
            else   if (cpt2.Checked == true)
            {
                op3= "ปริญญาตรี" ;
            }
            else  
            {
                op3= "สูงกว่าปริญญาตรี" ;

            }
         //   str = str + "4.สถานภาพ ===";
            if (dpt1.Checked == true)
            {
                op4= "อาจารย์/เจ้าหน้าที่" ;
            }
            else  if (dpt2.Checked == true)
            {
               op4= "นักศักษา" ;
            }
            else 
            {
                op4= "บุคคลภายนอก" ;





            }
            Form2 frm = new Form2(str,op2,op3,op4 );
            frm.Show();
        }

        private void optMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void apt2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

