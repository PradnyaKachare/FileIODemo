using System;
using System.IO;
using System.Windows.Forms;


namespace FileIODemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Cybage\test.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter br = new BinaryWriter(fs);
                br.Write(Convert.ToInt32(txtId.Text));
                br.Write(txtName.Text);
                br.Write(txtLocation.Text);
                br.Close();
                fs.Close();
                MessageBox.Show("data added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Cybage\test.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtId.Text = br.ReadInt32().ToString();
                txtName.Text = br.ReadString();
                txtLocation.Text = br.ReadString();
                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateDictionary_Click(object sender, EventArgs e)
        {
            string path = @"C:\Cybage";
            if (Directory.Exists(path))
            {
                MessageBox.Show("Directory is already exists");
            }
            else
            {
                Directory.CreateDirectory(path);
                MessageBox.Show("Created");
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string path = @"C:\Cybage\test.txt";
            if (File.Exists(path))
            {
                MessageBox.Show("File is alrady exists");
            }
            else
            {
                File.Create(path);
                MessageBox.Show("File Created");
            }
        }

        private void btnWriteStream_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Cybage\info.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(richTextBox1.Text);
                sw.Close();
                fs.Close();
                MessageBox.Show("Saved the data");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReadStream_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Cybage\info.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

       
