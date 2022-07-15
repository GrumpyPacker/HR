using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HR.UI
{
    public class FieldVm : INotifyPropertyChanged
    {
        public FieldVm()
        {
            _choiceList = new ChoiceListVm();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public string PlaceholderText { get; set; }
        public int SortOrder { get; set; }
        public UiDisplayType.UiDisplayTypes DisplayType { get; set; }
        public bool IsReadOnly { get; set; }
        public bool IsEnabled { get; set; }

        private string _value;
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                RaisePropertyChanged();
            }
        }

        private ChoiceListVm _choiceList;
        public ChoiceListVm ChoiceList
        {
            get
            {
                return _choiceList;
            }
            set
            {
                _choiceList = value;
                RaisePropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged([CallerMemberName] string property = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
    }
}
