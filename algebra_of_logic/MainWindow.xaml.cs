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

namespace algebra_of_logic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// (a v -b) x -(avc)
        /// (av-b)x-(avc)
        /// abcdefg
        /// not and or xor imp equ
        /// notadrximpequ adbcdefg 0123456789 ()
        /// </summary>
        /// 

        string _text;
        int _count = 0;
        bool _tooltip = true;
        int _click = 1;

        public MainWindow()
        {
            InitializeComponent();
            Title = "Алгебра логики";
        }

        private void Show_Tip(string ToolTipMessage)
        {
            if (ToolTip_L == null) { return; }
            if (_tooltip == false) { return; }

            Width = 1000;
            MaxWidth = 1000;
            MinWidth = 1000;

            ToolTip_L.Content = ToolTipMessage + "\n\nНажмите 2 раза на ПКМ в любой области, чтобы включить/выключить подсказки";
        }

        private void Close_Tip()
        {
            if (ToolTip_L == null) { return; }
            if(_tooltip == false) { return; }

            Width = 800;
            MaxWidth = 800;
            MinWidth = 800;

            ToolTip_L.Content = "";
        }

        private void Window_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (_click % 2 == 0)
            {
                Close_Tip();
                _tooltip = !_tooltip;
                _click = 1;
            }
            else _click += 1;

        }

        private void Main_TB_TextChanged(object sender, TextChangedEventArgs e)
        {
            ///notadrximpequ adbcdefg 0123456789 ()
            ///-^vV>=

            Close_Tip();

            if (_count > 0) 
            {
                Show_Tip("Введите сначало количество переменных, в поле в верхнем правом углу");
                return;
            }

            for (int i = 0; i < Main_TB.Text.ToString().Length; i++)
            {
                var temp = Main_TB.Text.ToString()[i];

            }

            _text = Main_TB.Text.ToString();
            return;
        }

        private void Count_TB_TextChanged(object sender, TextChangedEventArgs e)
        {
            Close_Tip();

            if (Count_TB.Text.ToString() == "_")
            {
                _count = 0;
                return;
            }
            if (int.TryParse(Count_TB.Text.ToString(), out _))
            {
                _count = int.Parse(Count_TB.Text.ToString());
                return;
            }
        }

        private void Count_TB_MouseEnter(object sender, MouseEventArgs e)
        {
            Show_Tip("Количество переменых, введите число");


        }

        private void Count_TB_MouseLeave(object sender, MouseEventArgs e)
        {
            Close_Tip();


        }

        private void Main_TB_MouseEnter(object sender, MouseEventArgs e)
        {
            Show_Tip("Поле для ввода формулы алгебры логики, используйте переменные a,b,c,... в зависимости от введеного числа количества переменных" +
                "в поле в верхнем правом углу" +
                "\nотрицание - -\nумножение - &\nсложение - V\nследование - >\nэквивалентность - =");
        }

        private void Main_TB_MouseLeave(object sender, MouseEventArgs e)
        {
            Close_Tip();
        }

        private void BruteForce_DG_MouseEnter(object sender, MouseEventArgs e)
        {
            Show_Tip("Таблица перебора переменых");
        }

        private void BruteForce_DG_MouseLeave(object sender, MouseEventArgs e)
        {
            Close_Tip();
        }

        private void Final_DG_MouseEnter(object sender, MouseEventArgs e)
        {
            Show_Tip("Таблица решения логического выражения");
        }

        private void Final_DG_MouseLeave(object sender, MouseEventArgs e)
        {
            Close_Tip();
        }
    }
}
