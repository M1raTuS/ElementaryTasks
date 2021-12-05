﻿namespace NumberToString
{
    class Words
    {
        public static string[][] numbers =
        {
            new string [] { "","сто ",   "двести ",  "триста ",  "четыреста ","пятьсот ",  "шестьсот ",  "семьсот ", "восемьсот ",  "девятьсот " },
            new string [] { "","десять ","двадцать ","тридцать ","сорок ",    "пятьдесят ","шестьдесят ","семьдесят ","восемьдесят ","девяносто " },
            new string [] { "","один ",  "два ",     "три ",     "четыре ",   "пять ",     "шесть ",     "семь ",    "восемь ",     "девять " },
            new string [] { "десять ","одиннадцать ","двенадцать ","тринадцать ","четырнадцать ","пятнадцать ","шестнадцать ","семнадцать ","восемнадцать ","девятнадцать " }
        };

        public static string[] classes = new string[] { "", "тысяч", "миллион", "миллиард", "триллион", "квадриллион", "квинтиллион" };

        public static string[][] ending =
        {
            new string[] { "а", "и", "" },
            new string[] { "", "а", "ов" }
        };
    }
}
