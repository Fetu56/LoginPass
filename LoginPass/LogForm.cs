using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void log_Click(object sender, EventArgs e)
        {
            if(CheckLogIn(textEm.Text, textPass.Text))
            {
                MessageBox.Show("Welcome!", "Success auth.", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Try again!", "Failed auth.", MessageBoxButtons.OK);
            }
        }

        private bool CheckLogIn(string log, string pas)
        {
            bool res = false;
            if(File.Exists("data.txt"))
            {
                List<string> data = File.ReadAllLines("data.txt").ToList();

                res = data.Where(x => x.Split(' ')[0] == log).Where(x => x.Split(' ')[1] == Cash.ComputeSha256Hash(pas)).Count() > 0 ? true : false;

                GC.Collect();
            }
            return res;
        }
        

        private void reg_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Reg().ShowDialog();
            this.Visible = true;
        }
    }
    
}
