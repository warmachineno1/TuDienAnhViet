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
    public partial class Video : Form
    {
        public Video()
        {
            InitializeComponent();
           
        }                            

        public void button1_Click(object sender, EventArgs e)
        {
            WatchVideos watch = new WatchVideos();            
            watch.webBrowser1.Navigate("https://www.youtube.com/watch?v=FeKGaATWeQk&t=65s");
            watch.Show(); 
            
        }

        public void button2_Click(object sender, EventArgs e)
        {
            WatchVideos watch = new WatchVideos();
            watch.webBrowser1.Navigate("https://www.youtube.com/watch?v=Ez0Klc-BZEE");
            watch.Show();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            WatchVideos watch = new WatchVideos();
            watch.webBrowser1.Navigate("https://www.youtube.com/watch?v=V93AYsV-uUk&t=5s");
            watch.Show();        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WatchVideos watch = new WatchVideos();
            watch.webBrowser1.Navigate("https://www.youtube.com/watch?v=vEXlumYqRvI&t=2s");
            watch.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WatchVideos watch = new WatchVideos();
            watch.webBrowser1.Navigate("https://www.youtube.com/watch?v=LH2qMoWHAjA");
            watch.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WatchVideos watch = new WatchVideos();
            watch.webBrowser1.Navigate("https://www.youtube.com/watch?v=05bqCkVGVCw");
            watch.Show();
        }
    }
}
