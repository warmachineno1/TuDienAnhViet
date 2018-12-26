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
using SpeechLib;
using System.Net;
using System.IO;
using System.Globalization;

namespace DoAnCK_TDN
{
    public partial class MainApp : Form
    {
        int move;
        int moveX;
        int moveY;
        private List<string> Textvidu;
        public MainApp()
        {
            InitializeComponent();
            Textvidu = new List<string>();
            listBox1.Hide();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        

        private void LoadListBoxData()
        {
            try
            {
                // Lấy các items có trong database ra
                DataTable ds = SqlHelper.ExecuteDataset(SQLstring.strCon, "TuVung_Chon").Tables[0];
                // Đổ items ra listbox
                listBox1.DataSource = ds;
                listBox1.DisplayMember = "Từ_Tiếng_Anh";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
                
        public void button1_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();            
            Textvidu.Add(textBox1.Text);
            for (int i = Textvidu.Count - 1; i >= 0; i--)
            {
                listBox.Items.Add(Textvidu[i]);
            }

            try
            {
                string Eng = textBox1.Text.Trim();
                // Gía trị tìm đc sẽ chứa trong 1 table tạm để đưa ra textbox                
                DataTable ds = SqlHelper.ExecuteDataset(SQLstring.strCon, "TuVung_TraTu", Eng).Tables[0];
                // Kiểm tra từ này có tồn tại trong csdl chưa
                if (ds.Rows.Count > 0)
                {
                    textBox1.Text = ds.Rows[0]["Từ_Tiếng_Anh"].ToString();
                    NghiaLabel.Text = ds.Rows[0]["Dịch_Nghĩa_Chi_Tiết"].ToString();
                    DongNghiaLabel.Text = ds.Rows[0]["Từ_Đồng_Nghĩa"].ToString();
                    TraiNghiaLabel.Text = ds.Rows[0]["Từ_Trái_Nghĩa"].ToString();
                }
                else
                {
                    MessageBox.Show("Rất tiếc, từ bạn tra hiện không có !");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                LoadListBoxData();
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Biến temp tạm chứa các từ mà ng` dùng đang click vào
                string temp = listBox.Text;
                DataTable ds = SqlHelper.ExecuteDataset(SQLstring.strCon, "TuVung_ChonTuListbox", temp).Tables[0];
                textBox1.Text = listBox.Text;
                if (ds.Rows.Count > 0)
                {
                    NghiaLabel.Text = ds.Rows[0]["Dịch_Nghĩa_Chi_Tiết"].ToString();
                    DongNghiaLabel.Text = ds.Rows[0]["Từ_Đồng_Nghĩa"].ToString();
                    TraiNghiaLabel.Text = ds.Rows[0]["Từ_Trái_Nghĩa"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }                

        private void circleButton1_Click(object sender, EventArgs e)
        {
            SpVoice Speaker = new SpVoice();
            Speaker.Speak(textBox1.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            Management manager = new Management();
            WinAPI.AnimateWindow(manager.Handle, 500, WinAPI.VER_Positive);
            manager.Show();
        }

        private void MusicButton_Click(object sender, EventArgs e)
        {
            Music music = new Music();
            WinAPI.AnimateWindow(music.Handle, 2000, WinAPI.Hide);
            music.Show();
        }

        private void VideoButton_Click(object sender, EventArgs e)
        {
            Video video = new Video();
            WinAPI.AnimateWindow(video.Handle, 2000, WinAPI.Hide);
            video.Show();
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            radian1.Hide();
            timer1.Start();
        }

        int x = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            x++;
            if (x == 9)
            {
                timer1.Stop();
                pictureBox2.Hide();
                Loading.Hide();
                radian1.Show();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            textBox1.Text = textInfo.ToTitleCase(textBox1.Text);
            textBox1.SelectionStart = textBox1.Text.Length;
        }
    }
}
