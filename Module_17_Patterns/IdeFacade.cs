using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    /// <summary>
    /// Фасад,скрывающий механизм работы IDE с компонентами
    /// Использующимися при разработке
    /// </summary>
    class IdeFacade
    {
        readonly Editor _editor;
        readonly Compiller _compiller;
        readonly Runtime _runtime;

        public IdeFacade(Editor editor, Compiller compiller, Runtime runtime)
        {
            _editor = editor;
            _compiller = compiller;
            _runtime = runtime;
        }

        //Вы ввели код, IDE выполняет с ним примерно следующие действия перед запуском:
        public void Start(string sourceCode)
        {
            //Пишет в текстовый файл
            _editor.Write(sourceCode);

            //Сохраняет текстовый файл
            _editor.Save();

            //Вызывает компилятор
            _compiller.Compille();

            //Запускает выполнение скопилированного приложения в среде CLR
            _runtime.Execute();
        }

        public void Stop()
        {
            _runtime.Finish();
        }
    }
}
