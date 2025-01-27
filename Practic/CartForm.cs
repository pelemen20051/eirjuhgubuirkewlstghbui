﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Practic
{
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();
            LoadCart();
        }
        private void LoadCart()
        {
            listBoxCart.Items.Clear();
            foreach (string item in CatalogForm.Cart)
            {
                listBoxCart.Items.Add(item);
            }
        }

        private void buttonProceed_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
