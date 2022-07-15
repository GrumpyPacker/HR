using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HR.UI
{
    public class MainPageVm : INotifyPropertyChanged
    {
        public MainPageVm()
        {
            _fields = new ObservableCollection<FieldVm>();
        }

        private ObservableCollection<FieldVm> _fields;
        public ObservableCollection<FieldVm> Fields
        {
            get { return _fields; }
            set
            {
                _fields = value;
                RaisePropertyChanged(nameof(Fields));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged([CallerMemberName] string property = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
    }
}
