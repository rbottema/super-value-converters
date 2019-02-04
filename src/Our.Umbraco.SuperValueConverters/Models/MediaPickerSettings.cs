﻿using Our.Umbraco.SuperValueConverters.Attributes;

namespace Our.Umbraco.SuperValueConverters.Models
{
    public class MediaPickerSettings : IPickerSettings
    {
        [PreValueProperty("onlyImages")]
        [MediaPickerAllowedDoctypesFilter]
        public string[] AllowedDoctypes { get; set; }

        [PreValueProperty("multiPicker")]
        [MediaPickerMaxItemsFilter]
        public int MaxItems { get; set; }

        public bool AllowsMultiple()
        {
            return MaxItems == 0 || MaxItems > 1;
        }
    }
}