using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    /// <summary>
    /// Представляет компонент самого низкого уровня
    /// Который не может содержать подкомпонентов
    /// </summary>
    class File: Component
    {
        public File(string name) : base(name)
        {
        }

        public override void Display()
        {
            Console.WriteLine(this.Name);
        }

        // Метод для добавления подкомпонентов не поддеживается
        public override void Add(Component c)
        {
            throw new NotImplementedException();
        }

        // Метод для удаления подкомпонентов не поддеживается
        public override void Remove(Component c)
        {
            throw new NotImplementedException();
        }
    }
}
