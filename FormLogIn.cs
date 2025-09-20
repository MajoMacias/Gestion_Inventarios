using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Inventario
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void linkLabelRecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void CenterLoginBox()
        {
            groupBox1.Location = new Point(
                (this.Width - groupBox1.Width) / 2,
                (this.Height - groupBox1.Height) / 2
            );
        }
        private void groupBox1_Resize(object sender, EventArgs e)
        {
            CenterLoginBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterLoginBox();
        }
    }
}
