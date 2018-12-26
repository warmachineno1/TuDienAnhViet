using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCK_TDN
{
    public partial class Music : Form
    {
        public Music()
        {
            InitializeComponent();
        }

        String[] fileNames, filePaths;
       

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileNames = openFileDialog1.SafeFileNames;
                filePaths = openFileDialog1.FileNames; 
                foreach(String fileName in fileNames)
                {
                    listBox1.Items.Add(fileName);
                }   
            }
        }               

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = filePaths[listBox1.SelectedIndex];
        }
    }
}
