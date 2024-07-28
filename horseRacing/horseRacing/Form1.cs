using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace horseRacing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd=new Random();
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += rnd.Next(5, 15);
            pictureBox2.Left += rnd.Next(5, 15);
            pictureBox3.Left += rnd.Next(5,15);


            int millisecond=Convert.ToInt32(label1.Text);
            millisecond++;
            label1.Text=millisecond.ToString();

            if(pictureBox1.Left>pictureBox2.Left +5 && pictureBox1.Left>pictureBox3.Left+5)
            {
                richTextBox7.Text = "The black horse took the lead";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                richTextBox7.Text = "The white horse took the lead";
            }
            if (pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox1.Left + 5)
            {
                richTextBox7.Text = "The brown horse took the lead";
            }
            
            

            if (pictureBox1.Left + (pictureBox1.Width) >= richTextBox5.Left){
               timer1.Stop();
                richTextBox7.Text = "black horse wins";
            }
            if (pictureBox2.Left + (pictureBox2.Width) >= richTextBox5.Left)
            {
                timer1.Stop();
                richTextBox7.Text = "white horse wins";
            }
            if (pictureBox3.Left + (pictureBox3.Width) >= richTextBox5.Left)
            {
                timer1.Stop();
                richTextBox7.Text = "brown horse wins";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

     
    }
}
