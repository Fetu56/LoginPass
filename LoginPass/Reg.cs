using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LoginPass
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reg_Click(object sender, EventArgs e)
        {
            if(textPass.Text == textPassConf.Text && textPass.Text.Length > 3 && textEm.Text.Length > 3)
            {
                if(RegIn(textEm.Text, textPass.Text))
                {
                    MessageBox.Show("Successfull auth!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Problems with registration.");
                }
            }
            else
            {
                MessageBox.Show("Incorrect passwords!");
            }
        }
        private bool RegIn(string log, string pas)
        {
            bool res = false;
            if(File.Exists("data.txt"))
            {
                if (File.ReadAllLines("data.txt").ToList().Where(x => x.Split(' ')[0] == log).Count() == 0)
                {
                    File.AppendAllText("data.txt", $"{log} {Cash.ComputeSha256Hash(pas)}");
                    res = true;
                }
            }
            else
            {
                File.Create("data.txt").Close();
                File.AppendAllText("data.txt", $"{log} {Cash.ComputeSha256Hash(pas)}\n");
                res = true;
            }
            GC.Collect();
            return res;
        }
    }
}
