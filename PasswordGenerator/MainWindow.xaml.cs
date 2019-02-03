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

        /// <summary>
        /// 数字
        /// </summary>
        private static char[] _Digital = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        /// <summary>
        /// 大写字母
        /// </summary>
        private static char[] _Uppercase = {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H',
            'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P',
            'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };
        /// <summary>
        /// 小写字母
        /// </summary>
        private static char[] _Lowercase = {
            'a', 'b', 'c', 'd', 'e','f', 'g', 'h',
            'i','j', 'k', 'l', 'm', 'n', 'o', 'p',
            'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };
        /// <summary>
        /// 特殊字符
        /// </summary>
        private static char[] _Special = {
            '`', '~', '!', '@', '#', '$', '%', '^',
            '&', '*', '(', ')', '-', '_', '=', '+',
            '[', ']', ':', ';', '.', '?'
        };

        /// <summary>
        /// 生成字符库
        /// </summary>
        /// <param name="isDigital">字符库是否加入数字</param>
        /// <param name="isUpper">字符库是否加入大写字母</param>
        /// <param name="isLower">字符库是否加入小写字母</param>
        /// <param name="isSpecial">字符库是否加入特殊字符</param>
        /// <returns></returns>
        private List<char> GenerateCharList(
            bool isDigital, 
            bool isUpper, 
            bool isLower, 
            bool isSpecial)
        {
            List<char> list = new List<char>();

            if (isDigital) list.AddRange(_Digital);
            if (isUpper) list.AddRange(_Uppercase);
            if (isLower) list.AddRange(_Lowercase);
            if (isSpecial) list.AddRange(_Special);

            return list;
        }

        /// <summary>
        /// 使用指定字符库生成指定长度的密码
        /// </summary>
        /// <param name="length">密码长度</param>
        /// <param name="isDigital">密码是否包含数字</param>
        /// <param name="isUpper">密码是否包含大写字母</param>
        /// <param name="isLower">密码是否包含小写字母</param>
        /// <param name="isSpecial">密码是否包含特殊字符</param>
        /// <returns></returns>
        private string GeneratePassword(
            int length,
            bool isDigital,
            bool isUpper,
            bool isLower,
            bool isSpecial)
        {
            List<char> list;
            string password;
            int index;
            Random r;

            // 生成指定字符库
            list = GenerateCharList(isDigital, isUpper, isLower, isSpecial);

            // 使用指定字符库生成指定长度的密码
            Generate: password = "";
            r = new Random();
            index = 0;
            for (int i = 0; i < length; i++)
            {
                index = r.Next(0, list.Count() - 1);
                password += list[index];
            }

            // 假如密码的第一位是“-”或者“.”，则重新生成密码
            if (password[0] == '-' || password[0] == '.')
            {
                goto Generate;
            }

            return password;
        }

        #region UI Event

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

        #endregion
    }
}
