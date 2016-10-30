using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KraftLib;
using System.Net;
using System.IO;

namespace KraftLibDemo
{
    public partial class Form1 : Form
    {
        public Converters c = new Converters();
        public Generators g = new Generators();
        public Network n = new Network();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] nbytes = c.GetBytesFromStr("hello");
            MessageBox.Show(c.GetStrFromBytes(nbytes));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.safeWinName("MO<*TN^GTq#$%:>?ew?ew||@#_.eASD tgerh4"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] nbytes = c.GetBytesFromStr("hello");
            MessageBox.Show(c.GetStrFromBytes(nbytes));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }

        private void button5_Click(object sender, EventArgs e)
        {
            n.downloadToDesktop("https://www.google.com/search?site=&source=hp&q=c%23+download+file+progress+bar+winform&oq=c%23+&gs_l=hp.3.0.35i39k1l2j0l3j0i20k1j0l4.520.1416.0.2735.4.4.0.0.0.0.293.799.0j2j2.4.0....0...1c.1.64.hp..0.3.560.0..0i131k1j0i131i46k1j46i131k1.53Lq4fG7Qzs", "file.html");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> networked = n.getNetworkNames();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            n.sendPostData("http://127.0.0.1/csharptest/index.php", "filename=myfilew45");
        }
    }
}
