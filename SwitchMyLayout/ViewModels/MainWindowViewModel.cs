using SwitchMyLayout.Models;
using SwitchMyLayout.Enums;
using System.Collections.ObjectModel;

namespace SwitchMyLayout.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        private string selectedConverterTypeName;

        public ObservableCollection<ConverterType> ConverterTypes { get; set; }

        private void InitConverterTypes()
        {
            if (ConverterTypes == null) return;

            ConverterTypes.Add(new ConverterType { LangName = LangName.EN, VisualName = "EN -> RU" });
            ConverterTypes.Add(new ConverterType { LangName = LangName.RU, VisualName = "RU -> EN" });
        }
        
        public MainWindowViewModel()
        {
            ConverterTypes = new ObservableCollection<ConverterType>();
            InitConverterTypes();
        }

        public string SelectedConverterTypeName
        {
            get { return selectedConverterTypeName; }
            set
            {
                selectedConverterTypeName = value;
                NotifyPropertyChanged("SelectedConverterTypeName");
            }
        }
    }
}
