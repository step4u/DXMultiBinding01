using DevExpress.Mvvm;
using System.Collections.Generic;

namespace DXMultiBinding01
{
    public class Product : ViewModelBase
    {
        public Product()
        {
            pCates = new Dictionary<int, string>();
            for(int i = 0; i < 5; i++)
            {
                pCates.Add(i, $"카테고리{i+1}");
            }
        }

        public bool IsMine
        {
            get { return GetValue<bool>(); }
            set
            {
                SetValue(value);

                System.Diagnostics.Debug.WriteLine(">>>>>>>>>> Product => IsMine is checked.");
            }
        }

        public bool IsEmergency
        {
            get { return GetValue<bool>(); }
            set
            {
                SetValue(value);

                System.Diagnostics.Debug.WriteLine(">>>>>>>>>> Product => IsEmergency is checked.");
            }
        }

        public string pId
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string pName
        {
            get { return GetValue<string>(); }
            set
            {
                SetValue(value);

                System.Diagnostics.Debug.WriteLine($">>>>>>>>>> Product => pName: {pName}");
            }
        }

        public Dictionary<int, string> pCates { get; set; }
        public int pCateIdx
        {
            get { return GetValue<int>(); }
            set
            {
                SetValue(value);

                System.Diagnostics.Debug.WriteLine($">>>>>>>>>> Product => pName: {pCates[pCateIdx]}");
            }
        }
    }
}
