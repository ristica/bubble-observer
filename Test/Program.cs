using System;

namespace Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // root
            var root = new ConcreteObserver(null, "ROOT");

            // 1st level
            var subjectFirstLevelA = new Subject();
            var firstLevelA = new ConcreteObserver(root, "A");
            var subjectFirstLevelB = new Subject();
            var firstLevelB = new ConcreteObserver(root, "B");
            var subjectFirstLevelC = new Subject();
            var firstLevelC = new ConcreteObserver(root, "C");

            // 2nd level
            var subjectSecondLevelA1 = new Subject();
            var secondLevelA1 = new ConcreteObserver(firstLevelA, "A1");
            var subjectSecondLevelA2 = new Subject();
            var secondLevelA2 = new ConcreteObserver(firstLevelA, "A2");

            var subjectSecondLevelB1 = new Subject();
            var secondLevelB1 = new ConcreteObserver(firstLevelB, "B1");
            var subjectSecondLevelB2 = new Subject();
            var secondLevelB2 = new ConcreteObserver(firstLevelB, "B2");

            var subjectSecondLevelC1 = new Subject();
            var secondLevelC1 = new ConcreteObserver(firstLevelC, "C1");
            var subjectSecondLevelC2 = new Subject();
            var secondLevelC2 = new ConcreteObserver(firstLevelC, "C2");

            // register upline observer
            subjectSecondLevelA1.RegisterObserver(firstLevelA);
            subjectSecondLevelA2.RegisterObserver(firstLevelA);
            subjectSecondLevelB1.RegisterObserver(firstLevelB);
            subjectSecondLevelB2.RegisterObserver(firstLevelB);
            subjectSecondLevelC1.RegisterObserver(firstLevelC);
            subjectSecondLevelC2.RegisterObserver(firstLevelC);

            subjectFirstLevelA.RegisterObserver(root);
            subjectFirstLevelB.RegisterObserver(root);
            subjectFirstLevelC.RegisterObserver(root);

            // set some points 
            Console.WriteLine("--------- ADDING SOME FIRST LEVEL'S POINTS ON START ------------");
            firstLevelA.Points = 1000;
            Console.WriteLine("A - 1000 points");
            firstLevelB.Points = 2000;
            Console.WriteLine("B - 2000 points");
            firstLevelC.Points = 3000;
            Console.WriteLine("C - 3000 points");
            Console.WriteLine("---------------------");

            secondLevelA1.Points = 100;
            secondLevelA2.Points = 100;
            secondLevelB1.Points = 200;
            secondLevelB2.Points = 200;
            secondLevelC1.Points = 300;
            secondLevelC2.Points = 300;

            // notify upline that points have changes
            subjectFirstLevelA.NotifyObserver(firstLevelA.Points);
            subjectFirstLevelB.NotifyObserver(firstLevelB.Points);
            subjectFirstLevelC.NotifyObserver(firstLevelC.Points);

            subjectSecondLevelA1.NotifyObserver(secondLevelA1.Points);
            subjectSecondLevelA2.NotifyObserver(secondLevelA2.Points);
            subjectSecondLevelB1.NotifyObserver(secondLevelB1.Points);
            subjectSecondLevelB2.NotifyObserver(secondLevelB2.Points);
            subjectSecondLevelC1.NotifyObserver(secondLevelC1.Points);
            subjectSecondLevelC2.NotifyObserver(secondLevelC2.Points);

            Console.WriteLine("");
            Console.WriteLine("\t\t\t" + root.Name + ": " + root.Points + " points");
            Console.WriteLine("");

            // 1st level
            Console.Write("\t" + firstLevelA.Name + ":" + firstLevelA.Points);
            Console.Write("\t\t\t" + firstLevelB.Name + ":" + firstLevelB.Points);
            Console.Write("\t\t\t" + firstLevelC.Name + ":" + firstLevelC.Points);
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------------------");

            // 2nd level
            Console.Write(secondLevelA1.Name + ":" + secondLevelA1.Points);
            Console.Write("\t\t" + secondLevelA2.Name + ":" + secondLevelA2.Points + " | ");

            Console.Write(secondLevelB1.Name + ":" + secondLevelB1.Points);
            Console.Write("\t\t" + secondLevelB2.Name + ":" + secondLevelB2.Points + " | ");

            Console.Write(secondLevelC1.Name + ":" + secondLevelC1.Points);
            Console.Write("\t\t" + secondLevelC2.Name + ":" + secondLevelC2.Points);

            Console.ReadKey();
        }
    }
}