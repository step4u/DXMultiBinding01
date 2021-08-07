using DevExpress.Mvvm;
using System.Collections.Generic;
using System.ComponentModel;

namespace DXMultiBinding01
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            Products = new BindingList<Product>();
            // Products.ListChanged += Products_ListChanged;

            Products.Add(new Product() { IsEmergency = false, IsMine = false, pCateIdx = 0, pId = "1", pName = "제품명1" });
            Products.Add(new Product() { IsEmergency = false, IsMine = false, pCateIdx = 2, pId = "2", pName = "제품명2" });
            Products.Add(new Product() { IsEmergency = true, IsMine = true, pCateIdx = 0, pId = "3", pName = "제품명3" });
            Products.Add(new Product() { IsEmergency = false, IsMine = false, pCateIdx = 3, pId = "4", pName = "제품명4" });
            Products.Add(new Product() { IsEmergency = false, IsMine = false, pCateIdx = 4, pId = "5", pName = "제품명5" });
            Products.Add(new Product() { IsEmergency = true, IsMine = false, pCateIdx = 3, pId = "6", pName = "제품명6" });
            Products.Add(new Product() { IsEmergency = false, IsMine = true, pCateIdx = 2, pId = "7", pName = "제품명7" });
        }

        private void Products_ListChanged(object sender, ListChangedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(">>>>>>>>>> Products_ListChanged is raised.");
        }

        public BindingList<Product> Products { get; set; }
    }
}
