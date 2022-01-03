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

namespace FlowDocument_01
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog pd = new PrintDialog();

            flowDocument.PageHeight = pd.PrintableAreaHeight;
            flowDocument.PageWidth = pd.PrintableAreaWidth;

            IDocumentPaginatorSource iDocument = flowDocument as IDocumentPaginatorSource;
            pd.PrintDocument(iDocument.DocumentPaginator, "Printing flow document...");

        }
    }
}
