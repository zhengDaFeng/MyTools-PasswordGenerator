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

namespace PasswordGenerator
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private static char[] _Digitals = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private static char[] _Uppercase = {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H',
            'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P',
            'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };
        private static char[] _Downcase = {
            'a', 'b', 'c', 'd', 'e','f', 'g', 'h',
            'i','j', 'k', 'l', 'm', 'n', 'o', 'p',
            'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };
        private static char[] _Special = { '`', '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '[', ']', ':', ';', '.', '?'};

        private string GeneratePassword(int length, bool isDig, bool isUp, bool isDown, bool isSpe)
        {
            List<char> charLib;
            string password;
            int index;
            Random r;

            charLib = new List<char>();
            if (isDig)
            {
                charLib.AddRange(_Digitals);
            }
            if (isUp)
            {
                charLib.AddRange(_Uppercase);
            }
            if (isDown)
            {
                charLib.AddRange(_Downcase);
            }
            if (isSpe)
            {
                charLib.AddRange(_Special);
            }

            Generate: password = "";
            r = new Random();
            index = 0;
            for (int i = 0; i < length; i++)
            {
                index = r.Next(0, charLib.Count() - 1);
                password += charLib[index];
            }

            if (password[0] == '-' || password[0] == '.')
            {
                goto Generate;
            }

            return password;
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            tbPassword.Text = GeneratePassword((int)sldLength.Value,
                (bool)cbDigital.IsChecked,
                (bool)cbUpper.IsChecked,
                (bool)cbDown.IsChecked,
                (bool)cbSpecial.IsChecked);
        }

        private void BtnCopy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetDataObject(tbPassword.Text);
        }
    }
}
