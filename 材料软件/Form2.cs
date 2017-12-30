using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;


namespace 材料软件
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm1 = new Form1();
            frm1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        
            foreach (Control col in this.Controls)
            {
                col.Hide();
                label1.Show();
                comboBox1.Show();
            }
        }

        public static bool IsNum(string str, int precision, int scale)
        {
            if ((precision == 0) && (scale == 0))
            {
                return false;
            }
            string pattern = @"(^[-]?\d{1," + precision + "}";
            if (scale > 0)
            {
                pattern += @"\.\d{0," + scale + "}$)|" + pattern;
            }
            pattern += "$)";
            return Regex.IsMatch(str, pattern);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            if(comboBox1.SelectedIndex==0)
            {
               foreach(Control col in this.Controls)
                {
                    col.Show();
                }
                label2.Text = "正应力";
                label3.Text = "正应力";
                label4.Text = "切应力";
                radioButton1.Text = "拉力（+）";
                radioButton2.Text = "压力（-）";
                radioButton3.Text = "拉力（+）";
                radioButton4.Text = "压力（-）";
                radioButton5.Text = "拉力（+）";
                radioButton6.Text = "压力（-）";
                label5.Text = "最大正应力";
                label7.Text = "最小正应力";
                label9.Text = "最大切应力";
                label11.Text = "正应力";
                label13.Text = "切应力";
                label9.Text = "计算任意方向的正应力和剪应力";

            }
            if(comboBox1.SelectedIndex ==1)
            {
                foreach (Control col in this.Controls)
                {
                    col.Show();
                }
                label2.Text = "正应变";
                label3.Text = "正应变";
                label4.Text = "切应变";
                radioButton1.Text = "伸长（+）";
                radioButton2.Text = "压缩（-）";
                radioButton3.Text = "伸长（+）";
                radioButton4.Text = "压缩（-）";
                radioButton5.Text = "伸长（+）";
                radioButton6.Text = "压缩（-）";
                label5.Text = "最大正应变";
                label7.Text = "最小正应变";
                label9.Text = "最大切应变";
                label11.Text = "正应变";
                label13.Text = "切应变";
                label9.Text = "计算任意方向的正应变和剪应变";
            }
        }

        double sgmx = 0, sgmy = 0, txy = 0, r = 0, m = 0;
        bool a1 = false, a2 = false, a3 = false, a4=false,b = false,c=false,d=false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (a1 && a2 && a3)
            {
                b = true;                            
                r = Math.Sqrt(((sgmx - sgmy) / 2) * ((sgmx - sgmy) / 2) + txy * txy);
                m = (sgmx + sgmy) / 2;
                textmax.Text = Convert.ToString(Math.Round(m + r, 2));
                textmin.Text = Convert.ToString(Math.Round(m - r, 2));
                if(comboBox1.SelectedIndex == 0)
                {
                    textqie.Text = Convert.ToString(Math.Round(r, 2));
                }
                if(comboBox1.SelectedIndex == 1)
                {
                    textqie.Text = Convert.ToString( Math.Round(2 * r, 2));
                }
                label6.Text = comboBox2.Text;
                label8.Text = comboBox2.Text;
                label15.Text = comboBox2.Text;
                label16.Text = comboBox2.Text;
                label21.Text = comboBox2.Text;
            }
            else
            {
                MessageBox.Show("输入值无效！");
            }


        }
        
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen1 = new Pen(Color.Black, 2);
            Pen pen2 = new Pen(Color.Blue, 2);
            pen1.StartCap = LineCap.Round;
            pen1.EndCap = LineCap.ArrowAnchor;
            graphics.DrawLine(pen1, 0f, 150f, 300f, 150f);
            graphics.DrawEllipse(pen2, 30, 30, 240, 240);
            pen1.Dispose();
            pen2.Dispose();
        }


        private void textx_Enter(object sender, EventArgs e)
        {
            textx.Text = "";
        }

        private void textx_Leave(object sender, EventArgs e)
        {
            string message = textx.Text;
            if (!IsNum(message,10,2) || Convert.ToDouble(message) < 0)
            {
                textx.Text = "";
                a1 = false;
                errorProvider1.SetError(textx, "请输入正数");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    sgmx = Convert.ToDouble(message);
                }
                if (radioButton2.Checked)
                {
                    sgmx = -Convert.ToDouble(message);
                }
                a1 = true;
                errorProvider1.SetError(textx, "");
            }
        }

        private void texty_Enter(object sender, EventArgs e)
        {
            texty.Text = "";
        }


        private void texty_Leave(object sender, EventArgs e)
        {
            string message = texty.Text;
            if (!IsNum(message, 10, 2) || Convert.ToDouble(message) < 0)
            {
                texty.Text = "";
                a2 = false;
                errorProvider2.SetError(texty, "请输入正数");
            }
            else
            {
                if (radioButton3.Checked)
                {
                    sgmy = Convert.ToDouble(message);
                }
                if (radioButton4.Checked)
                {
                    sgmy = -Convert.ToDouble(message);
                }
                a2 = true;
                errorProvider2.SetError(texty, "");
            }
        }
        
        private void textxy_Enter(object sender, EventArgs e)
        {
            textxy.Text = "";
        }

        private void textxy_Leave(object sender, EventArgs e)
        {
            string message = textxy.Text;
            if (!IsNum(message, 10, 2) || Convert.ToSingle(message) < 0)
            {
                a3 = false;
                errorProvider3.SetError(textxy, "请输入正数");
            }
            else
            {
                if (radioButton5.Checked)
                {
                    txy = Convert.ToDouble(message);
                }
                if (radioButton6.Checked)
                {
                    txy = -Convert.ToDouble(message);
                }
                a3 = true;
                errorProvider3.SetError(textxy, "");
            }
        }

        private void textalf_Enter(object sender, EventArgs e)
        {
            textalf.Text = "";
        }

        private void textalf_Leave(object sender, EventArgs e)
        {
            string message = textalf.Text;
            bool isnum = Regex.IsMatch(message, @"^[-]?\d+[.]?\d*$");
            if (!isnum)
            {
                a4 = false;
                errorProvider4.SetError(textalf, "请输入数字！");
            }
            else
            {                         
                a4 = true;
                errorProvider4.SetError(textalf, "");
            }
        }

        double sgmxr = 0, tr = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (a4)
            {
                double th = Convert.ToDouble(textalf.Text) * Math.PI / 180;
                sgmxr = (sgmx + sgmy) / 2 + (sgmx - sgmy) / 2 * Math.Cos(2 * th) + txy * Math.Sin(2 * th);
                tr = -(sgmx - sgmy) / 2 * Math.Sin(2 * th) + txy * Math.Cos(2 * th);
                label12.Text = Convert.ToString(Math.Round(sgmxr, 2));
                label14.Text = Convert.ToString(Math.Round(tr, 2));
                c = true;
            }
            else
            {
                MessageBox.Show("输入值无效！");
            }
            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            d = true;
        }
        private void button3_Paint(object sender, PaintEventArgs e)
        {
            if(d==true)
            {
                if (b == true)
                {
                    Graphics graphics = pictureBox1.CreateGraphics();
                    Pen pen3 = new Pen(Color.Red, 2);

                    graphics.DrawLine(pen3, new Point(150 + Convert.ToInt16((sgmx - m) * 120 / r),
                                                      150 + Convert.ToInt16(txy * 120 / r)),
                                            new Point(150 + Convert.ToInt16((sgmy - m) * 120 / r),
                                                      150 - Convert.ToInt16(txy * 120 / r)));
                    b = false;
                }
                if (c == true)
                {
                    Graphics graphics = pictureBox1.CreateGraphics();
                    Pen pen4 = new Pen(Color.Green, 2);
                    graphics.DrawLine(pen4, new Point(150, 150),
                                            new Point(150 + Convert.ToInt16((sgmxr-m) * 120 / r),
                                                      150 + Convert.ToInt16(tr *120 / r)));
                    c = false;
                }
            }                    
        }

    }
}
