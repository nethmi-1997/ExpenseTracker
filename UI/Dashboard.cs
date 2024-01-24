﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensesTracker.UI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "Username : " + Models.Session.User.GetUsername();
            txtType.Text = "Type : " + Models.Session.User.GetUserType();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            new CategoryForm().Show();
        }

        private void btnBudgets_Click(object sender, EventArgs e)
        {
            new BudgetsForm().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
