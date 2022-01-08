using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> companyDic = new SortedDictionary<string, List<string>>();

            string command = Console.ReadLine();
            while (command!="End")
            {
                string[] compInfo = command.Split(" -> ");
                string compName = compInfo[0];
                string ID = compInfo[1];
                if (!companyDic.ContainsKey(compName))
                {
                    List<string> listOfID = new List<string>()
                    { 
                        ID
                    };

                    companyDic.Add(compName, listOfID);
                }
                else if (companyDic.ContainsKey(compName))
                {
                    if (!companyDic[compName].Contains(ID))
                    {
                        companyDic[compName].Add(ID); 
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var company in companyDic)
            {
                Console.WriteLine(company.Key);

                foreach (var ID in company.Value)
                {
                    Console.WriteLine($"-- {ID}");
                }
            }
        }
    }
}
