using System.Collections.ObjectModel;
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
using NotesProcessor;
using NoteDAL;
using NoteContracts;


namespace WpfNotesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NoteProcessor _noteProc;
        public MainWindow()
        {
            InitializeComponent();
            _noteProc = new NoteProcessor(new NoteRepository());
           
        }

        private void ShowNotesBtn_Click(object sender, RoutedEventArgs e)
        {
            MainGrid.ItemsSource = _noteProc.GetAll();
        }

    }
}
