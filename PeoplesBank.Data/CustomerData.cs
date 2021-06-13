
using PeoplesBank.Data.Interfaces;
using PeoplesBank.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PeoplesBank.Data
{
    public class CustomerData: ICustomerDataHandler
    {
        public static string file = @"C:\Users\hp\source\mycustomers.txt";


        public void AddCustomer(Customer c)
        {
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                // creates an array of the user's values
                string[] values = { c.Id, c.FirstName, c.LastName, c.Email, c.DateCreated.ToString(), Convert.ToBase64String(c.PasswordHash), Convert.ToBase64String(c.PasswordSalt) };
                // creates a new line
                string line = string.Join(";", values);
                // writes the line
                sw.WriteLine(line);


                // flushes the buffer
                sw.Flush();
            }

        }
        public Customer GetCustomerById(string id)
        {
            Customer c = null;
            using (StreamReader sr = new StreamReader(file))
            {
                string s;
                // Reads it line by line
                while ((s = sr.ReadLine()) != null)
                {
                    // splits the string line using semicolons
                    string[] values = s.Split(';');
                    if (values[0] == id)
                    {
                        byte[] byte_array1 = Convert.FromBase64String(values[5]);
                        byte[] byte_array2 = Convert.FromBase64String(values[6]);
                        c = new Customer(values[0], values[1], values[2], values[3], DateTime.Parse(values[4]), byte_array1, byte_array2);

                    }

                    

                }
            }
            return c;
        }
        public Customer GetCustomerByEmail(string email)
        {
            Customer c = null;
            using (StreamReader sr = new StreamReader(file))
            {
                string s;
                // Reads it line by line
                while ((s = sr.ReadLine()) != null)
                {
                    // splits the string line using semicolons
                    string[] values = s.Split(';');
                    if (values[3] == email)
                    {
                        byte[] byte_array1 = Convert.FromBase64String(values[5]);
                        byte[] byte_array2 = Convert.FromBase64String(values[6]);
                        c = new Customer(values[0], values[1], values[2], values[3], DateTime.Parse(values[4]), byte_array1, byte_array2);

                    }
                }
            }
            return c;
        }
        public List<Customer> GetCustomers()
        {
            var customers = new List<Customer>();
            // Opens the file for reading
            using (StreamReader sr = new StreamReader(file))
            {
                string s;
                // Reads it line by line
                while ((s = sr.ReadLine()) != null)
                {
                    // splits the string line using semicolons
                    string[] values = s.Split(';');

                    byte[] byte_array1 = Convert.FromBase64String(values[5]);
                    byte[] byte_array2 = Convert.FromBase64String(values[6]);
                    Customer c = new Customer(values[0], values[1], values[2], values[3], DateTime.Parse(values[4]), byte_array1, byte_array2);

                    //AddModel(c);
                    customers.Add(c);
                }
            }
            return customers;
        }
    }
}
