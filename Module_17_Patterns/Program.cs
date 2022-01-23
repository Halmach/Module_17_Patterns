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
            ShowAbstractFactory();
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
    }
}
