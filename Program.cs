using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ооо;

namespace ooo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Random rnd = new Random();
             Ticket exe = new Ticket(rnd.Next(1, 2000), rnd.Next(1, 2000), "Использован");
             Ticket exe1 = new Ticket(rnd.Next(1, 2000), rnd.Next(1, 2000), "Использован");
             //exe.reWriteTicket();

             
             klient ex = new klient("Alexandr", "Муж", exe, 26);

             ex.reWrite();


             klient ex1 = new klient("Анна", "Муж", exe1, 18);
             ex1.reWrite();

             WorkInventory win1 = new WorkInventory("2004-05-23", 5, "Рабочий инвентарь", "Дебилов Д.Д.", "Только для клиентов");
             SnowboardInventory sin1 = new SnowboardInventory("2004-05-23", 50, "Прокатный инвентарь", 155, "Camber");

             List<Inventory> ListInventory = new List<Inventory>();

             ListInventory.Add(win1);
             ListInventory.Add(sin1);


             foreach (Inventory i in ListInventory)
             {
                 if (i is WorkInventory)
                 {
                     (i as WorkInventory).reWriteWorkInventory();
                 }
                 else if (i is SnowboardInventory)
                 {
                     (i as SnowboardInventory).reWriteSnowboardInventory();
                 }
                 else i.reWriteInventory();

             }
             */



            /*
            WorkInventory workint1 = new WorkInventory("66/66/6666", 66, "Рабочий инвентарь", "Дебилов Д.Д.", "Для клиентов");
            Console.WriteLine(workint1.InventoryInfo());


            

            WorkInventoryForClients workintklients1 = new WorkInventoryForClients("14/88/6969", 99, "Рабочий инвентарь", "Хрюшкин Х.Й.", "Только для клиентов", "6+", "Не брать в рот");
            Console.WriteLine(workintklients1.InventoryInfo());
            */
            /*
                        SnowboardInventory sin1 = new SnowboardInventory("66/66/6666", 66, "Прокатный иневнатрь", 155, "Кэмбер");
                        Console.WriteLine(sin1.Ii());

                        WorkInventory win1 = new WorkInventory("14/88/6969", 99, "Рабочий инвентарь", "Хрюшкин Х.Й.", "Только для клиентов");
                        Console.WriteLine(win1.Ii());

                        Console.ReadLine();
                        */

            Otchet obj1 = new Otchet(x: 300, y: 66);
            Console.WriteLine("Выручка за день: ");
            obj1.reWrite();
            
            Console.WriteLine("{0} * {1} = {2}", obj1.x, obj1.y, obj1.Prz());


            Otchet1 obj2 = new Otchet1(z: 30, x: 300, y: 66);
            Console.WriteLine("\nпримерный расчет: ");
            obj2.reWrite();
            Console.WriteLine("{0} * {1} * {3} = {2}", obj2.x, obj2.y, obj2.Prz(), obj2.z);

            Console.ReadLine();

        }
    }
}
