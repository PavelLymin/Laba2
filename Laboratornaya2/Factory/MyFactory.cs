using System;
using System.Globalization;
using System.IO;
using System.Linq;


namespace Factory
{
    public class MyFactory
    {
        public static string[] splitTextToLine(string text)
        {
            return text.Trim().Split('\n');
        }

        public static string readFromFile(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не найден.");
                return string.Empty;
            }
            else
                return File.ReadAllText(path);
        }

        public static DateTime parseDate(string text)
        {
            if (!DateTime.TryParseExact(text, "yyyy.MM.dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var tempDate))
                throw new Exception("Неверный формат даты");

            return DateTime.ParseExact(text, "yyyy.MM.dd", CultureInfo.InvariantCulture);
        }

        public static int parseInt(string text)
        {
            if (!int.TryParse(text, out var tempInt))
                throw new Exception("Неверный формат числа");
            return int.Parse(text);
        }

        public static double parseDouble(string text)
        {
            if (!double.TryParse(text, out var tempDouble))
                throw new Exception("Неверный формат числа с плавающей точкой");
            return double.Parse(text);
        }

        public static bool ChechQuoteIndex(string text)
        {
            int firstQuoteIndex = text.IndexOf('"');
            int lastQuoteIndex = text.LastIndexOf('"');
            if ((firstQuoteIndex != -1 || lastQuoteIndex != -1) && (lastQuoteIndex - firstQuoteIndex) > 1)
                return true;
            return false;
        }

        public static bool CheckType(string text)
        {
            if (text == "ЧастныйЖилДом" || text == "ДачныйДом" || text == "Новостройка")
                return true;
            return false;
        }

        public static PrivateResidentBuilding CreatePrivateResidentBuilding(string text)
        {
            if (!ChechQuoteIndex(text))
                throw new Exception("Строка не содержит имени");


            string name = text.Substring(text.IndexOf('"') + 1, text.LastIndexOf('"') - text.IndexOf('"') - 1).Trim();
            string[] otherPart = text.Substring(text.LastIndexOf('"') + 1).Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (otherPart.Length < 2)
                throw new Exception("Недостаточно данных для создания PrivateResidentBuilding");

            return new PrivateResidentBuilding(name, parseDate(otherPart[0]), parseInt(otherPart[1]));
        }

        public static Realty CreateCountryHouse(string text)
        {
            if (!ChechQuoteIndex(text))
                throw new Exception("Строка не содержит имени");

            string name = text.Substring(text.IndexOf('"') + 1, text.LastIndexOf('"') - text.IndexOf('"') - 1).Trim();
            string[] otherPart = text.Substring(text.LastIndexOf('"') + 1).Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (otherPart.Length < 3)
                throw new Exception("Недостаточно данных для создания CountryHouse");

            return new CountryHouse(name, parseDate(otherPart[0]), parseInt(otherPart[1]), parseDouble(otherPart[2]));
        }

        public static Realty CreateApartmentBuilding(string text)
        {
            if (!ChechQuoteIndex(text))
                throw new Exception("Строка не содержит имени");

            string name = text.Substring(text.IndexOf('"') + 1, text.LastIndexOf('"') - text.IndexOf('"') - 1).Trim();
            string[] otherPart = text.Substring(text.LastIndexOf('"') + 1).Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (otherPart.Length < 3)
                throw new Exception("Недостаточно данных для создания ApartmentBuilding");

            return new ApartmentBuilding(name, parseDate(otherPart[0]), parseInt(otherPart[1]), parseInt(otherPart[2]));
        }

        public static Realty createRealty(string text)
        {
            string type = text.Split(' ').FirstOrDefault();
            if (!CheckType(type))
                throw new Exception("Такого типа нет!");

            switch (type)
            {
                case "ЧастныйЖилДом":
                    return CreatePrivateResidentBuilding(text);
                case "ДачныйДом":
                    return CreateCountryHouse(text);
                case "Новостройка":
                    return CreateApartmentBuilding(text);
                default:
                    throw new Exception("Не удалось создать экзепляр объекта");
            }
        }
    }
}
