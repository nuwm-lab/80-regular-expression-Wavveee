using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        // 1. Заданий вхідний текст
        string inputText = "Цей текст містить літери «о». Додаткові слова: молоко, сонце, олівець.";

        // 2. Визначення регулярного виразу
        // Шаблон "(о)" знаходить літеру "о" (як велику, так і малу)
        // Завдяки опції RegexOptions.IgnoreCase ми не розрізняємо регістр.
        string pattern = "(о)"; 
        
        // 3. Визначення рядка заміни
        // "$0" представляє **увесь знайдений збіг** (тобто літеру "о" або "О").
        // Ми вставляємо "ОК" після неї.
        string replacement = "$0ОК";

        // 4. Виконання заміни за допомогою класу Regex
        string resultText = Regex.Replace(
            inputText, 
            pattern, 
            replacement, 
            RegexOptions.IgnoreCase // Ігноруємо регістр, щоб замінювати як 'о', так і 'О'
        );

        // 5. Виведення результату
        Console.WriteLine($"Оригінальний текст: {inputText}");
        Console.WriteLine($"---");
        Console.WriteLine($"Результат заміни:   {resultText}");
    }
}
