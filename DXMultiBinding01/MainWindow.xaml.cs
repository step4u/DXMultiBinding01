using DevExpress.Xpf.Core;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Editors.Settings;
using DevExpress.Xpf.Grid;
using System.Windows;

namespace DXMultiBinding01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // tblview0.BestFitColumns();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var row = (Product)grid0.GetRow(0);
            row.IsMine = true;
            row.IsEmergency = true;
        }

        private void tblview0_CellValueChanging(object sender, DevExpress.Xpf.Grid.CellValueChangedEventArgs e)
        {
            var view = (TableView)e.OriginalSource;
            if (e.Column.FieldName == "IsMine" || e.Column.FieldName == "IsEmergency")
            {
                tblview0.CommitEditing();
                System.Diagnostics.Debug.WriteLine($"tblview0_CellValueChanging => {e.Value}");
            }
            else if (e.Column.FieldName == "pCateIdx")
            {
                tblview0.CommitEditing();
                System.Diagnostics.Debug.WriteLine($"tblview0_CellValueChanging => {e.Value}");
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
