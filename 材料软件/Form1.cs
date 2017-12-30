using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace 材料软件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //[DllImport("user32")]
        //public static extern int SetParent(int hWndChild, int hWndNewParent);

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            this.Hide();
            frm3.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.Show();
            //SetParent((int)frm2.Handle, (int)this.Handle);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
