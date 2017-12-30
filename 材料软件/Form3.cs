using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;


namespace 材料软件
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (Control col in groupBox1.Controls)
            {
                col.Hide();
                comboBox1.Show();
                butdb.Show();
                butok.Show();
                butclr.Show();
            }
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label14.Hide();
            label15.Hide();
            label16.Hide();
            label17.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            texts1.Hide();
            texts2.Hide();
            listView1.View = View.Details;
            listView1.Columns.Add("序号", 36, HorizontalAlignment.Center);
            listView1.Columns.Add("载荷类型", 60, HorizontalAlignment.Center);
            listView1.Columns.Add("大小", 48, HorizontalAlignment.Center);
            listView1.Columns.Add("位置1", 48, HorizontalAlignment.Center);
            listView1.Columns.Add("位置2", 48, HorizontalAlignment.Center);

        }
        bool b1 = false;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    label2.Show();
                    label2.Text = "直径（mm）:";
                    textBox1.Show();
                    butclr.Show();
                    butok.Show();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    textBox2.Hide();
                    textBox3.Hide();
                    textBox4.Hide();
                    break;
                case 1:
                    label2.Show();
                    label2.Text = "外径（mm）:";
                    textBox1.Show();
                    label3.Show();
                    label3.Text = "内径（mm）:";
                    textBox2.Show();
                    butclr.Show();
                    butok.Show();
                    label4.Hide();
                    label5.Hide();
                    textBox3.Hide();
                    textBox4.Hide();
                    break;
                case 2:
                    label2.Show();
                    label2.Text = "宽（mm）:";
                    textBox1.Show();
                    label3.Show();
                    label3.Text = "高（mm）:";
                    textBox2.Show();
                    butclr.Show();
                    butok.Show();
                    label4.Hide();
                    label5.Hide();
                    textBox3.Hide();
                    textBox4.Hide();
                    break;
                case 3:
                    label2.Show();
                    label2.Text = "总宽（mm）:";
                    textBox1.Show();
                    label3.Show();
                    label3.Text = "总高（mm）:";
                    textBox2.Show();
                    label4.Show();
                    label4.Text = "腰宽（mm）:";
                    textBox3.Show();
                    label5.Show();
                    label5.Text = "腿厚（mm）:";
                    textBox4.Show();
                    butclr.Show();
                    butok.Show();
                    break;
                default:
                    MessageBox.Show("发生错误");
                    b1 = false;
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            if (comboBox2.SelectedIndex == 0)
            {
                label7.Show();
                label8.Show();
                label9.Hide();
                textBox5.Show();
                textBox6.Show();
                textBox7.Hide();
                label7.Text = "大小（N）";
            }
            if (comboBox2.SelectedIndex == 1)
            {
                label7.Show();
                label8.Show();
                label9.Hide();
                textBox5.Show();
                textBox6.Show();
                textBox7.Hide();
                label7.Text = "大小（N*m）";
            }
            if (comboBox2.SelectedIndex == 2)
            {
                label7.Show();
                label8.Show();
                label9.Show();
                textBox5.Show();
                textBox6.Show();
                textBox7.Show();
                label7.Text = "大小（N/m）";
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            Graphics g = pictureBox2.CreateGraphics();
            Bitmap bitmap1 = new Bitmap("texture1.bmp");
            Bitmap bitmap2 = new Bitmap("texture2.jpg");
            TextureBrush wood = new TextureBrush(bitmap1);
            TextureBrush wall = new TextureBrush(bitmap2);
            Pen woodp = new Pen(wood, 10);
            Pen wallp = new Pen(wall, 10);
            Pen p = new Pen(Color.Brown, 2);
            Point[] P1 = new Point[]
            {
                new Point(10,65),
                new Point(4,75),
                new Point(16,75)
            };
            Point[] P2 = new Point[]
            {
                new Point(390,65),
                new Point(384,75),
                new Point(396,75)
            };
            g.Clear(pictureBox2.BackColor);
            if (comboBox3.SelectedIndex==0)
            {
                label14.Hide();
                label15.Hide();
                texts1.Hide();
                texts2.Hide();
                g.DrawLine(woodp, 10f, 60f, 390f, 60f);
                g.DrawLine(wallp, 5f, 0f, 5f, 120f);
                b1 = true;

            } 
            if (comboBox3.SelectedIndex ==1)
            {
                label14.Hide();
                label15.Hide();
                texts1.Hide();
                texts2.Hide();
                g.DrawLine(woodp, 10f, 60f, 390f, 60f);
                g.DrawPolygon(p, P1);
                g.FillPolygon(wood, P1);
                g.DrawPolygon(p, P2);
                g.FillPolygon(wood, P2);
                b1 = true;
            }
            if(comboBox3.SelectedIndex == 2)
            {
                label14.Show();
                label15.Show();
                texts1.Show();
                texts2.Show();
                g.DrawLine(woodp, 10f, 60f, 390f, 60f);
                b1 = true;

            }   
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            textBox6.Text = "";
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            textBox7.Text = "";
        }

        private void textL_Enter(object sender, EventArgs e)
        {
            textL.Text = "";
        }

        private void textE_Enter(object sender, EventArgs e)
        {
            textE.Text = "";
        }

        private void texts1_Enter(object sender, EventArgs e)
        {
            texts1.Text = "";
        }

        private void texts2_Enter(object sender, EventArgs e)
        {
            texts2.Text = "";
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

        bool a1 = false, a2 = false, a3 = false, a4 = false, a5 = false, a6 = false,
             a7 = false, a8 = false, a9 = false, a10 = false, a11 = false, a12 = false;

        private void textBox5_Leave(object sender, EventArgs e)
        {
            string message = textBox5.Text;
            if (IsNum(message,10,2) )
            {
                a1 = true;
            }
            else
            {
                a1 = false;
                textBox5.Text = "输入值无效";
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            string message = textBox6.Text;
            if (IsNum(message,10,2) && Convert.ToDouble(message) >= 0&& Convert.ToDouble(message) <=Convert.ToDouble(textL.Text))
            {
                a2 = true;
            }
            else
            {
                a2 = false;
                textBox6.Text = "输入值无效";
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            string message = textBox7.Text;
            if (IsNum(message,10,2) && Convert.ToDouble(message) >= 0 && Convert.ToDouble(message) <= Convert.ToDouble(textL.Text))
            {
                a3 = true;
            }
            else
            {
                a3 = false;
                textBox7.Text = "输入值无效";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string message = textBox1.Text;
            if (IsNum(message,10,2) && Convert.ToDouble(message) > 0)
            {
                a4 = true;
            }
            else
            {
                a4 = false;
                textBox1.Text = "输入值无效";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            string message = textBox2.Text;
            if (IsNum(message,10,2) && Convert.ToDouble(message) > 0)
            {
                a5 = true;
            }
            else
            {
                a5 = false;
                textBox2.Text = "输入值无效";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            string message = textBox3.Text;
            if (IsNum(message,10,2) && Convert.ToDouble(message) > 0)
            {
                a6 = true;
            }
            else
            {
                a6 = false;
                textBox3.Text = "输入值无效";
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            string message = textBox4.Text;
            if (IsNum(message,10,2) && Convert.ToDouble(message) > 0)
            {
                a7 = true;
            }
            else
            {
                a7 = false;
                textBox4.Text = "输入值无效";
            }
        }

        private void textL_Leave(object sender, EventArgs e)
        {
            string message = textL.Text;
            if (IsNum(message,10,2) && Convert.ToDouble(message) > 0 )
            {
                a8 = true;
            }
            else
            {
                a8 = false;
                textL.Text = "输入值无效";
            }
        }

        private void textE_Leave(object sender, EventArgs e)
        {
            string message = textE.Text;
            if (IsNum(message,10,2) && Convert.ToDouble(message) > 0)
            {
                a9 = true;
            }
            else
            {
                a9 = false;
                textE.Text = "输入值无效";
            }
        }

        private void texts1_Leave(object sender, EventArgs e)
        {
            string message = texts1.Text;
            if (IsNum(message, 10, 2) && Convert.ToDouble(message) >= 0 && Convert.ToDouble(message) <= Convert.ToDouble(textL.Text))
            {
                a11 = true;
            }
            else
            {
                a11 = false;
                texts1.Text = "输入值无效";
            }
        }

        private void texts2_Leave(object sender, EventArgs e)
        {
            string message = texts2.Text;
            if (IsNum(message, 10, 2) && Convert.ToDouble(message) >= 0 && Convert.ToDouble(message) <= Convert.ToDouble(textL.Text))
            {
                a12 = true;
            }
            else
            {
                a12 = false;
                texts2.Text = "输入值无效";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0 || comboBox3.SelectedIndex == 1)
            {
                textE.Text = "请输入";
                textL.Text = "请输入";
                a10 = false;
            }
            if (comboBox3.SelectedIndex == 2)
            {
                textE.Text = "请输入";
                textL.Text = "请输入";
                texts1.Text = "请输入";
                texts2.Text = "请输入";
                a10 = false;
            }
            else
            {
                MessageBox.Show("请选择梁的类型！");
            }
        }

        double E = 0; double L = 0;double support1 = 0; double support2 = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            int ss1 = 0,ss2 = 0;
            if (comboBox3.SelectedIndex==0|| comboBox3.SelectedIndex == 1)
            {
                if (a8 && a9 )
                {
                    a10 = true;
                    E = Convert.ToDouble(textE.Text);
                    L = Convert.ToDouble(textL.Text);
                }
                else
                {
                    a10 = false;
                    MessageBox.Show("输入值无效！");
                }
            }
            if (comboBox3.SelectedIndex == 2)
            {
                if (a8 && a9 && a11 && a12 && Convert.ToDouble(texts1.Text) < Convert.ToDouble(texts2.Text))
                {
                    a10 = true;
                    E = Convert.ToDouble(textE.Text);
                    L = Convert.ToDouble(textL.Text);
                    support1 = Convert.ToDouble(texts1.Text);
                    support2 = Convert.ToDouble(texts2.Text);
                    ss1 = Convert.ToInt32(10 + 380 * support1 / L);
                    ss2 = Convert.ToInt32(10 + 380 * support2 / L);
                    Graphics g = pictureBox2.CreateGraphics();
                    Bitmap bitmap1 = new Bitmap("texture1.bmp");
                    TextureBrush wood = new TextureBrush(bitmap1);
                    Pen woodp = new Pen(wood, 10);
                    Pen p = new Pen(Color.Brown, 2);
                    Point[] P1 = new Point[]
                    {
                       new Point(ss1,65),
                       new Point(ss1-6,75),
                       new Point(ss1+6,75)
                    };
                    Point[] P2 = new Point[]
                    {
                       new Point(ss2,65),
                       new Point(ss2-6,75),
                       new Point(ss2+6,75)
                    };
                    g.DrawPolygon(p, P1);
                    g.FillPolygon(wood, P1);
                    g.DrawPolygon(p, P2);
                    g.FillPolygon(wood, P2);
                }
                else
                {
                    a10 = false;
                    MessageBox.Show("输入值无效！");
                }
            }
        }

        private void butok_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        if (a4)
                        {
                            double diameter = Convert.ToDouble(textBox1.Text) / 1000;
                            A.Iz = Math.PI * (Math.Pow(diameter, 4)) / 12;
                            A.Wz = A.Iz * diameter / 2;
                        }
                        else
                        {
                            MessageBox.Show("输入值无效！");
                        }
                        break;
                    }
                case 1:
                    {
                        if (a4 && a5)
                        {
                            double diameter_o = Convert.ToDouble(textBox1.Text) / 1000;
                            double diameter_i = Convert.ToDouble(textBox2.Text) / 1000;
                            A.Iz = Math.PI * (Math.Pow(diameter_o, 4) - Math.Pow(diameter_i, 4)) / 12;
                            A.Wz = A.Iz * diameter_o / 2;
                        }
                        else
                        {
                            MessageBox.Show("输入值无效！");
                        }
                        break;
                    }
                case 2:
                    {
                        if (a4 && a5)
                        {
                            double width = Convert.ToDouble(textBox1.Text) / 1000;
                            double height = Convert.ToDouble(textBox2.Text) / 1000;
                            A.Iz = width * (Math.Pow(height, 3)) / 12;
                            A.Wz = A.Iz * height / 2;
                        }
                        else
                        {
                            MessageBox.Show("输入值无效！");
                        }
                        break;
                    }
                case 3:
                    {
                        if (a4 && a5 && a6 && a7)
                        {
                            double Width = Convert.ToDouble(textBox1.Text) / 1000;
                            double Height = Convert.ToDouble(textBox2.Text) / 1000;
                            double Width_t = Convert.ToDouble(textBox3.Text) / 1000;
                            double Height_t = Convert.ToDouble(textBox4.Text) / 1000;
                            A.Iz = Width_t * Math.Pow(Height - 2 * Height_t, 3) / 12 + Width * Math.Pow(Height_t, 3) / 6 + Width * Height_t * Math.Pow(Height - Height_t, 2) / 2;
                            A.Wz = A.Iz * Height / 2;
                        }
                        else
                        {
                            MessageBox.Show("输入值无效！");
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

        }

        private void butclr_Click(object sender, EventArgs e)
        {
            foreach (Control cur in groupBox1.Controls)
            {
                if (cur is TextBox)
                {
                    cur.Text = "";
                }
            }
            A.Iz = 0;
            A.Wz = 0;
        }
   
        private void butadd_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox2.CreateGraphics();
            Pen p1 = new Pen(Color.Red, 2);
            Pen p2_1 = new Pen(Color.Blue, 2);
            Pen p2_2 = new Pen(Color.Blue, 2);
            Pen p3_1 = new Pen(Color.Green, 2);
            Pen p3_2 = new Pen(Color.Green, 2);
            AdjustableArrowCap lineArrow = new AdjustableArrowCap(6, 4, true);
            p1.CustomEndCap = lineArrow;
            p2_1.CustomEndCap = lineArrow;
            p3_1.CustomEndCap = lineArrow;
            if(a10)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    if (a1 && a2)
                    {
                        ListViewItem item1 = new ListViewItem();
                        item1.SubItems.Clear();
                        item1.SubItems[0].Text = Convert.ToString(listView1.Items.Count + 1);
                        item1.SubItems.Add(comboBox2.Text);
                        item1.SubItems.Add(textBox5.Text);
                        item1.SubItems.Add(textBox6.Text);
                        item1.SubItems.Add("0");
                        listView1.Items.Add(item1);
                        item1.EnsureVisible();
                        float x =10+ 380 * Convert.ToSingle(textBox6.Text) / Convert.ToSingle(L);
                        if(Convert.ToSingle(textBox5.Text)>0)
                        {
                            g.DrawLine(p1, x, 10, x, 55);
                        }
                        else
                        {
                            g.DrawLine(p1, x, 110, x, 65);
                        }
                    }
                    else
                    {
                        MessageBox.Show("输入值无效！");
                    }
                }
                if (comboBox2.SelectedIndex == 1)
                {
                    if (a1 && a2)
                    {
                        ListViewItem item1 = new ListViewItem();
                        item1.SubItems.Clear();
                        item1.SubItems[0].Text = Convert.ToString(listView1.Items.Count + 1);
                        item1.SubItems.Add(comboBox2.Text);
                        item1.SubItems.Add(textBox5.Text);
                        item1.SubItems.Add(textBox6.Text);
                        item1.SubItems.Add("0");
                        listView1.Items.Add(item1);
                        item1.EnsureVisible();
                        float x = 10 + 380 * Convert.ToSingle(textBox6.Text) / Convert.ToSingle(L);
                        if (Convert.ToSingle(textBox5.Text) > 0)
                        {
                            g.DrawLine(p2_2, x, 30, x,90);
                            g.DrawLine(p2_1, x, 30, x - 20, 30);
                            g.DrawLine(p2_1, x, 90, x + 20, 90);

                        }
                        else
                        {
                            g.DrawLine(p2_2, x, 30, x, 90);
                            g.DrawLine(p2_1, x, 30, x + 20, 30);
                            g.DrawLine(p2_1, x, 90, x - 20, 90);
                        }
                    }
                    else
                    {
                        MessageBox.Show("输入值无效！");
                    }
                }
                if (comboBox2.SelectedIndex == 2)
                {
                    if (a1 && a2 && a3 && Convert.ToDouble(textBox6.Text) < Convert.ToDouble(textBox7.Text))
                    {
                        ListViewItem item1 = new ListViewItem();
                        item1.SubItems.Clear();
                        item1.SubItems[0].Text = Convert.ToString(listView1.Items.Count + 1);
                        item1.SubItems.Add(comboBox2.Text);
                        item1.SubItems.Add(textBox5.Text);
                        item1.SubItems.Add(textBox6.Text);
                        item1.SubItems.Add(textBox7.Text);
                        listView1.Items.Add(item1);
                        item1.EnsureVisible();
                        float x1 = 10 + 380 * Convert.ToSingle(textBox6.Text) / Convert.ToSingle(L);
                        float x2 = 10 + 380 * Convert.ToSingle(textBox7.Text) / Convert.ToSingle(L);
                        int n = Convert.ToInt32((x2 - x1) / 10);
                        float x = x1;
                        if (Convert.ToSingle(textBox5.Text) > 0)
                        {
                            g.DrawLine(p3_2, x1, 40, x2, 40);
                            for(int i=0;i<n;i++)
                            {
                                g.DrawLine(p3_1, x, 40, x, 55);
                                x += 10;
                            }
                            g.DrawLine(p3_1, x2, 40, x2, 55);
                        }
                        else
                        {
                            g.DrawLine(p3_2, x1, 80, x2, 80);
                            for (int i = 0; i < n; i++)
                            {
                                g.DrawLine(p3_1, x, 80, x, 65);
                                x += 10;
                            }
                            g.DrawLine(p3_1, x2, 80, x2, 65);
                        }
                    }
                    else
                    {
                        MessageBox.Show("输入值无效！");
                    }
                }
            }
            else
            {
                MessageBox.Show("请输入梁的参数！");
            }                
        }
    
        private void butdel_Click(object sender, EventArgs e)
        {
            
            for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
            {
                ListViewItem item2 = listView1.SelectedItems[i];
                listView1.Items.Remove(item2); 

            }
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].Text = i + 1 + "";

            }

            Graphics g = pictureBox2.CreateGraphics();
            Pen p1 = new Pen(BackColor, 2);
            Pen p2_1 = new Pen(BackColor, 2);
            Pen p2_2 = new Pen(BackColor, 2);
            Pen p3_1 = new Pen(BackColor, 2);
            Pen p3_2 = new Pen(BackColor, 2);
            AdjustableArrowCap lineArrow = new AdjustableArrowCap(6, 4, true);
            p1.CustomEndCap = lineArrow;
            p2_1.CustomEndCap = lineArrow;
            p3_1.CustomEndCap = lineArrow;
            if (comboBox2.SelectedIndex == 0)
            {
                float x = 10 + 380 * Convert.ToSingle(textBox6.Text) / Convert.ToSingle(L);
                if (Convert.ToSingle(textBox5.Text) > 0)
                {
                    g.DrawLine(p1, x, 10, x, 55);
                }
                else
                {
                    g.DrawLine(p1, x, 110, x, 65);
                }
            }
            if (comboBox2.SelectedIndex == 1)
            {
                float x = 10 + 380 * Convert.ToSingle(textBox6.Text) / Convert.ToSingle(L);
                if (Convert.ToSingle(textBox5.Text) > 0)
                {
                    g.DrawLine(p2_2, x, 30, x, 90);
                    g.DrawLine(p2_1, x, 30, x - 20, 30);
                    g.DrawLine(p2_1, x, 90, x + 20, 90);

                }
                else
                {
                    g.DrawLine(p2_2, x, 30, x, 90);
                    g.DrawLine(p2_1, x, 30, x + 20, 30);
                    g.DrawLine(p2_1, x, 90, x - 20, 90);
                }
            }
            if (comboBox2.SelectedIndex == 2)
            {
                float x1 = 10 + 380 * Convert.ToSingle(textBox6.Text) / Convert.ToSingle(L);
                float x2 = 10 + 380 * Convert.ToSingle(textBox7.Text) / Convert.ToSingle(L);
                int n = Convert.ToInt32((x2 - x1) / 10);
                float x = x1;
                if (Convert.ToSingle(textBox5.Text) > 0)
                {
                    g.DrawLine(p3_2, x1, 40, x2, 40);
                    for (int i = 0; i < n; i++)
                    {
                        g.DrawLine(p3_1, x, 40, x, 55);
                        x += 10;
                    }
                    g.DrawLine(p3_1, x2, 40, x2, 55);
                }
                else
                {
                    g.DrawLine(p3_2, x1, 80, x2, 80);
                    for (int i = 0; i < n; i++)
                    {
                        g.DrawLine(p3_1, x, 80, x, 65);
                        x += 10;
                    }
                    g.DrawLine(p3_1, x2, 80, x2, 65);
                }
            }
            //把之前的再重画一遍
            Bitmap bitmap1 = new Bitmap("texture1.bmp");
            TextureBrush wood = new TextureBrush(bitmap1);
            Pen woodp = new Pen(wood, 10);
            g.DrawLine(woodp, 10f, 60f, 390f, 60f);
            Pen pp1 = new Pen(Color.Red, 2);
            Pen pp2_1 = new Pen(Color.Blue, 2);
            Pen pp2_2 = new Pen(Color.Blue, 2);
            Pen pp3_1 = new Pen(Color.Green, 2);
            Pen pp3_2 = new Pen(Color.Green, 2);
            pp1.CustomEndCap = lineArrow;
            pp2_1.CustomEndCap = lineArrow;
            pp3_1.CustomEndCap = lineArrow;
            for (int j = 0; j < listView1.Items.Count; j++)
            {
                string t5 = listView1.Items[j].SubItems[2].Text;
                string t6 = listView1.Items[j].SubItems[3].Text;
                string t7 = listView1.Items[j].SubItems[4].Text;
                if (listView1.Items[j].SubItems[1].Text.Trim() == "集中力")
                {
                    
                    float x = 10 + 380 * Convert.ToSingle(t6) / Convert.ToSingle(L);
                    if (Convert.ToSingle(t5) > 0)
                    {
                        g.DrawLine(pp1, x, 10, x, 55);
                    }
                    else
                    {
                        g.DrawLine(pp1, x, 110, x, 65);
                    }
                }
                if (listView1.Items[j].SubItems[1].Text.Trim() == "集中力偶")
                {
                    float x = 10 + 380 * Convert.ToSingle(t6) / Convert.ToSingle(L);
                    if (Convert.ToSingle(t5) > 0)
                    {
                        g.DrawLine(pp2_2, x, 30, x, 90);
                        g.DrawLine(pp2_1, x, 30, x - 20, 30);
                        g.DrawLine(pp2_1, x, 90, x + 20, 90);

                    }
                    else
                    {
                        g.DrawLine(pp2_2, x, 30, x, 90);
                        g.DrawLine(pp2_1, x, 30, x + 20, 30);
                        g.DrawLine(pp2_1, x, 90, x - 20, 90);
                    }
                }
                if (listView1.Items[j].SubItems[1].Text.Trim() == "均布载荷")
                {
                    float x1 = 10 + 380 * Convert.ToSingle(t6) / Convert.ToSingle(L);
                    float x2 = 10 + 380 * Convert.ToSingle(t7) / Convert.ToSingle(L);
                    int n = Convert.ToInt32((x2 - x1) / 10);
                    float x = x1;
                    if (Convert.ToSingle(t5) > 0)
                    {
                        g.DrawLine(pp3_2, x1, 40, x2, 40);
                        for (int i = 0; i < n; i++)
                        {
                            g.DrawLine(pp3_1, x, 40, x, 55);
                            x += 10;
                        }
                        g.DrawLine(pp3_1, x2, 40, x2, 55);
                    }
                    else
                    {
                        g.DrawLine(pp3_2, x1, 80, x2, 80);
                        for (int i = 0; i < n; i++)
                        {
                            g.DrawLine(pp3_1, x, 80, x, 65);
                            x += 10;
                        }
                        g.DrawLine(pp3_1, x2, 80, x2, 65);
                    }
                }
            }
        }

        private void butmod_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count>0)
            {
                listView1.SelectedItems[0].SubItems[1].Text= comboBox2.Text;
                listView1.SelectedItems[0].SubItems[2].Text = textBox5.Text;
                listView1.SelectedItems[0].SubItems[3].Text = textBox6.Text;
                if(textBox7.Visible)
                {
                    listView1.SelectedItems[0].SubItems[4].Text = textBox7.Text;
                }
            }
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].Text = i + 1 + "";
            }
            //先清除修改前的图形
            Graphics g = pictureBox2.CreateGraphics();
            Pen p1 = new Pen(BackColor, 2);
            Pen p2_1 = new Pen(BackColor, 2);
            Pen p2_2 = new Pen(BackColor, 2);
            Pen p3_1 = new Pen(BackColor, 2);
            Pen p3_2 = new Pen(BackColor, 2);
            AdjustableArrowCap lineArrow = new AdjustableArrowCap(6, 4, true);
            p1.CustomEndCap = lineArrow;
            p2_1.CustomEndCap = lineArrow;
            p3_1.CustomEndCap = lineArrow;
            if (tt4 == "集中力")
            {

                float x = 10 + 380 * Convert.ToSingle(tt6) / Convert.ToSingle(L);
                if (Convert.ToSingle(tt5) > 0)
                {
                    g.DrawLine(p1, x, 10, x, 55);
                }
                else
                {
                    g.DrawLine(p1, x, 110, x, 65);
                }
            }
            if (tt4 == "集中力偶")
            {
                float x = 10 + 380 * Convert.ToSingle(tt6) / Convert.ToSingle(L);
                if (Convert.ToSingle(tt5) > 0)
                {
                    g.DrawLine(p2_2, x, 30, x, 90);
                    g.DrawLine(p2_1, x, 30, x - 20, 30);
                    g.DrawLine(p2_1, x, 90, x + 20, 90);

                }
                else
                {
                    g.DrawLine(p2_2, x, 30, x, 90);
                    g.DrawLine(p2_1, x, 30, x + 20, 30);
                    g.DrawLine(p2_1, x, 90, x - 20, 90);
                }
            }
            if (tt4 == "均布载荷")
            {
                float x1 = 10 + 380 * Convert.ToSingle(tt6) / Convert.ToSingle(L);
                float x2 = 10 + 380 * Convert.ToSingle(tt7) / Convert.ToSingle(L);
                int n = Convert.ToInt32((x2 - x1) / 10);
                float x = x1;
                if (Convert.ToSingle(tt5) > 0)
                {
                    g.DrawLine(p3_2, x1, 40, x2, 40);
                    for (int i = 0; i < n; i++)
                    {
                        g.DrawLine(p3_1, x, 40, x, 55);
                        x += 10;
                    }
                    g.DrawLine(p3_1, x2, 40, x2, 55);
                }
                else
                {
                    g.DrawLine(p3_2, x1, 80, x2, 80);
                    for (int i = 0; i < n; i++)
                    {
                        g.DrawLine(p3_1, x, 80, x, 65);
                        x += 10;
                    }
                    g.DrawLine(p3_1, x2, 80, x2, 65);
                }
            }
            //把之前的再重画一遍
            Bitmap bitmap1 = new Bitmap("texture1.bmp");
            TextureBrush wood = new TextureBrush(bitmap1);
            Pen woodp = new Pen(wood, 10);
            g.DrawLine(woodp, 10f, 60f, 390f, 60f);
            Pen pp1 = new Pen(Color.Red, 2);
            Pen pp2_1 = new Pen(Color.Blue, 2);
            Pen pp2_2 = new Pen(Color.Blue, 2);
            Pen pp3_1 = new Pen(Color.Green, 2);
            Pen pp3_2 = new Pen(Color.Green, 2);
            pp1.CustomEndCap = lineArrow;
            pp2_1.CustomEndCap = lineArrow;
            pp3_1.CustomEndCap = lineArrow;
            for (int j = 0; j < listView1.Items.Count; j++)
            {
                string tt5 = listView1.Items[j].SubItems[2].Text;
                string tt6 = listView1.Items[j].SubItems[3].Text;
                string tt7 = listView1.Items[j].SubItems[4].Text;
                if (listView1.Items[j].SubItems[1].Text.Trim() == "集中力")
                {

                    float x = 10 + 380 * Convert.ToSingle(tt6) / Convert.ToSingle(L);
                    if (Convert.ToSingle(tt5) > 0)
                    {
                        g.DrawLine(pp1, x, 10, x, 55);
                    }
                    else
                    {
                        g.DrawLine(pp1, x, 110, x, 65);
                    }
                }
                if (listView1.Items[j].SubItems[1].Text.Trim() == "集中力偶")
                {
                    float x = 10 + 380 * Convert.ToSingle(tt6) / Convert.ToSingle(L);
                    if (Convert.ToSingle(tt5) > 0)
                    {
                        g.DrawLine(pp2_2, x, 30, x, 90);
                        g.DrawLine(pp2_1, x, 30, x - 20, 30);
                        g.DrawLine(pp2_1, x, 90, x + 20, 90);

                    }
                    else
                    {
                        g.DrawLine(pp2_2, x, 30, x, 90);
                        g.DrawLine(pp2_1, x, 30, x + 20, 30);
                        g.DrawLine(pp2_1, x, 90, x - 20, 90);
                    }
                }
                if (listView1.Items[j].SubItems[1].Text.Trim() == "均布载荷")
                {
                    float x1 = 10 + 380 * Convert.ToSingle(tt6) / Convert.ToSingle(L);
                    float x2 = 10 + 380 * Convert.ToSingle(tt7) / Convert.ToSingle(L);
                    int n = Convert.ToInt32((x2 - x1) / 10);
                    float x = x1;
                    if (Convert.ToSingle(tt5) > 0)
                    {
                        g.DrawLine(pp3_2, x1, 40, x2, 40);
                        for (int i = 0; i < n; i++)
                        {
                            g.DrawLine(pp3_1, x, 40, x, 55);
                            x += 10;
                        }
                        g.DrawLine(pp3_1, x2, 40, x2, 55);
                    }
                    else
                    {
                        g.DrawLine(pp3_2, x1, 80, x2, 80);
                        for (int i = 0; i < n; i++)
                        {
                            g.DrawLine(pp3_1, x, 80, x, 65);
                            x += 10;
                        }
                        g.DrawLine(pp3_1, x2, 80, x2, 65);
                    }
                }
            }
        }

        private void butclear_Click(object sender, EventArgs e)
        {
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                ListViewItem item3 = listView1.Items[i];
                listView1.Items.Remove(item3);
            }
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            //初始化示意图
            Graphics g = pictureBox2.CreateGraphics();
            Bitmap bitmap1 = new Bitmap("texture1.bmp");
            Bitmap bitmap2 = new Bitmap("texture2.jpg");
            TextureBrush wood = new TextureBrush(bitmap1);
            TextureBrush wall = new TextureBrush(bitmap2);
            Pen woodp = new Pen(wood, 10);
            Pen wallp = new Pen(wall, 10);
            Pen p = new Pen(Color.Brown, 2);
            g.Clear(pictureBox2.BackColor);
            if (comboBox3.SelectedIndex == 0)
            {
                g.DrawLine(woodp, 10f, 60f, 390f, 60f);
                g.DrawLine(wallp, 5f, 0f, 5f, 120f);
            }
            if (comboBox3.SelectedIndex == 1)
            {
                Point[] P1 = new Point[]
                {
                new Point(10,65),
                new Point(4,75),
                new Point(16,75)
                };
                Point[] P2 = new Point[]
                {
                new Point(390,65),
                new Point(384,75),
                new Point(396,75)
                };
                g.DrawLine(woodp, 10f, 60f, 390f, 60f);
                g.DrawPolygon(p, P1);
                g.FillPolygon(wood, P1);
                g.DrawPolygon(p, P2);
                g.FillPolygon(wood, P2);
            }
            if (comboBox3.SelectedIndex == 2)
            {
                g.DrawLine(woodp, 10f, 60f, 390f, 60f);
                support1 = Convert.ToDouble(texts1.Text);
                support2 = Convert.ToDouble(texts2.Text);
                int ss1 = Convert.ToInt32(10 + 380 * support1 / L);
                int ss2 = Convert.ToInt32(10 + 380 * support2 / L);
                Point[] P1 = new Point[]
                {
                       new Point(ss1,65),
                       new Point(ss1-6,75),
                       new Point(ss1+6,75)
                };
                Point[] P2 = new Point[]
                {
                       new Point(ss2,65),
                       new Point(ss2-6,75),
                       new Point(ss2+6,75)
                };
                g.DrawPolygon(p, P1);
                g.FillPolygon(wood, P1);
                g.DrawPolygon(p, P2);
                g.FillPolygon(wood, P2);

            }

            Pen pen1 = new Pen(Color.Black, 2);
            AdjustableArrowCap lineArrow = new AdjustableArrowCap(6, 4, true);
            //剪力图初始化
            Graphics graphics2 = pictureBox3.CreateGraphics();
            graphics2.Clear(pictureBox3.BackColor);
            pen1.CustomEndCap = lineArrow;
            graphics2.DrawLine(pen1, 0f, 60f, 410f, 60f);
            //弯矩图初始化
            Graphics graphics1 = pictureBox1.CreateGraphics();
            graphics1.Clear(pictureBox1.BackColor);
            pen1.CustomEndCap = lineArrow;
            graphics1.DrawLine(pen1, 0f, 60f, 410f, 60f);
            //挠度图初始化
            Graphics graphics3 = pictureBox4.CreateGraphics();
            graphics3.Clear(pictureBox4.BackColor);
            pen1.CustomEndCap = lineArrow;
            graphics3.DrawLine(pen1, 0f, 60f, 410f, 60f);
        }

        private void butdb_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void butplot_Click(object sender, EventArgs e)
        {
            if (b1 == false)
            {
                MessageBox.Show("请选择梁的类型！");
            }
            if (A.Iz == 0 || A.Wz == 0)
            {
                MessageBox.Show("请选择截面类型！");
            }
            if (Convert.ToBoolean(listView1.Items.Count) == false)
            {
                MessageBox.Show("请添加载荷！");
            }
            if (!a8 || !a9)
            {
                MessageBox.Show("输入值无效！");
            }
            if (b1 && a8 && a9 && Convert.ToBoolean(listView1.Items.Count) && A.Wz!=0)
            {
                Caculate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen1 = new Pen(Color.Black, 2);
            AdjustableArrowCap lineArrow = new AdjustableArrowCap(6, 4, true);
            pen1.CustomEndCap = lineArrow;
            graphics.DrawLine(pen1, 0f, 60f, 410f, 60f);
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen1 = new Pen(Color.Black, 2);
            AdjustableArrowCap lineArrow = new AdjustableArrowCap(6, 4, true);
            pen1.CustomEndCap = lineArrow;
            graphics.DrawLine(pen1, 0f, 60f, 410f, 60f);
        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen1 = new Pen(Color.Black, 2);
            AdjustableArrowCap lineArrow = new AdjustableArrowCap(6, 4, true);
            pen1.CustomEndCap = lineArrow;
            graphics.DrawLine(pen1, 0f, 60f, 410f, 60f);
        }



        public void Static(out int FN,out int MN,out int QN,out double[] F, out double[] FSP, 
            out double[] M, out double[] MSP, out double[] Q, out double[] QSPF, out double[] QSPE)
        {
            FN = 0; MN = 0; QN = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[1].Text.Trim() == "集中力")
                {
                    FN++;
                }         
                if (listView1.Items[i].SubItems[1].Text.Trim() == "集中力偶")
                {
                    MN++;
                } 
                if (listView1.Items[i].SubItems[1].Text.Trim() == "均布载荷")
                {
                    QN++;
                }                    
            }

            F=new double[FN];
            FSP = new double[FN];
            M = new double[MN];
            MSP = new double[MN]; 
            Q = new double[QN]; 
            QSPF = new double[QN]; 
            QSPE = new double[QN];
            int a = 0, b = 0, c = 0;

            for (int i = 0; i < listView1.Items.Count; i++)
            {          
                if (listView1.Items[i].SubItems[1].Text.Trim() == "集中力")
                {
                    F[a] = Convert.ToDouble(listView1.Items[i].SubItems[2].Text);
                    FSP[a] = Convert.ToDouble(listView1.Items[i].SubItems[3].Text);
                    a++;
                }        
            }

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[1].Text.Trim() == "集中力偶")
                {
                    M[b] = Convert.ToDouble(listView1.Items[i].SubItems[2].Text);
                    MSP[b] = Convert.ToDouble(listView1.Items[i].SubItems[3].Text);
                    b++;
                }
            }

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[1].Text.Trim() == "均布载荷")
                {
                    Q[c] = Convert.ToDouble(listView1.Items[i].SubItems[2].Text);
                    QSPF[c] = Convert.ToDouble(listView1.Items[i].SubItems[3].Text);
                    QSPE[c] = Convert.ToDouble(listView1.Items[i].SubItems[4].Text);
                    c++;
                }
            }
        }

        public double[]  Sort()
        {
            List<double> myAL = new List<double>();
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                myAL.Add(Convert.ToDouble(listView1.Items[i].SubItems[3].Text));
            }
            for (int j = 0; j < listView1.Items.Count; j++)
            {

                myAL.Add(Convert.ToDouble(listView1.Items[j].SubItems[4].Text));

            }
            myAL.Add(0);
            myAL.Add(L);
            var Query = myAL.ToArray().Distinct().ToList();
            Query = Query.OrderBy(u => u).ToList();
            double[] COM = new double[Query.Count];
            Query.CopyTo(COM);
            return COM;           
        }

        public void Caculate()
        {
            Graphics g1 = pictureBox1.CreateGraphics();
            Graphics g2 = pictureBox3.CreateGraphics();
            Graphics g3 = pictureBox4.CreateGraphics();
            g1.Clear(pictureBox1.BackColor);
            g2.Clear(pictureBox3.BackColor);
            g3.Clear(pictureBox4.BackColor);
            //画中轴线
            Pen pen1 = new Pen(Color.Black,2);
            AdjustableArrowCap lineArrow = new AdjustableArrowCap(6, 4, true);
            pen1.CustomEndCap = lineArrow;
            g1.DrawLine(pen1, 0f, 60f, 410f, 60f);
            g2.DrawLine(pen1, 0f, 60f, 410f, 60f);
            g3.DrawLine(pen1, 0f, 60f, 410f, 60f);
            Pen pen2 = new Pen(Color.Blue, 2);
            //开始计算
            int FN, MN, QN;
            double[] F;double[] FSP; double[] M;double[] MSP;double[] Q;double[] QSPF;double[] QSPE; 
            double a = 0,b = 0,c = 0,d = 0,e = 0, Tmax1 = 0, Cmax1 = 0, Tmax = 0,Cmax = 0, Point =0,MIN=0,MAX=0, SigmaTmax=0, SigmaCmax=0;
            string aa = null,bb= null, cc= null, dd= null, ee = null;
            double[] COM = Sort();
            double[] y0 = new double[COM.Length - 1]; double[] y1 = new double[COM.Length - 1];
            double[] p0 = new double[COM.Length - 1]; double[] p1 = new double[COM.Length - 1];
            double[] u0 = new double[COM.Length - 1]; double[] u1 = new double[COM.Length - 1];
            Static(out FN, out MN, out QN, out F, out FSP, out M, out MSP, out Q, out QSPF, out QSPE);
            richTextBox2.Text = "各段剪力方程为：\n";
            richTextBox1.Text = "各段弯矩方程为：\n";
            richTextBox3.Text = "各段挠度方程为：\n";
            for (int k=0; k< COM.Length-1; k++)
            {       
                if (COM[k] != COM[k+1])
                {
                    //剪力求解开始端
                    a = 0;b = 0;
                    richTextBox2.Text += "从x=" + COM[k] + "到x=" + COM[k + 1] + "段:\n";
                    if (FN != 0)
                    {
                        for(int i = 0; i < FN; i++)
                        {
                            if (COM[k + 1] <= FSP[i])
                            {
                                b = b - F[i];
                            }
                        }
                    }
                    if (QN != 0)
                    {
                        for (int i = 0; i < QN; i++)
                        {
                            if (COM[k + 1] <= QSPE[i] && COM[k] >= QSPE[i])
                            {
                                a = a + Q[i];
                                b = b - Q[i] * QSPE[i];
                            }
                            if(COM[k + 1] <= QSPF[i])
                            {
                                b = b - Q[i] * (QSPE[i] - QSPF[i]);
                            }
                        }
                    }
                    if (a == 0)
                    {
                        richTextBox2.Text += "F(x)=" + b + "\n";
                        p0[k] = b;
                        p1[k] = b;
                    }
                    if (b == 0 && a != 0)
                    {
                        richTextBox2.Text += "F(x)=" + a + "x\n";
                        p0[k] = a * COM[k];
                        p1[k] = a * COM[k + 1];
                    }
                    if (a * b != 0)
                    {
                        if (b > 0)
                        {
                            richTextBox2.Text += "F(x)=" + a + "x+" + b + "\n";
                        }
                        if (b < 0)
                        {
                            richTextBox2.Text += "F(x)=" + a + "x" + b + "\n";
                        }
                        p0[k] = a * COM[k] + b;
                        p1[k] = a * COM[k + 1] + b;
                    }

                    //内力矩求解开始端
                    a = 0; b = 0;c = 0;
                    richTextBox1.Text += "从x=" + COM[k] + "到x=" + COM[k + 1] + "段:\n";
                    if (FN!=0)
                    {
                       for(int i=0;i<FN;i++)
                        {
                            if(COM[k+1] <= FSP[i])
                            {
                                a = a - F[i];
                                b = b + FSP[i] * F[i];
                            }
                        }
                    }
                    if(QN!= 0)
                    {
                        for(int i=0;i<QN;i++)
                        {
                            if(COM[k+1] <= QSPF[i])
                            {
                                a = a - Q[i] * (QSPE[i] - QSPF[i]);
                                b = b + Q[i] * (QSPE[i] - QSPF[i]) * (QSPE[i] + QSPF[i]) / 2;
                            }
                           if(COM[k] >= QSPF[i] && COM[k+1] <= QSPE[i])
                            {
                                a = a - QSPE[i] * Q[i];
                                b = b + QSPE[i] * Q[i] * QSPE[i] / 2;
                                c = c + Q[i] / 2;
                            }
                        }
                    }
                    if(MN!= 0)
                    {
                        for (int i = 0; i < MN; i++)
                        {
                            if(COM[k+1] <= MSP[i])
                                b = b - M[i];
                        }
                    }

                    //计算最大拉压应力
                    if (c!=0)
                    {
                        if (Point < COM[k] || Point > COM[k + 1])
                        {
                            MIN = min(c * COM[k] * COM[k] + a * COM[k] + b, c * COM[k+1] * COM[k+1] + a * COM[k+1] + b);
                            MAX = max(c * COM[k] * COM[k] + a * COM[k] + b, c * COM[k+1] * COM[k+1] + a * COM[k+1] + b);
                        }
                        else
                        {
                            MIN = min(c * COM[k] * COM[k] + a * COM[k] + b, c * COM[k + 1] * COM[k + 1] + a * COM[k + 1] + b);
                            MIN = min(MIN, c * Point * Point + a * Point + b);
                            MAX = max(c * COM[k] * COM[k] + a * COM[k] + b, c * COM[k + 1] * COM[k + 1] + a * COM[k + 1] + b);
                            MAX = max(MAX, c * Point * Point + a * Point + b);
                        }
                    }
                    else
                    {
                        MIN = min(c * COM[k] * COM[k] + a * COM[k] + b, c * COM[k + 1] * COM[k + 1] + a * COM[k + 1] + b);
                        MAX = max(c * COM[k] * COM[k] + a * COM[k] + b, c * COM[k + 1] * COM[k + 1] + a * COM[k + 1] + b);
                    }
                    if (MIN > 0)
                    {
                        Tmax1 = MAX;
                        Cmax1 = 0;
                        if (MAX < 0)
                        {
                            Tmax1 = 0;
                            Cmax1 = MIN;
                        }
                        else
                        {
                            Tmax1 = MAX;
                            Cmax1 = MIN;
                        }
                    }
                    if(Tmax1 > Tmax)
                    {
                        Tmax = Tmax1;
                    }
                    if (Cmax1 < Cmax)
                    {
                        Cmax = Cmax1;
                    }
                    if (c==0)
                    {
                        if(a==0)
                        {
                            richTextBox1.Text += "M(x)=" + b + "\n";
                            y0[k] = b;
                            y1[k] = b;
                        }
                        if (b == 0 && a!= 0)
                        {
                            richTextBox1.Text += "M(x)=" + a + "x\n";
                            y0[k] = a * COM[k];
                            y1[k] = a * COM[k+1];
                        }
                        if(a * b!= 0)
                        {
                            if(b>0)
                            {
                                richTextBox1.Text += "M(x)=" + a + "x+" + b + "\n";                               
                            }
                            if(b<0)
                            {
                                richTextBox1.Text += "M(x)=" + a + "x" + b + "\n";
                            }
                            y0[k] = a * COM[k] + b;
                            y1[k] = a * COM[k + 1] + b;
                        }
                    }
                    else
                    {
                        if(a == 0)
                        {
                            if(b==0)
                            {
                                richTextBox1.Text += "M(x)=" + c + "x^2\n";
                                y0[k] = c * COM[k] * COM[k];
                                y1[k] = c * COM[k + 1] * COM[k + 1];
                            }
                            if(b>0)
                            {
                                richTextBox1.Text += "M(x)=" + c + "x^2+" + b + "\n";
                                y0[k] = c * COM[k] * COM[k] + b;
                                y1[k] = c * COM[k + 1] * COM[k + 1] + b;
                            }
                            if(b<0)
                            {
                                richTextBox1.Text += "M(x)=" + c + "x^2" + b + "\n";
                                y0[k] = c * COM[k] * COM[k] + b;
                                y1[k] = c * COM[k + 1] * COM[k + 1] + b;
                            }
                        }
                        if (b == 0)
                        {
                            if(a>0)
                            {
                                richTextBox1.Text += "M(x)=" + c + "x^2+" + a + "x\n";
                            }
                            if(a<0)
                            {
                                richTextBox1.Text += "M(x)=" + c + "x^2" + a + "x\n";
                            }
                            y0[k] = c * COM[k] * COM[k] + a* COM[k];
                            y1[k] = c * COM[k + 1] * COM[k + 1] + a * COM[k + 1];
                        }
                        if (a!= 0 && b!=0)
                        {
                            if (a > 0 && b > 0)
                            {
                                richTextBox1.Text += "M(x)=" + c + "x^2+" + a + "x+" + b + "\n";
                            }
                            if (a < 0 && b > 0)
                            {
                                richTextBox1.Text += "M(x)=" + c + "x^2" + a + "x+" + b + "\n";
                            }
                            if (a > 0 && b < 0)
                            {
                                richTextBox1.Text += "M(x)=" + c + "x^2+" + a + "x" + b + "\n";
                            }
                            if(a < 0 && b < 0)
                            {
                                richTextBox1.Text += "M(x)=" + c + "x^2" + a + "x" + b + "\n";
                            }
                            y0[k] = c * COM[k] * COM[k] + a * COM[k]+b;
                            y1[k] = c * COM[k + 1] * COM[k + 1] + a * COM[k + 1]+b;
                        }
                    }

                    //挠度计算开始
                    a = 0; b = 0; c = 0; d = 0; e = 0;
                    richTextBox3.Text += "从x=" + COM[k] + "到x=" + COM[k + 1] + "段:\n";
                    if (FN != 0)
                    {
                        for (int i = 0; i < FN; i++)
                        {
                            if (COM[k + 1] <= FSP[i])
                            {
                                b = A.Iz;
                                b = F[i];
                                b = E;
                                b = b - F[i] / (6 * E * A.Iz);
                                c = c + F[i] * FSP[i] / (2 * E * A.Iz);
                            }
                            if (COM[k] >= FSP[i])
                            {
                                d = d + F[i] * FSP[i] * FSP[i] / (2 * E * A.Iz);
                                e = e - F[i] * FSP[i] * FSP[i] * FSP[i] / (6 * E * A.Iz);
                            }
                        }
                    }
                    if (MN != 0)
                    {
                        for (int i = 0; i < MN; i++)
                        {
                            if (COM[k + 1] <= MSP[i])
                            {
                                c = c - M[i] / (2 * E * A.Iz);
                            }
                            if (COM[k] >= MSP[i])
                            {
                                d = d - M[i] * MSP[i] / (E * A.Iz);
                                e = e + M[i] * MSP[i] * MSP[i] / (2 * E * A.Iz);
                            }
                        }
                    }
                    if (QN != 0)
                    {
                        for (int i = 0; i < QN; i++)
                        {
                            if (COM[k + 1] <= QSPF[i])
                            {
                                b = b + Q[i] * (QSPF[i] - QSPE[i]) / (6 * E * A.Iz);
                                c = c + Q[i] * (QSPE[i] * QSPE[i] - QSPF[i] * QSPF[i]) / (4 * E * A.Iz);
                            }
                            if (COM[k] >= QSPF[i] & COM[k + 1] <= QSPE[i])
                            {
                                a = a + Q[i] / (24 * E * A.Iz);
                                b = b - Q[i] * QSPE[i] / (6 * E * A.Iz);
                                c = c + Q[i] * QSPE[i] * QSPE[i] / (4 * E * A.Iz);
                                d = d - Q[i] * Math.Pow(QSPF[i], 3) / (6 * E * A.Iz);
                                e = e + Q[i] * Math.Pow(QSPF[i], 4) / (24 * E * A.Iz);
                            }
                            if (COM[k] >= QSPE[i])
                            {
                                d = d - Q[i] * (Math.Pow(QSPF[i], 3) - Math.Pow(QSPE[i], 3)) / (6 * E * A.Iz);
                                e = e + Q[i] * (Math.Pow(QSPF[i], 4) - Math.Pow(QSPE[i], 4)) / (24 * E * A.Iz);
                            }
                        }
                    }
                    u0[k] = e * Math.Pow(COM[k], 4) + d * Math.Pow(COM[k], 3) + c* COM[k] * COM[k] + b* COM[k]+a;
                    u1[k] = c * Math.Pow(COM[k+1], 4) + d * Math.Pow(COM[k+1], 3) + c * COM[k + 1]* COM[k + 1] + b * COM[k+1] + a;
                    a = Math.Round(a, 2);
                    b = Math.Round(b, 2);
                    c = Math.Round(c, 2);
                    d = Math.Round(d, 2);
                    e = Math.Round(e, 2);
                    ee = e + "x^4";
                    if (d > 0)
                    {
                        dd = "+" + d + "x^3";
                    }
                    else
                    {
                        dd = d + "x^3";
                    }
                    if (c > 0)
                    {
                        cc = "+" + c + "x^2";
                    }
                    else
                    {
                        cc = c + "x^2";
                    }
                    if (b > 0)
                    {
                        bb = "+" + b + "x";
                    }
                    else
                    {
                        bb = b + "x";
                    }
                    if (a > 0)
                    {
                        aa = "+" + a;
                    }
                    else
                    {
                        aa = Convert.ToString(e);
                    }


                    if (e == 0)
                    {
                        dd = d + "x^3";
                        if (d == 0)
                        {
                            cc = c + "x^2";
                            if (c == 0)
                            {
                                bb = b + "x";
                                if (b == 0)
                                {
                                    aa = Convert.ToString(a);
                                }
                            }
                        }
                    }

                    richTextBox3.Text += "v(x)=";
                    if (e != 0)
                    {
                        richTextBox3.Text += ee;
                    }
                    if (d != 0)
                    {
                        richTextBox3.Text += dd;
                    }
                    if (c != 0)
                    {
                        richTextBox3.Text += cc;
                    }
                    if (b != 0)
                    {
                        richTextBox3.Text += bb;
                    }
                    if (a != 0)
                    {
                        richTextBox3.Text += aa;
                    }
                    if (e==0&&d==0&&c==0&&b==0&&a==0)
                    {
                        richTextBox3.Text += aa;
                    }
                }
            }
            //求危险点（最大拉压应力）
            SigmaTmax = Math.Round(Tmax / (A.Wz * Math.Pow(10, 6)),2);
            SigmaCmax = Math.Round(Cmax / (A.Wz * Math.Pow(10, 6)),2);
            label16.Show();
            label17.Show();
            label16.Text = Convert.ToString(SigmaTmax);
            label17.Text = Convert.ToString(SigmaCmax);

            //开始绘制剪力图
            //求出最大剪力确定像素压缩比
            List<double> myJL = new List<double>();
            for (int i = 0; i < COM.Length - 1; i++)
            {
                myJL.Add(Math.Abs(p0[i]));
            }
            for (int j = 0; j < COM.Length - 1; j++)
            {
                myJL.Add(Math.Abs(p1[j]));
            }
            var Query1 = myJL.ToArray().Distinct().ToList();
            Query1 = Query1.OrderBy(u => u).ToList();
            double Pmax = Query1[Query1.Count - 1];

            float[] P1 = new float[p0.Length];
            float[] P2 = new float[p1.Length];
            float[] P = new float[COM.Length];

            for (int i = 0; i < p1.Length; i++)
            {
                P1[i] = Convert.ToSingle(60 - Math.Round(58 * p0[i] / Pmax, 2));
                P2[i] = Convert.ToSingle(60 - Math.Round(58 * p1[i] / Pmax, 2));
            }
            for (int k = 0; k < COM.Length; k++)
            {
                P[k] = Convert.ToSingle(Math.Round(400 * COM[k] / COM[COM.Length - 1], 2));
            }
            //画连接线
            g2.DrawLine(pen2, 0, P1[0], 0, 60);
            for (int m = 0; m < COM.Length - 2; m++)
            {
                g2.DrawLine(pen2, P[m + 1], P1[m + 1], P[m + 1], P2[m]);
            }
            g2.DrawLine(pen2, 400, P2[P2.Length - 1], 400, 60);
            //画剪力线
            for (int k = 0; k < COM.Length - 1; k++)
            {
                if (COM[k] != COM[k + 1])
                {
                    g2.DrawLine(pen2, P[k], P1[k], P[k + 1], P2[k]);
                }
            }

            //开始绘制弯矩图
            //求出最大弯矩确定像素压缩比
            List<double> myWL = new List<double>();
            for (int i = 0; i < COM.Length - 1; i++)
            {
                myWL.Add(Math.Abs(y0[i]));
            }
            for (int j = 0; j < COM.Length - 1; j++)
            {
                myWL.Add(Math.Abs(y1[j]));
            }
            var Query2 = myWL.ToArray().Distinct().ToList();
            Query2 = Query2.OrderBy(u => u).ToList();
            double Ymax = Query2[Query2.Count - 1];

            float[] Y1=new float[y0.Length];
            float[] Y2=new float[y1.Length];
            float[] X = new float[COM.Length];
           
            for (int i=0;i< y1.Length; i++)
            {
                Y1[i] = Convert.ToSingle(60-Math.Round(58 * y0[i] / Ymax, 2));
                Y2[i] = Convert.ToSingle(60-Math.Round(58 * y1[i] / Ymax, 2));
            }
            for(int k = 0; k < COM.Length; k++)
            {
                X[k] = Convert.ToSingle(Math.Round(400 * COM[k] / COM[COM.Length - 1], 2));
            }
            //画连接线
            g1.DrawLine(pen2, 0, Y1[0],0, 60);
            for(int m = 0; m < COM.Length-2 ;m++)
            {
                g1.DrawLine(pen2, X[m + 1], Y1[m + 1], X[m + 1], Y2[m]);
            }
            g1.DrawLine(pen2, 400, Y2[Y2.Length-1], 400, 60);
            //画弯矩线
            for (int k = 0; k < COM.Length - 1; k++)
            {
                float x1 = 0; float x2 = 0; float yy1 = 0; float yy2 = 0; float xx1 = 0; float xx2 = 0;
                int num = Convert.ToInt32(1000 * (X[k + 1] - X[k]) / X[X.Length - 1]);
                if (COM[k] != COM[k + 1])
                {
                    a = 0; b = 0; c = 0;
                    if (FN != 0)
                    {
                        for (int i = 0; i < FN; i++)
                        {
                            if (COM[k + 1] <= FSP[i])
                            {
                                a = a - F[i];
                                b = b + FSP[i] * F[i];
                            }
                        }
                    }
                    if (QN != 0)
                    {
                        for (int i = 0; i < QN; i++)
                        {
                            if (COM[k + 1] <= QSPF[i])
                            {
                                a = a - Q[i] * (QSPE[i] - QSPF[i]);
                                b = b + Q[i] * (QSPE[i] - QSPF[i]) * (QSPE[i] + QSPF[i]) / 2;
                            }
                            if (COM[k] >= QSPF[i] && COM[k + 1] <= QSPE[i])
                            {
                                a = a - QSPE[i] * Q[i];
                                b = b + QSPE[i] * Q[i] * QSPE[i] / 2;
                                c = c + Q[i] / 2;
                            }
                        }
                    }
                    if (MN != 0)
                    {
                        for (int i = 0; i < MN; i++)
                        {
                            if (COM[k + 1] <= MSP[i])
                                b = b - M[i];
                        }
                    }
                    if (c == 0)
                    {
                        g1.DrawLine(pen2, X[k], Y1[k], X[k + 1], Y2[k]);                      
                    }
                    else
                    {
                        x1 = Convert.ToSingle(COM[k]);
                        x2 = Convert.ToSingle(COM[k] + COM[COM.Length - 1] / 1000);
                        xx1 = Convert.ToSingle(Math.Round(400 * x1 / COM[COM.Length - 1], 2));
                        xx2 = Convert.ToSingle(Math.Round(400 * x2 / COM[COM.Length - 1], 2));
                        for (int i=0;i<num;i++)
                        {
                            yy1 = Convert.ToSingle(60 - Math.Round(58 * (c * x1 * x1 + a * x1 + b) / Ymax, 4));
                            yy2 = Convert.ToSingle(60 - Math.Round(58 * (c * x2 * x2 + a * x2 + b) / Ymax, 4));
                            g1.DrawLine(pen2, xx1, yy1, xx2, yy2);
                            x1 += Convert.ToSingle(COM[COM.Length - 1] / 1000); 
                            x2 += Convert.ToSingle(COM[COM.Length - 1] / 1000);
                            xx1 = Convert.ToSingle(Math.Round(400 * x1 / COM[COM.Length - 1], 2));
                            xx2 = Convert.ToSingle(Math.Round(400 * x2 / COM[COM.Length - 1], 2));
                        }        
                    }
                }
            }

            //开始绘制挠度图
            //求出最大挠度确定像素压缩比
            List<double> myNL = new List<double>();
            for (int i = 0; i < COM.Length - 1; i++)
            {
                myNL.Add(Math.Abs(u0[i]));
            }
            for (int j = 0; j < COM.Length - 1; j++)
            {
                myNL.Add(Math.Abs(u1[j]));
            }
            var Query3 = myNL.ToArray().Distinct().ToList();
            Query3 = Query3.OrderBy(u => u).ToList();

            double Umax = Query3[Query3.Count - 1];
            float[] U1 = new float[u0.Length];
            float[] U2 = new float[u1.Length];
            float[] U = new float[COM.Length];

            for (int i = 0; i < u1.Length; i++)
            {
                U1[i] = Convert.ToSingle(60 - Math.Round(58 * u0[i] / Umax, 2));
                U2[i] = Convert.ToSingle(60 - Math.Round(58 * u1[i] / Umax, 2));
            }
            for (int k = 0; k < COM.Length; k++)
            {
                U[k] = Convert.ToSingle(Math.Round(400 * COM[k] / COM[COM.Length - 1], 2));
            }
            //画连接线
            g3.DrawLine(pen2, 0, U1[0], 0, 60);
            for (int m = 0; m < COM.Length - 2; m++)
            {
                g3.DrawLine(pen2, U[m + 1], U1[m + 1], U[m + 1], U2[m]);
            }
            g3.DrawLine(pen2, 400, U2[U2.Length - 1], 400, 60);
            //画挠度线
            for (int k = 0; k < COM.Length - 1; k++)
            {
                float x1 = 0; float x2 = 0; float yy1 = 0; float yy2 = 0; float xx1 = 0; float xx2 = 0;
                int num = Convert.ToInt32(1000 * (U[k + 1] - U[k]) / U[U.Length - 1]);
                if (COM[k] != COM[k + 1])
                {
                    a = 0; b = 0; c = 0; d = 0; e = 0;
                    if (FN != 0)
                    {
                        for (int i = 0; i < FN; i++)
                        {
                            if (COM[k + 1] <= FSP[i])
                            {
                                b = A.Iz;
                                b = F[i];
                                b = E;
                                b = b - F[i] / (6 * E * A.Iz);
                                c = c + F[i] * FSP[i] / (2 * E * A.Iz);
                            }
                            if (COM[k] >= FSP[i])
                            {
                                d = d + F[i] * FSP[i] * FSP[i] / (2 * E * A.Iz);
                                e = e - F[i] * FSP[i] * FSP[i] * FSP[i] / (6 * E * A.Iz);
                            }
                        }
                    }
                    if (MN != 0)
                    {
                        for (int i = 0; i < MN; i++)
                        {
                            if (COM[k + 1] <= MSP[i])
                            {
                                c = c - M[i] / (2 * E * A.Iz);
                            }
                            if (COM[k] >= MSP[i])
                            {
                                d = d - M[i] * MSP[i] / (E * A.Iz);
                                e = e + M[i] * MSP[i] * MSP[i] / (2 * E * A.Iz);
                            }
                        }
                    }
                    if (QN != 0)
                    {
                        for (int i = 0; i < QN; i++)
                        {
                            if (COM[k + 1] <= QSPF[i])
                            {
                                b = b + Q[i] * (QSPF[i] - QSPE[i]) / (6 * E * A.Iz);
                                c = c + Q[i] * (QSPE[i] * QSPE[i] - QSPF[i] * QSPF[i]) / (4 * E * A.Iz);
                            }
                            if (COM[k] >= QSPF[i] & COM[k + 1] <= QSPE[i])
                            {
                                a = a + Q[i] / (24 * E * A.Iz);
                                b = b - Q[i] * QSPE[i] / (6 * E * A.Iz);
                                c = c + Q[i] * QSPE[i] * QSPE[i] / (4 * E * A.Iz);
                                d = d - Q[i] * Math.Pow(QSPF[i], 3) / (6 * E * A.Iz);
                                e = e + Q[i] * Math.Pow(QSPF[i], 4) / (24 * E * A.Iz);
                            }
                            if (COM[k] >= QSPE[i])
                            {
                                d = d - Q[i] * (Math.Pow(QSPF[i], 3) - Math.Pow(QSPE[i], 3)) / (6 * E * A.Iz);
                                e = e + Q[i] * (Math.Pow(QSPF[i], 4) - Math.Pow(QSPE[i], 4)) / (24 * E * A.Iz);
                            }
                        }
                    }
                    x1 = Convert.ToSingle(COM[k]);
                    x2 = Convert.ToSingle(COM[k] + COM[COM.Length - 1] / 1000);
                    xx1 = Convert.ToSingle(Math.Round(400 * x1 / COM[COM.Length - 1], 2));
                    xx2 = Convert.ToSingle(Math.Round(400 * x2 / COM[COM.Length - 1], 2));
                    for (int i = 0; i < num; i++)
                    {
                        double  iii= e * Math.Pow(x1, 4) + d * Math.Pow(x1, 3) + c * Math.Pow(x1, 2) + b * x1 + a;
                        yy1 = Convert.ToSingle(60 - Math.Round(58 * (e * Math.Pow(x1, 4) + d * Math.Pow(x1, 3) 
                                                               + c * Math.Pow(x1, 2) + b * x1 + a) / Umax, 4));
                        yy2 = Convert.ToSingle(60 - Math.Round(58 * (e * Math.Pow(x2, 4) + d * Math.Pow(x2, 3) 
                                                               + c * Math.Pow(x2, 2) + b * x2 + a) / Umax, 4));
                        g3.DrawLine(pen2, xx1, yy1, xx2, yy2);
                        x1 += Convert.ToSingle(COM[COM.Length - 1] / 1000);
                        x2 += Convert.ToSingle(COM[COM.Length - 1] / 1000);
                        xx1 = Convert.ToSingle(Math.Round(400 * x1 / COM[COM.Length - 1], 2));
                        xx2 = Convert.ToSingle(Math.Round(400 * x2 / COM[COM.Length - 1], 2));
                    }
                }
            }
        }

        public double min(double a,double b)
        {
            return a <= b ? a: b;
        }

        public double max(double a, double b)
        {
            return a <= b ? b: a ;
        }

        public class myReverserClass : IComparer
        {          
            int IComparer.Compare(Object x, Object y)
            {
                return ((new CaseInsensitiveComparer()).Compare(y, x));
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                comboBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox5.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBox6.Text = listView1.SelectedItems[0].SubItems[3].Text;
                if (textBox7.Visible)
                {
                    textBox7.Text = listView1.SelectedItems[0].SubItems[4].Text;
                }
                tt4 = listView1.SelectedItems[0].SubItems[1].Text;
                tt5 = listView1.SelectedItems[0].SubItems[2].Text;
                tt6 = listView1.SelectedItems[0].SubItems[3].Text;
                tt7 = listView1.SelectedItems[0].SubItems[4].Text;
            }
                
        }
        string tt4, tt5, tt6, tt7;

        //点击列表头排序
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewColumnSorter lvwColumnSorter = new ListViewColumnSorter();
            foreach (ColumnHeader ch in listView1.Columns)
            {
                ch.ImageIndex = -1;
            }

            listView1.ListViewItemSorter = lvwColumnSorter;
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }
            listView1.Sort();
            listView1.Update();
        }

    }

    //listview点击列表头排序
    public class ListViewColumnSorter : IComparer
    {
        private int ColumnToSort;
        private SortOrder OrderOfSort;
        private CaseInsensitiveComparer ObjectCompare;
        public ListViewColumnSorter()
        {
            ColumnToSort = 0;
            OrderOfSort = SortOrder.None;
            ObjectCompare = new CaseInsensitiveComparer();
        }
        private int comaretInt = 0;
        public int Compare(object x, object y)
        {
            int compareResult;
            ListViewItem listviewX, listviewY;
            listviewX = (ListViewItem)x;
            listviewY = (ListViewItem)y;
            if (int.TryParse(listviewX.SubItems[ColumnToSort].Text, out comaretInt) &&
               int.TryParse(listviewY.SubItems[ColumnToSort].Text, out comaretInt))
            {
                compareResult = int.Parse(listviewX.SubItems[ColumnToSort].Text).CompareTo(int.Parse(listviewY.SubItems[ColumnToSort].Text));
            }
            else
            {
                compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text, listviewY.SubItems[ColumnToSort].Text);
            }
            if (OrderOfSort == SortOrder.Ascending)
            {
                return compareResult;
            }
            else if (OrderOfSort == SortOrder.Descending)
            {
                return (-compareResult);
            }
            else
            {
                return 0;
            }
        }

        public int SortColumn
        {
            set
            {
                ColumnToSort = value;
            }
            get
            {
                return ColumnToSort;
            }
        }

        public SortOrder Order
        {
            set
            {
                OrderOfSort = value;
            }
            get
            {
                return OrderOfSort;
            }
        }

    }
}
