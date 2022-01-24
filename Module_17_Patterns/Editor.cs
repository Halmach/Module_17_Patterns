using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    /// <summary>
    /// Класс для работы с текстовым редактором
    /// </summary>
    class Editor
    {
        // Функция написания кода
        public void Write(string sourceCode)
        {
            Console.WriteLine($"Пишем код: {sourceCode}");
        }

        // Функция сохранения кода
        public void Save()
        {
            Console.WriteLine("Сохраняем код");
        }
    }
}
