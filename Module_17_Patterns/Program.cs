﻿using System;

namespace Module_17_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Application app = new Application();

            //    app.Launch("10.30.60.80");
            //    Console.WriteLine(app.DbConnection.Configuration);

            //    app.DbConnection = DbConnection.GetConnectionInstance("10.30.60.81");
            //    Console.WriteLine(app.DbConnection.Configuration);
            ShowComposite();
        }

        static void ShowAbstractFactory()
        {
            Monster orc = new Monster(new OrcFactory());
            orc.Hit();
            orc.Move();

            Monster dragon = new Monster(new DragonFactory());
            dragon.Hit();
            dragon.Move();
        }

        static void ShowFabricMethod()
        {
            string messageText = "Ваш номер заказа - 83456";
            
            // Отправляем заказ по SMS
            MessageSender sender = new SmsMessageSender("+79873431256");
            Message smsMessage = sender.Send(messageText);

            // Отправляем заказ по e-mail
            sender = new EmailMessageSender("order@myshop.com");
            Message emailMessage = sender.Send(messageText);
        }

        static void ShowAdapter()
        {
            // Нам надо отрисовать изображение на бумаге и холсте
            // Запускаем класс для отрисовки
            var imageDrawer = new ImageDrawer();

            // Создаем класс для работы с бумажным принтером
            PaperPrinter paperPrinter = new PaperPrinter();
            // Запускаем отрисовку на бумаге
            imageDrawer.DrawWith(paperPrinter);

            //Теперь нужна печать на холсте
            CanvasPainter canvasPainter = new CanvasPainter();

            //Используем адаптер
            IPrinter ImagePrinter = new CanvasPainterToPRinterAdapter(canvasPainter);
            //Запускаем печать на холсте
            imageDrawer.DrawWith(ImagePrinter);
        }

        static void ShowComposite()
        {
            // Создание корневой папки
            Component root = new Folder("Root");

            // Создания файла- компонента низшего уровня
            File myFile = new File("MyFile.txt");
            
            // Создание папки с документами
            Folder myFolder = new Folder("MyFolder");

            // Добавляем файл в корневую папку
            root.Add(myFile);

            // Добавляем подпапку для документов в корневую папку
            root.Add(myFolder);

            // показываем контент корневой папки
            root.Display();
        }
    }
}
