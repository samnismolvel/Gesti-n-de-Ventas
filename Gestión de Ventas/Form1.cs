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
        bool sideBar = false;

        public MainForm()
        {
            InitializeComponent();
        }

        #region side menu
        private void MainForm_Load(object sender, EventArgs e)
        {
            OrdersSubMenu.Visible = false;
            ClientsSubMenu.Visible = false;
            SideMenuPanel.Width = SideMenuPanel.MinimumSize.Width;

            OrdersMenuBtn.FlatAppearance.BorderSize = 0;
            CompleteOrdersBtn.FlatAppearance.BorderSize = 0;
            IncompleteOrdersBtn.FlatAppearance.BorderSize = 0;
            ProvBtn.FlatAppearance.BorderSize = 0;
            ClientsBtn.FlatAppearance.BorderSize = 0;
            AllClientsBtn.FlatAppearance.BorderSize = 0;
            BlackListClientsBtn.FlatAppearance.BorderSize = 0;
            HistoryBtn.FlatAppearance.BorderSize = 0;
            StatsBtn.FlatAppearance.BorderSize = 0;

            OrdersMenuBtn.Text = "";
            ProvBtn.Text = "";
            ClientsBtn.Text = "";
            HistoryBtn.Text = "";
            StatsBtn.Text = "";
        }
        private void SideMenuBtn_Click(object sender, EventArgs e)
        {
            OrdersSubMenu.Visible = false; 
            ClientsSubMenu.Visible=false;
            timer1.Start();
            BtnTextRemove();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sideBar)
            {
                SideMenuPanel.Width -= 10;
                if (SideMenuPanel.Width == SideMenuPanel.MinimumSize.Width)
                {
                    sideBar = false;
                    timer1.Stop();
                }
            }
            else
            {
                SideMenuPanel.Width += 10;
                if (SideMenuPanel.Width == SideMenuPanel.MaximumSize.Width)
                {
                    sideBar = true;
                    timer1.Stop();
                }
            }
        }

        private void OrdersMenuBtn_Click_1(object sender, EventArgs e)
        {
            if (OrdersSubMenu.Visible) OrdersSubMenu.Visible = false;
            else OrdersSubMenu.Visible = true;
        }

        private void ClientsBtn_Click_1(object sender, EventArgs e)
        {

            if (ClientsSubMenu.Visible) ClientsSubMenu.Visible = false;
            else ClientsSubMenu.Visible = true;
        }

        private void BtnTextRemove()
        {
            if(SideMenuPanel.Width > 180)
            {
                OrdersMenuBtn.Text = "";
                ProvBtn.Text = "";
                ClientsBtn.Text = "";
                HistoryBtn.Text = "";
                StatsBtn.Text = "";
            }
            else
            {
                OrdersMenuBtn.Text = "            Pedidos";
                ProvBtn.Text = "            Proveedores";
                ClientsBtn.Text = "            Clientes";
                HistoryBtn.Text = "            Historial";
                StatsBtn.Text = "            Estadísticas";
            }
        }
        #endregion
        private Form activateForm = null;

        private void openChildForm(Form childForm)
        {
            if (activateForm != null)
                activateForm.Close();
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ChildFormPanel.Controls.Add(childForm);
            ChildFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void SideMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CompleteOrdersBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new CompleteOrdersForm());
        }

        private void NewOrderBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new NewOrderForm());
        }
    }
}
