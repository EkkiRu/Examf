using Data.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam.Data
{
    public class InformationOutput
    {
        public void PageOutput()
        {
            using (var context = new ApplicationContext())
            {
                int countPage;
                const int TOWN_PER_PAGE = 3;
                Console.WriteLine(context.Towns.Count());
                if (context.Towns.Count() % TOWN_PER_PAGE == 0)
                {
                    countPage = context.Towns.Count() / TOWN_PER_PAGE;
                    Console.WriteLine($"Доступные страницы: {countPage }");

                }
                else
                {
                    countPage = context.Towns.Count() / TOWN_PER_PAGE + 1;
                    Console.WriteLine($"Доступные страницы: {countPage}");
                }
                Console.WriteLine($"Выберете старницу от 0 до {countPage - 1}");
                int sample;
                if (!int.TryParse(Console.ReadLine(), out sample))
                {
                    Console.WriteLine("Введенно не корректное значение");
                    return;
                }
                else
                {
                    var selectedPage = context.Towns.Skip(TOWN_PER_PAGE * sample).Take(TOWN_PER_PAGE).ToList();
                    var selectedContry = context.Countries.Take(context.Countries.Count()).ToList();
                    Console.WriteLine($"Страница {sample} из {countPage - 1}");
                    for (int i = 0; i < selectedPage.Count; i++)
                    {
                        Console.WriteLine($"Id - {selectedPage[i].Id}");
                        Console.WriteLine($"Name - {selectedPage[i].Name}");
                        for (int j = 0; j < selectedContry.Count; j++)
                        {
                            if(selectedPage[i].CountryId == selectedContry[j].Id)
                            {
                            Console.WriteLine($"Country.Name - {selectedContry[j].Name}");
                                break;
                            }
                        }
                        Console.WriteLine($"Capital - {selectedPage[i].Capital}");
                    }
                }
            }
        }
    }
}
