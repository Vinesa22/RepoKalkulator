﻿using System;
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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        float a, b, c;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            text1.Text += "1";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            text1.Text += "2";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            text1.Text += "3";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            text1.Text += "4";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            text1.Text += "5";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            text1.Text += "6";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            text1.Text += "7";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            text1.Text += "8";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            text1.Text += "9";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            if (text1.Text == "")
            {

            }
            if (text1.Text != "")
            {
                b =int.Parse(text1.Text);
            c = a + b;
            text1.Text = c.ToString();
                ravnoplus.Visibility = Visibility.Collapsed;
                ravnomin.Visibility = Visibility.Collapsed;
                ravnoumn.Visibility = Visibility.Collapsed;
                ravnodel.Visibility = Visibility.Collapsed;
            }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            if (text1.Text == "")
            {

            }
            if (text1.Text != "")
            {
                b = int.Parse(text1.Text);
                c = a - b;
                text1.Text = c.ToString();
                ravnoplus.Visibility = Visibility.Collapsed;
                ravnomin.Visibility = Visibility.Collapsed;
                ravnoumn.Visibility = Visibility.Collapsed;
                ravnodel.Visibility = Visibility.Collapsed;
            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            ravnoplus.Visibility = Visibility.Collapsed;
            ravnomin.Visibility = Visibility.Visible;
            ravnoumn.Visibility = Visibility.Collapsed;
            ravnodel.Visibility = Visibility.Collapsed;

            a = int.Parse(text1.Text);
            text1.Text = "";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            ravnoplus.Visibility = Visibility.Collapsed;
            ravnomin.Visibility = Visibility.Collapsed;
            ravnoumn.Visibility = Visibility.Visible;
            ravnodel.Visibility = Visibility.Collapsed;
            a = int.Parse(text1.Text);
            text1.Text = "";
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            ravnoplus.Visibility = Visibility.Collapsed;
            ravnomin.Visibility = Visibility.Collapsed;
            ravnoumn.Visibility = Visibility.Collapsed;
            ravnodel.Visibility = Visibility.Visible;
            a = int.Parse(text1.Text);
            text1.Text = "";
        }

        private void ravnodel_Click(object sender, RoutedEventArgs e)
        {
            if (text1.Text == "")
            {

            }
            if (text1.Text != "")
            {
                b = int.Parse(text1.Text);
                c = a / b;
                text1.Text = c.ToString();
                ravnoplus.Visibility = Visibility.Collapsed;
                ravnomin.Visibility = Visibility.Collapsed;
                ravnoumn.Visibility = Visibility.Collapsed;
                ravnodel.Visibility = Visibility.Collapsed;
            }
        }

        private void ravnoumn_Click(object sender, RoutedEventArgs e)
        {
            if (text1.Text == "")
            {

            }
            if (text1.Text != "")
            {
                b = int.Parse(text1.Text);
                c = a * b;
                text1.Text = c.ToString();
                ravnoplus.Visibility = Visibility.Collapsed;
                ravnomin.Visibility = Visibility.Collapsed;
                ravnoumn.Visibility = Visibility.Collapsed;
                ravnodel.Visibility = Visibility.Collapsed;
            }
        }

        private void Sbros_Click(object sender, RoutedEventArgs e)
        {
            a = 0;
            b = 0;
            c = 0;
            text1.Text = "";
            ravnoplus.Visibility = Visibility.Collapsed;
            ravnomin.Visibility = Visibility.Collapsed;
            ravnoumn.Visibility = Visibility.Collapsed;
            ravnodel.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            text1.Text += "0";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            ravnoplus.Visibility = Visibility.Visible;
            ravnomin.Visibility = Visibility.Collapsed;
            ravnoumn.Visibility=Visibility.Collapsed;
            ravnodel.Visibility=Visibility.Collapsed;
            a=int.Parse(text1.Text);
            text1.Text = "";
            
        }
    }
}
