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

namespace BitmapSepia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public ushort NumberOfThreads { get; }

        private ushort _numberOfThreadsPicked;
        public ushort NumberOfThreadsPicked
        {
            get { return _numberOfThreadsPicked;  }
            set
            {
                if (value == _numberOfThreadsPicked)
                    return;
                _numberOfThreadsPicked = value;
                OnPropertyChanged("NumberOfThreadsPicked");
            }
        }



        public MainWindow()
        {
            NumberOfThreadsPicked = NumberOfThreads = 12;
            InitializeComponent();
            this.DataContext = this;
        }

        

        private void Button_ChooseFile_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("NOT YET IMPLEMENTED");
        }



        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
