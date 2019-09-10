using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringToHex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] ba = Encoding.Default.GetBytes(tbStringValue.Text);
            var hexString = BitConverter.ToString(ba);
            hexString = hexString.Replace("-", "");
            var reversedString = new String(hexString.Reverse().ToArray());
            tbHexValue.Text = hexString;
            tbReversed.Text = reversedString;
        }
    }
}
