using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Yahtzee
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

        private void BtnRoll_Click(object sender, RoutedEventArgs e)
        {
            lblDie1.Content = Dice.Die1();
            lblDie2.Content = Dice.Die2();
            lblDie3.Content = Dice.Die3();
            lblDie4.Content = Dice.Die4();
            lblDie5.Content = Dice.Die5();




        }
    }
}
