using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // root
            var root = new ConcreteObserver(null, "ROOT");

            // 1st level
            var subjectFirstLevela = new Subject();
            var firstLevela = new ConcreteObserver(root, "A");
            var subjectFirstLevelb = new Subject();
            var firstLevelb = new ConcreteObserver(root, "B");
            var subjectFirstLevelc = new Subject();
            var firstLevelc = new ConcreteObserver(root, "C");

            // 2nd level
            var subjectSecondLevela1 = new Subject();
            var secondLevela1 = new ConcreteObserver(firstLevela, "A1");
            var subjectSecondLevela2 = new Subject();
            var secondLevela2 = new ConcreteObserver(firstLevela, "A2");

            var subjectSecondLevelb1 = new Subject();
            var secondLevelb1 = new ConcreteObserver(firstLevelb, "B1");
            var subjectSecondLevelb2 = new Subject();
            var secondLevelb2 = new ConcreteObserver(firstLevelb, "B2");

            var subjectSecondLevelc1 = new Subject();
            var secondLevelc1 = new ConcreteObserver(firstLevelc, "C1");
            var subjectSecondLevelc2 = new Subject();
            var secondLevelc2 = new ConcreteObserver(firstLevelc, "C2");

            // register upline observer
            subjectSecondLevela1.RegisterObserver(firstLevela);
            subjectSecondLevela2.RegisterObserver(firstLevela);
            subjectSecondLevelb1.RegisterObserver(firstLevelb);
            subjectSecondLevelb2.RegisterObserver(firstLevelb);
            subjectSecondLevelc1.RegisterObserver(firstLevelc);
            subjectSecondLevelc2.RegisterObserver(firstLevelc);

            subjectFirstLevela.RegisterObserver(root);
            subjectFirstLevelb.RegisterObserver(root);
            subjectFirstLevelc.RegisterObserver(root);

            // set some points 
            Console.WriteLine("--------- ADDING SOME FIRSTLEVEL' POINTS ON START ------------");
            firstLevela.Points = 1000;
            Console.WriteLine("A - 1000 points");
            firstLevelb.Points = 2000;
            Console.WriteLine("B - 2000 points");
            firstLevelc.Points = 3000;
            Console.WriteLine("C - 3000 points");
            Console.WriteLine("---------------------");

            secondLevela1.Points = 100;
            secondLevela2.Points = 100;
            secondLevelb1.Points = 200;
            secondLevelb2.Points = 200;
            secondLevelc1.Points = 300;
            secondLevelc2.Points = 300;

            // notify upline that points have changes
            subjectFirstLevela.NotifyObserver(firstLevela.Points);
            subjectFirstLevelb.NotifyObserver(firstLevelb.Points);
            subjectFirstLevelc.NotifyObserver(firstLevelc.Points);

            subjectSecondLevela1.NotifyObserver(secondLevela1.Points);
            subjectSecondLevela2.NotifyObserver(secondLevela2.Points);
            subjectSecondLevelb1.NotifyObserver(secondLevelb1.Points);
            subjectSecondLevelb2.NotifyObserver(secondLevelb2.Points);
            subjectSecondLevelc1.NotifyObserver(secondLevelc1.Points);
            subjectSecondLevelc2.NotifyObserver(secondLevelc2.Points);

            Console.WriteLine("");
            Console.WriteLine("                           " + root.Name + ": " + root.Points + " points");
            Console.WriteLine("");

            // 1st level
            Console.Write("\t" + firstLevela.Name + ":" + firstLevela.Points);
            Console.Write("\t\t\t" + firstLevelb.Name + ":" + firstLevelb.Points);
            Console.Write("\t\t\t" + firstLevelc.Name + ":" + firstLevelc.Points);
            Console.WriteLine("");
            Console.WriteLine("");

            // 2nd level
            Console.Write("   " + secondLevela1.Name + ":" + secondLevela1.Points);
            Console.Write("    " + secondLevela2.Name + ":" + secondLevela2.Points);

            Console.Write("        " + secondLevelb1.Name + ":" + secondLevelb1.Points);
            Console.Write("    " + secondLevelb2.Name + ":" + secondLevelb2.Points);

            Console.Write("        " + secondLevelc1.Name + ":" + secondLevelc1.Points);
            Console.Write("    " + secondLevelc2.Name + ":" + secondLevelc2.Points);

            Console.ReadKey();
        }
    }
}
