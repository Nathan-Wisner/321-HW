using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            string url = this.URLBox.Text;
            URLDownloader downloader = new URLDownloader(url);
            this.URLResult.Text = downloader.getURLString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sorting sorting = new Sorting();
            TimeSpan span = sorting.executeOneThread();
            singleThreadLabel.Text = "Single-thread time: " + span.Milliseconds.ToString() + "ms";
            span = sorting.executeAsNoraml();
            normalTime.Text = "Multi-threaded time: " + span.Milliseconds.ToString() + "ms";
        }

        private void URLBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
