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

namespace Observer_example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_run_Click(object sender, RoutedEventArgs e)
        {
            Lecturer john = new Lecturer();
            Student s1 = new Student("Craig");
            Student s2 = new Student("Mark");

            john.registerObservers(s1);
            john.registerObservers(s2);

            john.setNews("Free beer on Wednesday at 4:00");
            john.notiffyObservers();

            john.removeObservers(s2);

            john.setNews("Beer cancelled");
            john.notiffyObservers();
        }
    }
}
