using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clipboard_Language_Exchange
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string html = Properties.Resources.Help;
            webBrowser1.DocumentText = html;
        }
    }
}
