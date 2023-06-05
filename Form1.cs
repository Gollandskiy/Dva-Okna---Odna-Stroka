using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dva_Okna___Odna_Stroka
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            form2 = new Form2();
            form2.Show();
        }
        public void ChangeText(string str)
        {
            textBox1.Text = str;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            form2.ChangeText(textBox1.Text);
        }
    }
}
