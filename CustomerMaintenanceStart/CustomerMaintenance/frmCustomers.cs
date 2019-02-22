using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomerMaintenanceClasses;

namespace CustomerMaintenance
{
    // This is the starting point for exercise 12-1 from
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        // Create List of Customer objects and initialize at null
        private List<Customer> customers = null;

        // Method to fill the customers list box
        private void FillCustomerListBox()
        {
            lstCustomers.Items.Clear();

            foreach (Customer c in customers)
            {
                lstCustomers.Items.Add(c.GetDisplayText() + "\t");
            }
        }
        // Form load event handler
        private void frmCustomers_Load(object sender, EventArgs e)
        {
            customers = CustomerDB.GetCustomers();
            FillCustomerListBox();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddCustomer newCustomerForm = new frmAddCustomer();
            Customer customer = newCustomerForm.GetNewCustomer();

            // if customer is not null
            //   add customer to customers list
            //   save customers list to CustomerDB
            //   fill customer list box
            if (customer != null)
            {
                customers.Add(customer);
                CustomerDB.SaveCustomers(customers);
                FillCustomerListBox();
            }
        }

        // Delete button click event handler
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstCustomers.SelectedIndex;

            // if index is not equal to -1
            //   determine customer indicated by index
            //   create message asking if user is sure to delete 
            //       indicated customer
            //   display message in dialog box with yes/no buttons
            //   if dialog box yes button is selected
            //       remove the indicated customer
            //       save updated customers list to CustomerDB
            //       fill customer list box
            if (index != -1)
            {
                Customer customer = customers[index];
                string message = "Are you sure you want to delete" +
                    customer.FirstName + " " + customer.LastName + "?";
                DialogResult dialog = MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);
                // nested if
                if (dialog == DialogResult.Yes)
                {
                    customers.Remove(customer);
                    CustomerDB.SaveCustomers(customers);
                    FillCustomerListBox();
                }
            }
        }
        // exit button click event handler
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}