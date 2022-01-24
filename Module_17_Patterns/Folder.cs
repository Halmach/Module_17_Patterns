using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    class Folder : Component
    {
        /// <summary>
        /// Представляет папку - компонент, который может содежать другие компоненты
        /// Здесь реализован механизм для добавления / удаления новых компонентов
        /// </summary>
        List<Component> subFolders = new List<Component>();
        public Folder(string name) : base(name)
        {

        }

        // Метод для добавления новых компонентов
        public override void Add(Component c)
        {
            subFolders.Add(c);
            Console.WriteLine($"{Name} добавлено: {c.Name}");
        }

        // Метод для отображения нижестоящих компонентов
        public override void Display()
        {
            Console.WriteLine(this.Name);
        }

        // Метод для удаления
        public override void Remove(Component c)
        {
            subFolders.Remove(c);
            Console.WriteLine($"Из {Name} добавлено: {c.Name}");
        }
    }
}
