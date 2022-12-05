using System;
using Delegate.Models;

namespace Delegate
{
    internal class Program
    {
        delegate void RegisterEmployee(People people);
        static void Main(string[] args)
        {
            List<People>peoples = new List<People>();
            People senan = new People("senan", "behbudov ", 19);
            People samir = new People("Samir", "lutfizade", 30);
            People xeyale = new People("xeyale", "qehramanova", 17);
            peoples.Add(senan);
            peoples.Add(samir);
            peoples.Add(xeyale);
            Console.WriteLine("listde axartdiginiz adi daxil edin");
            string ad = Console.ReadLine(); 
            Console.WriteLine(peoples.Find(peoples => peoples.Name == ad));

           //foreach(People people in peoples.FindAll(peoples => peoples.Surname.Contains("ov")).Find(peoples=>peoples.surname.Contains("ova")))
           // {
           //     Console.WriteLine(peoples);
           // }
            Console.WriteLine(peoples.FindAll(peoples=> peoples.age >18));
            //List<People> NewList = peoples.FindAll(delegate (People P)
            ////{
            ////    return (P.Age > 25);
            ////    Console.WriteLine(P);
            //});
            //Console.WriteLine(peoples.FindAll(peoples => peoples.Name.Contains("senan")).Find(peoples => peoples.Name.Length > 0));
           
        }
    }
}