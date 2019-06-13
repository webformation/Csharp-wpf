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

namespace Datagrid
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DataSet1.PersonDataTable tablePersonne { get; set; }
        public MainWindow()
        {
            tablePersonne = new DataSet1.PersonDataTable();
            DataSet1TableAdapters.PersonTableAdapter taPersonne = new DataSet1TableAdapters.PersonTableAdapter();
            taPersonne.Fill(tablePersonne);
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
