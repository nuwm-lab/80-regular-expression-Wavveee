using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        // 1. Заданий вхідний текст
        string inputText = "Проєкт стартував 05/03/2023 і завершився 15-09-2024. Наступна зустріч: 01/01/2025. Проміжний звіт від 31-12-2023.";

        // 2. Регулярний вираз для обох форматів: dd/mm/yyyy або dd-mm-yyyy
        // Пояснення:
        // \d{2}   - дві цифри (для дня або місяця)
        // ([-/])  - захоплення тире (-) або слеша (/) як роздільника
        // \d{4}   - чотири цифри (для року)
        string pattern = @"\d{2}[-/]\d{2}[-/]\d{4}";

        // 3. Створення об'єкта Regex
        Regex dateRegex = new Regex(pattern);

        // 4. Пошук усіх збігів (дат)
        MatchCollection matches = dateRegex.Matches(inputText);

        // 5. Виведення результату
        Console.WriteLine($"Оригінальний текст: {inputText}\n");
        Console.WriteLine("Знайдені дати:");
        Console.WriteLine("---");

        if (matches.Count > 0)
        {
            foreach (Match match in matches)
            {
                // match.Value містить повний текст знайденого збігу (дату)
                Console.WriteLine($"- {match.Value}");
            }
        }
        else
        {
            Console.WriteLine("Дати у вказаних форматах не знайдено.");
        }
    }
}