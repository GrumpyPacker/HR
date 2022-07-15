using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace HR.UI
{
    internal static class MockData
    {
        public static MainPageVm GetMockMainPage()
        {
            MainPageVm mainPageVm = new MainPageVm()
            {
                Fields = GetMockFields()
            };

            return mainPageVm;
        }

        private static ObservableCollection<FieldVm> GetMockFields()
        {
            ObservableCollection<FieldVm> fields = new ObservableCollection<FieldVm>();
            fields.Add(GetMockRadio(UiDisplayType.GetRadioUiDisplayType(), "Standard Radio"));
            fields.Add(GetMockRadio(UiDisplayType.GetRadioFieldWidthUiDisplayType(), "Radio Width Request"));
            fields.Add(GetMockRadio(UiDisplayType.GetRadioVerticalUiDisplayType(), "Radio Displayed Vertically"));
            return fields;
        }

        private static FieldVm GetMockRadio(UiDisplayType.UiDisplayTypes radioUiType, string title)
        {
            FieldVm field = new FieldVm()
            {
                Id = 1,
                SortOrder = 1,
                Code = "F001",
                Title = title,
                DisplayType = radioUiType,
                IsEnabled = true,
                IsReadOnly = false,
                ChoiceList = new ChoiceListVm()
                {
                    Id = 1,
                    Code = "CL001",
                    Title = "Radio Choices",
                    Choices = GetSampleChoices()
                }
            };

            return field;
        }

        private static List<ChoiceVm> GetSampleChoices()
        {
            List<ChoiceVm> choices = new List<ChoiceVm>();
            choices.Add(new ChoiceVm
            {
                Code = "C001",
                Value = "1",
                Label = "Not Selected",
                IsSelected = true,
                SortOrder = 1
            });

            choices.Add(new ChoiceVm
            {
                Code = "C002",
                Value = "2",
                Label = "Minutes",
                SortOrder = 2
            });

            choices.Add(new ChoiceVm
            {
                Code = "C003",
                Value = "3",
                Label = "Hours",
                SortOrder = 3
            });

            choices.Add(new ChoiceVm
            {
                Code = "C004",
                Value = "4",
                Label = "Days",
                SortOrder = 4
            });

            choices.Add(new ChoiceVm
            {
                Code = "C005",
                Value = "5",
                Label = "Weeks",
                SortOrder = 5
            });

            return choices;
        }
    }
}
