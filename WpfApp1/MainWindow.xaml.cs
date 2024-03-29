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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public class Login
        {
            public bool CallLoginProcess(string id, string pwd)
            {
                //로그인 프로세스 동작후 로그인 성공 반환
                return true;
            }
        }

        public class Calculator
        {
            public int Add(int number1, int number2)
            {
                return number1 + number2;
            }
            public int Sub(int number1, int number2)
            {
                return number1 - number2;
            }
        }
    }
}
