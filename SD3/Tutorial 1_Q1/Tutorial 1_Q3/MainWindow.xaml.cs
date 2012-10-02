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

namespace Tutorial_1_Q3
{
    //Craig McMillan 19/09/2012
    /* 3. Implement your solution to question 3 using interfaces rather than abstract methods.*/
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_run_Click(object sender, RoutedEventArgs e)
        {
            Student s1 = new Student("Craig", "Kings Road", "19");
            Staff staff1 = new Staff();
            Student s2 = new Student("Mark", "Tranent", "20");

            s1.printDetails(); s2.printDetails(); s1.updateDetails(); s1.printDetails();
            
        }
    }
}
