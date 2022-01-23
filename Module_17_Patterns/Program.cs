using System;

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
            ShowFabricMethod();
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
    }
}
