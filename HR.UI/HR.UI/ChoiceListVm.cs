using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HR.UI
{
    public class ChoiceListVm : INotifyPropertyChanged
    {
        public ChoiceListVm()
        {
            Choices = new List<ChoiceVm>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public List<ChoiceVm> Choices { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged([CallerMemberName] string property = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
    }
}
