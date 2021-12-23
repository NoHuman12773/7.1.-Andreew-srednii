using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    class Program
    {
        struct rabota
        {
            public string lastName;
            public string name;
            public string Otchestvo;
            public string Sex;
            public string Doljnost;
            public DateTime DayOfBirthday;
        }
        static void Main(string[] args)
        {
            rabota[] rabotas = new rabota[1];
            for (int i = 0; i < rabotas.Length; i++)
            {
                Console.WriteLine("Введите фамилию");
                rabotas[i].lastName = Console.ReadLine();

                Console.WriteLine("Введите имя");
                rabotas[i].name = Console.ReadLine();

                Console.WriteLine("Введите отчество");
                rabotas[i].Otchestvo = Console.ReadLine();

                Console.WriteLine("Введите пол");
                string sex = Console.ReadLine();
                if (sex == "м") 
                {
                    rabotas[i].Sex = "male";   
                }
                else rabotas[i].Sex = "famale";

                Console.WriteLine("Введите должность");
                rabotas[i].Doljnost = Console.ReadLine();

                Console.WriteLine("Введите дату рождения");
                rabotas[i].DayOfBirthday = DateTime.Parse(Console.ReadLine());

            }
            foreach (rabota i in rabotas)
            {
                var now = DateTime.Now.Year;
                var date = now - i.DayOfBirthday.Year;
                if (((date - 60 >= 0 && false) || (date - 65 >= 0 && true)) && i.Doljnost == "инженер") Console.WriteLine(i.lastName+" "+i.name+" "+i.Otchestvo+", "+i.Sex+", "+i.Doljnost+", "+i.DayOfBirthday+".");
            }
            Console.ReadKey();
        }
    }
}
