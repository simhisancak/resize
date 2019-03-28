using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trestan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TCResize resizablePicture = new TCResize(this.pictureBox1);
            TCResize resizabletreeView = new TCResize(this.treeView1);
        }
    }
}
