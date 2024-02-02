using Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C_.NET
{
    public partial class Form1 : Form
    {

        
        private List<Customer> customers;
        List<Customer> useList = new List<Customer>();

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idTextBox.Text);
            string name = nameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            int age = int.Parse(ageTextBox.Text);
            string description = descriptionTextBox.Text;

            Customer newCustomer = new Customer(id, name, lastName, age, description);
            customers.Add(newCustomer);
            listBoxCustomers.Items.Add(newCustomer); // Customer nesnesini listBox'a ekleyin
        }




        public Form1()
        {
            InitializeComponent();
            customers = new List<Customer>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }



        private void button3_Click(object sender, EventArgs e)
        {
            // Tüm müşterileri döngü kullanarak işle
            foreach (Customer customer in useList)
            {
                Console.WriteLine($"Customer ID: {customer.Id}");
                Console.WriteLine($"Name: {customer.Name} {customer.LastName}");
                Console.WriteLine($"Age: {customer.Age}");
                Console.WriteLine($"Description: {customer.Description}");
                Console.WriteLine();
            }
        }

        private void listBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçili müşteriyi göster
            if (listBoxCustomers.SelectedIndex != -1)
            {
                Customer selectedCustomer = (Customer)listBoxCustomers.SelectedItem;
                MessageBox.Show($"Customer ID: {selectedCustomer.Id}\nName: {selectedCustomer.Name} {selectedCustomer.LastName}\nAge: {selectedCustomer.Age}\nDescription: {selectedCustomer.Description}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idTextBox.Text);
            string name = nameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            int age = int.Parse(ageTextBox.Text);
            string description = descriptionTextBox.Text;

            Customer newCustomer = new Customer(id, name, lastName, age, description);
            customers.Add(newCustomer);
            listBoxCustomers.Items.Add(newCustomer); // Customer nesnesini listBox'a ekleyin
        }
    }
}

