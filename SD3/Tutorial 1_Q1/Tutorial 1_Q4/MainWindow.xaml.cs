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

namespace Tutorial_1_Q5
{
   //Craig McMillan 20/09/2012
    //5. Implement that a lecture has many students, use polymorhic programming, write a small programm to show it working
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_run_Click(object sender, RoutedEventArgs e)
        {
            UnderGrad u1 = new UnderGrad("Craig", "10004794", "3"); UnderGrad u2 = new UnderGrad("Scott", "10004794", "6"); UnderGrad u3 = new UnderGrad("Leigh", "10004794", "1"); UnderGrad u4 = new UnderGrad("Chris", "10004794", "8");
            PostGrad p1 = new PostGrad("Mark", "10004767", "3");
            Lecturer l1 = new Lecturer("Kevin", "Games Enginnering");

            l1.Teaches(u1); l1.Teaches(p1); l1.Teaches(u2); l1.Teaches(u3); l1.Teaches(u4);
            l1.update();

           ;
        }
    }
}
