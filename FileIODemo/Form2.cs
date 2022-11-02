using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Text.Json;


using System.Windows.Forms;

namespace FileIODemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBinarWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.Id = Convert.ToInt32(txtId.Text);
                employee.Name = txtName.Text;
                employee.Salary = Convert.ToInt32(txtSalary.Text);
                //.dat --> data file  / binary file
                FileStream fs = new FileStream(@"c:\Cybage\emp.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, employee);
                fs.Close();
                MessageBox.Show("Binary data saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnBinaryRead_Click_1(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                FileStream fs = new FileStream(@"c:\Cybage\emp.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                employee = (Employee)binary.Deserialize(fs);
                txtId.Text = employee.Id.ToString();
                txtSalary.Text = employee.Salary.ToString();
                txtName.Text = employee.Name;
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        //  Implement SOAP Serialization
        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.Id = Convert.ToInt32(txtId.Text);
                employee.Name = txtName.Text;
                employee.Salary = Convert.ToInt32(txtSalary.Text);
                //.dat --> data file  / binary file
                FileStream fs = new FileStream(@"c:\Cybage\emp.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter binary = new SoapFormatter();
                binary.Serialize(fs, employee);
                fs.Close();
                MessageBox.Show("SOAP data saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSoapRread_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();

                FileStream fs = new FileStream(@"c:\Cybage\emp.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter binary = new SoapFormatter();
                employee = (Employee)binary.Deserialize(fs);
                txtId.Text = employee.Id.ToString();
                txtSalary.Text = employee.Salary.ToString();
                txtName.Text = employee.Name;
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.Id = Convert.ToInt32(txtId.Text);
                employee.Name = txtName.Text;
                employee.Salary = Convert.ToInt32(txtSalary.Text);
                //.dat --> data file  / binary file
                FileStream fs = new FileStream(@"c:\Cybage\emp.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Employee));
                xml.Serialize(fs, employee);
                fs.Close();
                MessageBox.Show("data saved");
            }           

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();

                FileStream fs = new FileStream(@"c:\Cybage\emp.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Employee));
                employee = (Employee)xml.Deserialize(fs);
                txtId.Text = employee.Id.ToString();
                txtSalary.Text = employee.Salary.ToString();
                txtName.Text = employee.Name;
                fs.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.Id = Convert.ToInt32(txtId.Text);
                employee.Name = txtName.Text;
                employee.Salary = Convert.ToInt32(txtSalary.Text);
                //.dat --> data file  / binary file
                FileStream fs = new FileStream(@"c:\Cybage\emp.json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize<Employee>(fs, employee);
                fs.Close();
                MessageBox.Show("data saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnJSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();

                FileStream fs = new FileStream(@"c:\Cybage\emp.json", FileMode.Open, FileAccess.Read);

                employee = JsonSerializer.Deserialize<Employee>(fs);
                txtId.Text = employee.Id.ToString();
                txtSalary.Text = employee.Salary.ToString();
                txtName.Text = employee.Name;
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

