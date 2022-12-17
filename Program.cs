using System;

namespace Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numTabsOpened = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numTabsOpened; i++)
            {
                string tabsOpened = Console.ReadLine();

                switch (tabsOpened)
                {
                    case "Facebook":
                        salary -= 150; break;
                    case "Instagram":
                        salary -=100; break;
                    case "Reddit":
                        salary -= 50; break;
                }

                if (salary <= 0)
                {
                    break;
                }
            }
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
            
        }
    }
}
