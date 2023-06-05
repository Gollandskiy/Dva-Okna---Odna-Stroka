using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Dva_Okna___Odna_Stroka
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        public Form2()
        {
            InitializeComponent();
        }
        public void ChangeText(string text)
        {
            textBox2.Text = text;
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            form1.ChangeText(textBox2.Text);
        }
    }
}
