using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_BMS_Project.BL;
using GUI_BMS_Project.DL;

namespace GUI_BMS_Project
{
    public partial class CrudClientFrm : Form
    {
        public CrudClientFrm()
        {
            InitializeComponent();
            GridViewClient.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtAge.Text != "" && TxtName.Text != "")
            {
                string n = TxtName.Text;
                string cnic = TxtCNIC.Text;
                int age = int.Parse(TxtAge.Text);
                string Account_no = TxtAccount.Text;
                int initial = int.Parse(TxtBalance.Text);
                int dep = 0;
                string Nat = TxtNationality.Text;
                string Curr = TxtCurrency.Text;
                if (age > 18 && age < 60 && initial > 0)
                {
                    Admin AddClientObj = new Admin(n, cnic, age, Account_no, initial, dep, Nat, Curr);
                    AdminDL.addAdminUserIntoList(AddClientObj);
                    AdminDL.storeClientIntoFile();
                    MessageBox.Show("Added Successfully!!!");
                    GridViewClient.DataSource = null;
                    GridViewClient.DataSource = AdminDL.adminUserList;
                    GridViewClient.Refresh();
                }
                else
                {
                    MessageBox.Show("Age greater than 18 / Balance greater than 0 !!!");
                }
            }
            else
            {
                MessageBox.Show("Please Provide Information !!!");
            }
        }

        private void CrudClientFrm_Load(object sender, EventArgs e)
        {
            GridViewClient.DataSource = AdminDL.adminUserList;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (GridViewClient.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = GridViewClient.SelectedRows[0];

                // Retrieve the values from the selected row
                string Name = selectedRow.Cells["Name"].Value.ToString();
                string cnic = selectedRow.Cells["CNIC"].Value.ToString();
                int age = Convert.ToInt32(selectedRow.Cells["Age"].Value);
                string Acc_num = selectedRow.Cells["Accountno"].Value.ToString();
                int Acc_balance = Convert.ToInt32(selectedRow.Cells["AccBalance"].Value);
                string national = selectedRow.Cells["Nationality"].Value.ToString();
                string currency = selectedRow.Cells["Currency"].Value.ToString();

                // Update the text boxes with the retrieved values
                TxtName.Text = Name;
                TxtCNIC.Text = cnic;
                TxtAge.Text = age.ToString();
                TxtAccount.Text = Acc_num;
                TxtBalance.Text = Acc_balance.ToString();
                TxtNationality.Text = national;
                TxtCurrency.Text = currency;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Admin M = (Admin)GridViewClient.CurrentRow.DataBoundItem;
            AdminDL.adminUserList.Remove(M);
            AdminDL.storeClientIntoFile();
            GridViewClient.DataSource = null;
            GridViewClient.DataSource = AdminDL.adminUserList;
            GridViewClient.Refresh();
            MessageBox.Show("Deleted Successfully!!!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (GridViewClient.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = GridViewClient.SelectedRows[0];

                string n = TxtName.Text;
                string cnic = TxtCNIC.Text;
                int age = int.Parse(TxtAge.Text);
                string Account_no = TxtAccount.Text;
                int initial = int.Parse(TxtBalance.Text);
                int dep = 0;
                string Nat = TxtNationality.Text;
                string Curr = TxtCurrency.Text;

                if (age > 18 && age < 60 && initial > -1)
                {

                    selectedRow.Cells["Name"].Value = n;
                    selectedRow.Cells["CNIC"].Value = cnic;
                    selectedRow.Cells["Age"].Value = age;
                    selectedRow.Cells["Accountno"].Value = Account_no;
                    selectedRow.Cells["AccBalance"].Value = initial;
                    selectedRow.Cells["Nationality"].Value = Nat;
                    selectedRow.Cells["Currency"].Value = Curr;

                    MessageBox.Show("Updated Successfully !!!");

                    Admin adm = new Admin(n, cnic, age, Account_no, initial, dep, Nat, Curr);
                    //AdminDL.addAdminUserIntoList(adm);
                    AdminDL.storeClientIntoFile();
                }
                else
                {
                    MessageBox.Show("Age greater than 18 / Balance greater than 0 !!!");
                }

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            TxtName.Text = string.Empty;
            TxtCNIC.Text = string.Empty;
            TxtAge.Text = string.Empty;
            TxtAccount.Text = string.Empty;
            TxtBalance.Text = string.Empty;
            TxtNationality.Text = string.Empty;
            TxtCurrency.Text = string.Empty;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm af = new AdminForm();
            af.Show();
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
