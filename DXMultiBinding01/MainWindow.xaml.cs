using DevExpress.Xpf.Core;
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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var row = (Product)grid0.GetRow(0);
            row.IsMine = true;
            row.IsEmergency = true;
        }

        private void tblview0_CellValueChanging(object sender, DevExpress.Xpf.Grid.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "IsMine" || e.Column.FieldName == "IsEmergency" || e.Column.FieldName == "pCateIdx")
            {
                tblview0.CommitEditing();
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
