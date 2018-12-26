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

namespace DoAnCK_TDN
{
    public partial class Vocabulary : Form
    {
        int move;
        int moveX;
        int moveY;
        public Vocabulary()
        {            
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;            
            RefreshApp();
            this.dataGridView1.Sort(this.dataGridView1.Columns["Từ_Tiếng_Anh"], ListSortDirection.Ascending);
        }

        private void RefreshApp()
        {
            dataGridView1.DataSource = SqlHelper.ExecuteDataset(SQLstring.strCon, "TuVung_Chon ").Tables[0];
        }

        private void EditVoca_Click(object sender, EventArgs e)
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
        }

        
        
        private void DeleteVoca_Click(object sender, EventArgs e)
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
        int index;
        private void dataGridView1_Click_1(object sender, EventArgs e)
        {

            index = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Radian1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void Radian1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void Radian1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }
    }
}
