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

namespace ClickRender
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

        private void buttonOK(object sender, RoutedEventArgs e)
        {
            //OKボタンを押したら最小化
            WindowState = WindowState.Minimized;
        }

        private void buttonExit(object sender, RoutedEventArgs e)
        {
            //Exitボタンを押したら終了
            Application.Current.Shutdown();
        }
    }
}
