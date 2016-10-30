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

namespace KraftLibDemo
{
    public partial class Form1 : Form
    {
        public Converters c = new Converters();
        public Generators g = new Generators();

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
            MessageBox.Show(g.safeWinName("MO<*TN^GTq#$%:>?ew?ew||@#_.eASD tgerh4"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] nbytes = c.GetBytesFromStr("hello");
            MessageBox.Show(c.GetStrFromBytes(nbytes));
        }
    }
}
