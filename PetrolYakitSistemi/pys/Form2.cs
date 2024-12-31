using System;
using System.Windows.Forms;

namespace pys
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnYakitIsteme_Click(object sender, EventArgs e)
        {
            
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void btnYakitIslemleri_Click(object sender, EventArgs e)
        {
            
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void btnCalisanBilgiKaydetme_Click(object sender, EventArgs e)
        {
            
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}
