using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practicle_1_01
{
    /// <summary>
    /// Software Engineering practicle_1_01 
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            int age = 0;
            string text = txtAge.Text;
            bool isValid = true;

            if (txtName.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Please Complete missing fields");
                isValid = false;
            }
            else if (int.TryParse(text, out age))
            {
                if (txtAge.Text == "" || age < 0 || age > 100)
                {
                    MessageBox.Show("please enter an age between 1 - 100");
                    isValid = false;
                }
            }
            else { MessageBox.Show("Please enter a number"); isValid = false; }


            if (isValid == true)
            {
                //A string of data
                string line1 = txtName.Text;
                string line2 = txtAddress.Text;
                string line3 = txtAge.Text;
                string line4 = "Name: " + line1 + Environment.NewLine + "Age: " + line3 + "\n" + " Address: " + line2 + "\n";
                //write the string to a file
                System.IO.StreamWriter file = new System.IO.StreamWriter("E:\\test.txt", true);
                file.WriteLine(line4);
                file.Close();
                MessageBox.Show("file succesfully saved");

            }
            else MessageBox.Show("unable to save file");
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtName.Clear();
            txtAddress.Clear();
            txtAge.Clear();
             
        }        
    }
}
//CRAIG, check the task list works.
