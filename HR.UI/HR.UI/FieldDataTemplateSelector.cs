using System;
using Xamarin.Forms;

namespace HR.UI
{
    public class FieldDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate RadioTemplateNoWidthRequest { get; set; }
        public DataTemplate RadioTemplateWidthRequest { get; set; }
        public DataTemplate RadioTemplateVertical { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            FieldVm field = item as FieldVm;
            switch (field?.DisplayType)
            {
                case UiDisplayType.UiDisplayTypes.Radio:
                    return RadioTemplateNoWidthRequest;
                case UiDisplayType.UiDisplayTypes.RadioFieldWidth:
                    return RadioTemplateWidthRequest;
                case UiDisplayType.UiDisplayTypes.RadioVertical:
                    return RadioTemplateVertical;
                default:
                    throw new ArgumentException("Invalid UI display type.");
            };
        }
    }
}
