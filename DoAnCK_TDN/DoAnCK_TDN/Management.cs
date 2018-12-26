using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ApplicationBlocks.Data;
using System.Globalization;


namespace DoAnCK_TDN
{
    public partial class Management : Form
    {
        int move;
        int moveX;
        int moveY;
        public Management()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            SaveAddButton.Hide();
            SaveEditButton.Hide();
            CancelAddButton.Hide();
            CancelEditButton.Hide();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RefreshApp();
        }

        private void RefreshApp()
        {
            dataGridView1.DataSource = SqlHelper.ExecuteDataset(SQLstring.strCon, "TuVung_Chon").Tables[0];
        }
               

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == textBox1.Text)
            {
                MessageBox.Show("Không thể thêm vì từ đã tồn tại !", "Error!!!");
            }
            else try
            {
                if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
                {
                    MessageBox.Show("Chưa có từ!");
                }
                else
                {
                    string Eng = textBox1.Text.Trim();
                    string Detail = textBox2.Text.Trim();
                    string Synonym = textBox3.Text.Trim();
                    string Antonym = textBox4.Text.Trim();

                    SqlHelper.ExecuteNonQuery(SQLstring.strCon, "TuVung_Them", Eng, Detail, Synonym, Antonym);
                    MessageBox.Show("Thêm Thành Công !");
                    RefreshApp();

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                    SaveAddButton.Hide();
                    CancelAddButton.Hide();


                    AddButton.Show();
                    EditButton.Show();
                    DeleteButton.Show();
                    ShowAllButton.Show();
            }

        }

        int index;
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Bạn có muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                try
                {
                    string Eng = textBox1.Text.Trim();
                    SqlHelper.ExecuteNonQuery(SQLstring.strCon, "TuVung_Xoa", Eng);
                    MessageBox.Show("Xóa Thành Công !");
                    RefreshApp();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Eng = textBox1.Text.Trim();
                string Detail = textBox2.Text.Trim();
                string Synonym = textBox3.Text.Trim();
                string Antonym = textBox4.Text.Trim();

                SqlHelper.ExecuteNonQuery(SQLstring.strCon, "TuVung_Sua", Eng, Detail, Synonym, Antonym);
                MessageBox.Show("Sửa Thành Công !");
                RefreshApp();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SaveAddButton.Hide();
                CancelAddButton.Hide();


                AddButton.Show();
                EditButton.Show();
                DeleteButton.Show();
                ShowAllButton.Show();
            }
        }
        
        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            Vocabulary Voca = new Vocabulary();
            Voca.Show();
            //animator1.ShowSync(Voca);
            Voca.FormClosed += Voca_FormClosed;
        }

        private void Voca_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshApp();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            textBox1.Text = textInfo.ToTitleCase(textBox1.Text);
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {            
            SaveAddButton.Show();
            CancelAddButton.Show();

            SaveEditButton.Hide();
            AddButton.Hide();
            EditButton.Hide();
            CancelEditButton.Hide();
            DeleteButton.Hide();
            ShowAllButton.Hide();
        }

        private void CancelAddButton_Click(object sender, EventArgs e)
        {
            SaveAddButton.Hide();
            CancelAddButton.Hide();


            AddButton.Show();
            EditButton.Show();
            DeleteButton.Show();
            ShowAllButton.Show();
        }

        private void CancelEditButton_Click(object sender, EventArgs e)
        {
            SaveEditButton.Hide();
            CancelEditButton.Hide();

            AddButton.Show();
            EditButton.Show();
            DeleteButton.Show();
            ShowAllButton.Show();
        }

        private void EditButton_Click_1(object sender, EventArgs e)
        {
            SaveEditButton.Show();
            CancelEditButton.Show();

            AddButton.Hide();
            EditButton.Hide();
            CancelAddButton.Hide();
            DeleteButton.Hide();
            ShowAllButton.Hide();
        }

        private void AddButton_MouseHover(object sender, EventArgs e)
        {
            AddButton.BackColor = Color.DodgerBlue;
            AddButton.ForeColor = Color.White;
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.BackColor = Color.Transparent;
            AddButton.ForeColor = Color.Black;
        }

        private void EditButton_MouseHover(object sender, EventArgs e)
        {
            EditButton.BackColor = Color.Green;
            EditButton.ForeColor = Color.White;
        }

        private void EditButton_MouseLeave(object sender, EventArgs e)
        {
            EditButton.BackColor = Color.Transparent;
            EditButton.ForeColor = Color.Black;
        }

        private void DeleteButton_MouseHover(object sender, EventArgs e)
        {
            DeleteButton.BackColor = Color.Red;
            DeleteButton.ForeColor = Color.White;
        }

        private void DeleteButton_MouseLeave(object sender, EventArgs e)
        {
            DeleteButton.BackColor = Color.Transparent;
            DeleteButton.ForeColor = Color.Black;
        }

        private void ShowAllButton_MouseHover(object sender, EventArgs e)
        {
            ShowAllButton.BackColor = Color.DarkMagenta;
            ShowAllButton.ForeColor = Color.White;
        }

        private void ShowAllButton_MouseLeave(object sender, EventArgs e)
        {
            ShowAllButton.BackColor = Color.Transparent;
            ShowAllButton.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();            
        }        

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }
    }
}
