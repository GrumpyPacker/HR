using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HR.UI
{
    public class ChoiceVm : INotifyPropertyChanged
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string Label { get; set; }
        public short SortOrder { get; set; } = 0;

        // When building list of choices, set this to true when you 
        // add the current value of the field.
        public bool IsSelected { get; set; } = false;

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged([CallerMemberName] string property = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
    }
}
