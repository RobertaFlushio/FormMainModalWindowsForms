using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMainModal
{
    public partial class Form1 : Form
    {
        Form2 form2;

        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Close();
        }

        private void novaGuiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();
            novo.Show();
        }

        private void novaJanelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.label1.Text = textBox1.Text;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                form2.label1.Text += textBox1.Text;  
            }
        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Form2 form2 = new Form2();
        //  //  form2.Show();
        //    form2.ShowDialog();
        //}
    }
}
