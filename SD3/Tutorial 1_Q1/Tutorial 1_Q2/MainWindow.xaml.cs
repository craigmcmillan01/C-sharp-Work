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

namespace Tutorial_1_Q2
{
    //Craig McMillan 19/09/2012
    /* 2. Implement a Person, Staff, Student hierarchy with the class Person as an abstract class.
          Use abstract methods to force concrete implementation of essential methods.    
          Write a small program to demonstrate your class working.
    */
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_run_Click(object sender, RoutedEventArgs e)
        {
            Student s1 = new Student("Craig", "Kings Road", "19");
            Staff staff1 = new Staff("Mark", "Tranent", "20");
            Student s2 = new Student();

            s1.Update();
            s2.Update();
            s1.UpdateDetails();
         
           
            
        }
    }
}
