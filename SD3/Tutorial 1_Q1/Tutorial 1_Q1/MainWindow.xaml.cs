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

namespace Tutorial_1_Q1
{
    //Craig McMillan 19/09/2012 
    /*1. Implement the BlackBall / WhiteBall game discussed in the lecture.
     Ensure that you are using Polymorphic programming and that you fully understand where you are using it.*/
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_run_Click(object sender, RoutedEventArgs e)
        {
            WhiteBall whiteBall = new WhiteBall("WhiteBall"); //set up ball objects
            BlackBall blackBall = new BlackBall("BlackBall");
            Ball winner = new Ball();

            Random rand = new Random();//get a random number
            int random = rand.Next(0, 11);

            if (random <= 5) { winner = whiteBall; }//see which ball wins
            if (random >= 6) { winner = blackBall; }

            MessageBox.Show(random.ToString());//display winner
            MessageBox.Show(winner.getName());
        }
    }
}
