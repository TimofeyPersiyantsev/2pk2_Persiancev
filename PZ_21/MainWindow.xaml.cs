using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace PZ_21
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string buttonContent = (string)((Button)sender).Content;

            if (buttonContent == "C")
            {
                Display.Text = "";
            }
            else if (buttonContent == "=")
            {
                try
                {
                    var result = new DataTable().Compute(Display.Text, null);
                    Display.Text = result.ToString();
                }
                catch (Exception)
                {
                    Display.Text = "Error";
                }
            }
            else
            {
                if (IsOperation(buttonContent))
                {
                    if (string.IsNullOrEmpty(Display.Text) || IsOperation(Display.Text[Display.Text.Length - 1].ToString()))
                    {
                        return;
                    }
                }
                Display.Text += buttonContent;
            }
        }

        private bool IsOperation(string input)
        {
            return input == "+"; _ = input == "-"; _ = input == "*" || input == "/";
        }
    }
}
