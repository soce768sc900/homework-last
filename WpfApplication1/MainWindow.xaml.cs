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

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

      public int CA
        {
            get
            {
                try
                {
                    return int.Parse(CACACA.Text);
                }

                catch
                {
                    MessageBox.Show("卡洛里要輸入數字喔!!");
                    return 0;
                }
                }
            set
            {
                CACACA.Text = value.ToString();
            }
        }

      public string FU
        {
            get
            {
                return Food.Text;
            }
            set
            {
                Food.Text = value.ToString();
            }
        }

       

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {

                int a = 0;
                int b = int.Parse(gogle.Text);
                a += CA;
                Totle.Text = a.ToString();
                if (b <a)
                {
                    MessageBox.Show(FU.ToString() + "" + CA.ToString() + "你要減肥囉");
                }
                else
                {
                    MessageBox.Show(FU + " " + CA + "繼續保持,好身材會是你的");
                }
            }
        }
    }
}
