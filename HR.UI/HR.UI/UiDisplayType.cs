
namespace HR.UI
{
    public static class UiDisplayType
    {
        public enum UiDisplayTypes
        {
            Radio = 1,
            RadioFieldWidth = 2,
            RadioVertical = 3
        }

        public static UiDisplayTypes GetRadioUiDisplayType()
        {
            return UiDisplayTypes.Radio;
        }

        public static UiDisplayTypes GetRadioFieldWidthUiDisplayType()
        {
            return UiDisplayTypes.RadioFieldWidth;
        }

        public static UiDisplayTypes GetRadioVerticalUiDisplayType()
        {
            return UiDisplayTypes.RadioVertical;
        }
    }
}
