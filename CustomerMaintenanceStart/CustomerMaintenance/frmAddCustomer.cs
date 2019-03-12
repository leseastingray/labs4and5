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

    public partial class frmAddCustomer : Form
    {

        public frmAddCustomer()
        {
            InitializeComponent();
        }

        // Create a Customer class variable initialized as null
        private Customer customer = null;
        
        // Method displaying form as dialog box, returns Customer object
        public Customer GetNewCustomer()
        {
            this.ShowDialog();
            return customer;
        }
        
        // Validator method
        private bool IsValidData()
        {
            return Validator.IsPresent(txtFirstName) &&
                    Validator.IsPresent(txtLastName) &&
                    Validator.IsPresent(txtEmail) &&
                    Validator.IsValidEmail(txtEmail);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // if IsValidData returns true
            //   create new Customer from user textbox input
            //   close the form
            if (IsValidData())
            {
                customer = new Customer(txtFirstName.Text, txtLastName.Text, txtEmail.Text);
                this.Close();
            }
        }

        // Cancel button click event handler
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }
    
    }
}