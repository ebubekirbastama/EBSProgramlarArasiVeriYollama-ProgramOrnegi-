using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace EBSExedenverialma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog op;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                op = new OpenFileDialog();
                if (op.ShowDialog() == DialogResult.OK)
                {
                    ProcessStartInfo EBSİnfo = new ProcessStartInfo(op.FileName, textBox1.Text);
                    Process.Start(EBSİnfo);
                }
                else
                {
                    MessageBox.Show("Lütfen Çalıştırılacak Program belirtiniz..","EBS Time");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "EBS Time");
            }
        }
    }
}
