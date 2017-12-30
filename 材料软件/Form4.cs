using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 材料软件
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lab1.Hide();
            la1.Hide();
            groupBox1.Hide();
            groupBox2.Hide();
            butno.Hide(); 
            butok.Hide();
            label1.Hide();
            textBox1.Hide();
            butinq.Hide();
            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Hide();
        }

        private void inquire1(int a)
        {
            lab1.Text = dataGridView1.Rows[a].Cells[1].Value.ToString();
            lab2.Text = dataGridView1.Rows[a].Cells[2].Value.ToString();
            lab3.Text = dataGridView1.Rows[a].Cells[3].Value.ToString();
            lab4.Text = dataGridView1.Rows[a].Cells[4].Value.ToString();
            lab5.Text = dataGridView1.Rows[a].Cells[5].Value.ToString();
            lab6.Text = dataGridView1.Rows[a].Cells[6].Value.ToString();
            lab7.Text = dataGridView1.Rows[a].Cells[7].Value.ToString();
            lab8.Text = dataGridView1.Rows[a].Cells[8].Value.ToString();
            lab9.Text = dataGridView1.Rows[a].Cells[9].Value.ToString();
            lab10.Text = dataGridView1.Rows[a].Cells[10].Value.ToString();
            lab11.Text = dataGridView1.Rows[a].Cells[11].Value.ToString();
            lab12.Text = dataGridView1.Rows[a].Cells[12].Value.ToString();
            lab13.Text = dataGridView1.Rows[a].Cells[13].Value.ToString();
            lab14.Text = dataGridView1.Rows[a].Cells[14].Value.ToString();
            lab15.Text = dataGridView1.Rows[a].Cells[15].Value.ToString();
            lab16.Text = dataGridView1.Rows[a].Cells[16].Value.ToString();
            lab17.Text = dataGridView1.Rows[a].Cells[17].Value.ToString();
            lab18.Text = dataGridView1.Rows[a].Cells[18].Value.ToString();
        }

        private void inquire2(int a)
        {

            lab1.Text = dataGridView2.Rows[a].Cells[1].Value.ToString();
            lab2.Text = dataGridView2.Rows[a].Cells[2].Value.ToString();
            lab3.Text = dataGridView2.Rows[a].Cells[3].Value.ToString();
            lab4.Text = dataGridView2.Rows[a].Cells[4].Value.ToString();
            lab5.Text = dataGridView2.Rows[a].Cells[5].Value.ToString();
            lab7.Text = dataGridView2.Rows[a].Cells[6].Value.ToString();
            lab8.Text = dataGridView2.Rows[a].Cells[7].Value.ToString();
            lab10.Text = dataGridView2.Rows[a].Cells[8].Value.ToString();
            lab9.Text = dataGridView2.Rows[a].Cells[9].Value.ToString();
            lab12.Text = dataGridView2.Rows[a].Cells[10].Value.ToString();
            lab13.Text = dataGridView2.Rows[a].Cells[11].Value.ToString();
            lab14.Text = dataGridView2.Rows[a].Cells[12].Value.ToString();
            lab15.Text = dataGridView2.Rows[a].Cells[13].Value.ToString();

        }

        private void inquire3(int a)
        {
            lab1.Text = dataGridView3.Rows[a].Cells[1].Value.ToString();
            lab2.Text = dataGridView3.Rows[a].Cells[2].Value.ToString();
            lab3.Text = dataGridView3.Rows[a].Cells[3].Value.ToString();
            lab4.Text = dataGridView3.Rows[a].Cells[4].Value.ToString();
            lab5.Text = dataGridView3.Rows[a].Cells[5].Value.ToString();
            lab7.Text = dataGridView3.Rows[a].Cells[8].Value.ToString();
            lab8.Text = dataGridView3.Rows[a].Cells[9].Value.ToString();
            lab10.Text = dataGridView3.Rows[a].Cells[10].Value.ToString();
            lab9.Text = dataGridView3.Rows[a].Cells[11].Value.ToString();
            lab12.Text = dataGridView3.Rows[a].Cells[12].Value.ToString();
            lab13.Text = dataGridView3.Rows[a].Cells[13].Value.ToString();
            lab14.Text = dataGridView3.Rows[a].Cells[14].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            inquire1(a);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = dataGridView2.CurrentRow.Index;
            inquire2(a);
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = dataGridView3.CurrentRow.Index;
            inquire3(a);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            if(comboBox1.SelectedIndex == 0)
            {
                lab5.Left = 80;
                groupBox1.Height = 135;
                pictureBox1.Height = 145;
                pictureBox1.Top = 288;
                la2.Text = "b/mm";
                la3.Text = "d/mm";
                la4.Text = "r/mm";
                la5.Text = "S(截)/cm^2";
                la6.Text = "S(外)/cm^2";
                la7.Text = "Ix/cm^4";
                la8.Text = "ix/cm";
                la9.Text = "Ix0/cm^4";
                la10.Text = "ix0/cm";
                la11.Text = "Ix1/cm^4";
                la12.Text = "iy0/cm";
                la13.Text = "Iy0/cm^4";
                la14.Text = "Wx/cm^3";
                la15.Text = "m/(kg/m)";
                la16.Text = "Wx0/cm^3";
                la17.Text = "Z0/cm";
                la18.Text = "Wy0/cm^3";
                la13.Show();
                la15.Show();
                la16.Show();
                la17.Show();
                la18.Show();
                lab11.Show();
                lab6.Show();
                lab18.Show();
                lab16.Show();
                lab17.Show();
                lab1.Show();
                la1.Show();
                groupBox1.Show();
                groupBox2.Show();
                butno.Show();
                butok.Show();
                label1.Show();
                textBox1.Show();
                butinq.Show();
                dataGridView1.Show();
                dataGridView2.Hide();
                dataGridView3.Hide();
                Image image1 = Resource1._3;
                pictureBox1.Image =image1;
                this.db1TableAdapter.Fill(this.db1DataSet.db1);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                lab5.Left = 40;
                groupBox1.Height = 95;
                pictureBox1.Height = 195;
                pictureBox1.Top = 245;
                la2.Text = "h/mm";
                la3.Text = "b/mm";
                la4.Text = "d/mm";
                la5.Text = "t/mm";
                la6.Text = "S(截)/cm^2";
                la7.Text = "Ix/cm^4";
                la9.Text = "Iy/cm^4";
                la11.Text = "Iy1/cm^4";
                la8.Text = "ix/cm";
                la10.Text = "iy/cm";
                la12.Text = "Wx/cm^3";
                la14.Text = "Wy/cm^3";
                la13.Hide();
                la15.Hide();
                la16.Hide();
                la17.Hide();
                la18.Hide();
                lab11.Hide();
                lab6.Hide();
                lab18.Hide();
                lab16.Hide();
                lab17.Hide();
                lab1.Show();
                la1.Show();
                groupBox1.Show();
                groupBox2.Show();
                butno.Show();
                butok.Show();
                label1.Show();
                textBox1.Show();
                butinq.Show();
                dataGridView1.Hide();
                dataGridView2.Show();
                dataGridView3.Hide();
                Image image2 = Resource1._5;
                pictureBox1.Image = image2;
                this.db2TableAdapter.Fill(this.db2DataSet.db2);

            }
            if (comboBox1.SelectedIndex == 2)
            {
                lab5.Left = 40;
                groupBox1.Height = 75;
                pictureBox1.Height = 215;
                pictureBox1.Top = 225;
                la2.Text = "h/mm";
                la3.Text = "b/mm";
                la4.Text = "d/mm";
                la5.Text = "t/mm";
                la6.Text = "S(截)/cm^2";
                la7.Text = "Ix/cm^4";
                la9.Text = "Iy/cm^4";
                la11.Text = "ix/cm";
                la8.Text = "iy/cm";
                la10.Text = "Wx/cm^3";
                la12.Text = "Wy/cm^3";
                la13.Hide();
                la14.Hide();
                la15.Hide();
                la16.Hide();
                la17.Hide();
                la18.Hide();
                lab11.Hide();
                lab6.Hide();
                lab15.Hide();
                lab16.Hide();
                lab17.Hide();
                lab18.Hide();
                lab1.Show();
                la1.Show();
                groupBox1.Show();
                groupBox2.Show();
                butno.Show();
                butok.Show();
                label1.Show();
                textBox1.Show();
                butinq.Show();
                dataGridView1.Hide();
                dataGridView2.Hide();
                dataGridView3.Show();
                Image image3 = Resource1._4;
                pictureBox1.Image = image3;
                this.db3TableAdapter.Fill(this.db3DataSet.db3);
            }
        }

        private void butno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butok_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {
                A.Iz = Convert.ToDouble(dataGridView1.CurrentRow.Cells[8].Value);
                A.Wz = Convert.ToDouble(dataGridView1.CurrentRow.Cells[15].Value);

            }
            if (comboBox1.SelectedIndex == 1)
            {
                A.Iz = Convert.ToDouble(dataGridView2.CurrentRow.Cells[7].Value);
                A.Wz = Convert.ToDouble(dataGridView2.CurrentRow.Cells[12].Value);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                A.Iz = Convert.ToDouble(dataGridView3.CurrentRow.Cells[10].Value);
                A.Wz = Convert.ToDouble(dataGridView3.CurrentRow.Cells[14].Value);
            }
            this.Close();
        }

        private void butinq_Click(object sender, EventArgs e)
        {
            bool flag = false;
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        if (textBox1.Text.Trim() != "")
                        {
                            for (int i = 0; i < dataGridView1.RowCount; i++)
                            {
                                if (dataGridView1.Rows[i].Cells[1].Value.ToString().Trim() == textBox1.Text.Trim())
                                {
                                    dataGridView1.Rows[i].Selected = true;
                                    inquire1(i);
                                    flag = true;
                                    break;
                                }
                            }
                            if (flag == false)
                            {
                                textBox1.Text = "";
                                MessageBox.Show("对不起，没有查询到！");
                            }
                        }
                        else
                        {
                            textBox1.Text = "";
                            MessageBox.Show("请输入型号后查询！");
                        }
                        break;
                    }
                case 1:
                    {
                        if (textBox1.Text.Trim() != "")
                        {
                            for (int i = 0; i < dataGridView2.RowCount; i++)
                            {
                                if (dataGridView2.Rows[i].Cells[1].Value.ToString().Trim() == textBox1.Text.Trim())
                                {
                                    dataGridView2.Rows[i].Selected = true;
                                    inquire2(i);
                                    flag = true;
                                    break;
                                }
                            }
                            if (flag == false)
                            {
                                textBox1.Text = "";
                                MessageBox.Show("对不起，没有查询到！");
                            }
                        }
                        else
                        {
                            textBox1.Text = "";
                            MessageBox.Show("请输入型号后查询！");
                        }
                        break;
                    }
                case 2:
                    {
                        if (textBox1.Text.Trim() != "")
                        {
                            for (int i = 0; i < dataGridView3.RowCount; i++)
                            {
                                if (dataGridView3.Rows[i].Cells[1].Value.ToString().Trim() == textBox1.Text.Trim())
                                {
                                    dataGridView3.Rows[i].Selected = true;
                                    inquire3(i);
                                    flag = true;
                                    break;
                                }
                            }
                            if (flag == false)
                            {
                                textBox1.Text = "";
                                MessageBox.Show("对不起，没有查询到！");
                            }
                        }
                        else
                        {
                            textBox1.Text = "";
                            MessageBox.Show("请输入型号后查询！");
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            
        }


    }
    public class A
    {
        public static double Iz = 0;
        public static double Wz = 0;
    }
}
