using Data.Application;
using Exam.Data;
using Exam.Model;
using System;
using System.Collections.Generic;

namespace Exam
{
    class Program
    {
        /*Создать консольное приложение, позволяющее пользователю добавлять и просматривать постранично страны и города к ним.

        Страна состоит из названия и списка городов.
        Город состоит из названия, ссылки на страну и логического значения, которое показывает, является ли город столицей.

        Постраничный вывод осуществляется по 3 позиции.

        Время сдачи - 22:00. Те, кто сдал в 22:01 и позже считаются провалившими экзамен.
        Сдача через гит. Ссылку на гит на почту до 22:00.

        Максимальные баллы, без учёта ошибок:
        Подключённый уровень - 12 баллов
        Dapper - 10 баллов
        EF Core - 8 баллов.*/
        static void Main(string[] args)
        {

            /*var collectionCountry = new List<Country>() {
                new Country { Name = "Казахстан" },
                new Country{Name = "Россия"},
                new Country{Name = "Сша"}
            };
            var collectionTown = new List<Town>()
            {
                new Town{Name = "Астана", Capital = true, Country = collectionCountry[0]},
                new Town {Name = "Алматы", Capital = false,Country = collectionCountry[0] },
                new Town {Name = "Павлодар", Capital = false,Country = collectionCountry[0] },
                new Town {Name = "Москва", Capital = true,Country = collectionCountry[1] },
                new Town {Name = "Питер", Capital = false,Country = collectionCountry[1] },
                new Town {Name = "Омск", Capital = false,Country = collectionCountry[1] },
                new Town {Name = "Кемерево", Capital = false,Country = collectionCountry[1] },
                new Town {Name = "Нью-йорк", Capital = false,Country = collectionCountry[2] },
                new Town {Name = "Вашингтон", Capital = true,Country = collectionCountry[2] },
                new Town {Name = "Маями", Capital = true,Country = collectionCountry[2] },
                
            };
            using (var context = new ApplicationContext())
            {
                for (int i = 0; i < collectionTown.Count; i++)
                {
                    context.Add(collectionTown[i]);
                }
                context.SaveChanges();
            }*/
            while (true)
            {
                InformationOutput informationOutput = new InformationOutput();
                informationOutput.PageOutput();
                Console.ReadLine();
                Console.Clear();
            }

        }
    }
}
