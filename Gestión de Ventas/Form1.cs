using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_de_Ventas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (OrdersSubMenu.Visible) OrdersSubMenu.Visible = false;
            else OrdersSubMenu.Visible = true;
        }
      

        private void ClientsBtn_Click(object sender, EventArgs e)
        {
            if (ClientsSubMenu.Visible) ClientsSubMenu.Visible = false;
            else ClientsSubMenu.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OrdersSubMenu.Visible = false;
            ClientsSubMenu.Visible = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

      

        private void SideMenuBtn_Click(object sender, EventArgs e)
        {

        }

        private void SideMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
