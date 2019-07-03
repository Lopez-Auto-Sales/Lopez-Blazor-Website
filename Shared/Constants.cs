﻿namespace LopezBlazorWebsite.Shared
{
    public enum SortMethod
    {
        HighestPrice = 0,
        LowestPrice = 1,
        HighestMileage = 2,
        LowestMileage = 3
    };

    internal static class Constants
    {
        internal const string JsonPath = "https://raw.githubusercontent.com/lopezautosales/LopezCars/master/Data/cars.json";
        internal const string imgPrepend = "https://github.com/lopezautosales/LopezCars/blob/master/CarImages/";
        internal const string imgAppend = ".jpg?raw=true";
    }
}
