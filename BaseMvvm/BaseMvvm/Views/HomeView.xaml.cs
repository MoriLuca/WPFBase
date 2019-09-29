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

namespace BaseMvvm.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class HomeView : Window
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void CheckForEnter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                if (ChangeTitle.Command.CanExecute(this)) ChangeTitle.Command.Execute(this);

            if (e.Key == Key.Escape)
                NewTitle.Text = "";

            if (e.Key == Key.U && (Keyboard.Modifiers == ModifierKeys.Control))
                NewTitle.Text = NewTitle.Text.ToUpper();

            if (e.Key == Key.L && (Keyboard.Modifiers == ModifierKeys.Control))
                NewTitle.Text = NewTitle.Text.ToLower();
        }
    }
}
