using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SfAutoComplete_DataTemplateSelector
{
    public class MobileDetailViewModel
    {
        public ObservableCollection<MobileDetail> MobileCollection { get; set; }
        public MobileDetailViewModel()
        {
            this.MobileCollection = new ObservableCollection<MobileDetail>()
            {
                new MobileDetail () { Mobile="Samasung S8", IsAvaiableInStock=false },
                new MobileDetail () { Mobile="Samasung S9", IsAvaiableInStock=true },
                new MobileDetail () { Mobile="Samsung S10", IsAvaiableInStock=true },
                new MobileDetail () { Mobile="Samsung S10 plus", IsAvaiableInStock=true },
                new MobileDetail () { Mobile="iPhone 7", IsAvaiableInStock=true },
                new MobileDetail () { Mobile="iPhone 8", IsAvaiableInStock=true },
                new MobileDetail () { Mobile="iPhone X", IsAvaiableInStock=false },
                new MobileDetail () { Mobile="iPhone XR", IsAvaiableInStock=false },
                new MobileDetail () { Mobile="iPhone XS", IsAvaiableInStock=true },
            };
        }
    }
    public class DataTemplateSelectorViewModel : DataTemplateSelector
    {
        public DataTemplate DefaultTemplate { get; set; }
        public DataTemplate SpecificDataTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var message = item as MobileDetail;
            if (message.IsAvaiableInStock == null)
                return null;
            return message.IsAvaiableInStock == false ? SpecificDataTemplate : DefaultTemplate;
        }

    }
}