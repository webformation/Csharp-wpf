using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfBinding
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string _txt;
        public String txtAccueil
        {
            get
            {
                return _txt;
            }
            set
            {
                _txt = value;
                OnPropertyChanged("txtAccueil");
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            txtAccueil = "Bonne journée";
            this.DataContext = this;
        }


        private void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtAccueil = "Bravo ! Vous avez cliqué";
        }
    }
}
