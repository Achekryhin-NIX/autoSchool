using System;
using consolDB.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;


namespace consolDB
{
    class Program
    {
    public static void Main()
        {
            Add();
        }
        public static void Add()
        {
            using (var db = new NorthwindContext())
            {
                Shippers shippers = new Shippers { CompanyName = "Test5", Phone = "555" };
                db.Shippers.Add(shippers);
                db.SaveChanges();
                Assert.AreEqual("Test5", shippers.CompanyName);
            }
            
        }
        
        public static void Update()
        {
            using (var db = new NorthwindContext())
            {
                var shpObj = db.Shippers.Where(c => c.CompanyName == "Test5").FirstOrDefault();
                shpObj.Phone = "5556";
                db.SaveChanges();
            }
        }
        public static void Delete()
        {
            using (var db = new NorthwindContext())
            {
                var ship = db.Shippers.Where(x => x.CompanyName == "Test5").FirstOrDefault();
                db.Shippers.Remove(ship);
                db.SaveChanges();
            }
        }
        public static void FindRepeatedRecords()
        {
            var db = new NorthwindContext();
            var doblicate = db.Shippers.GroupBy(i => i.CompanyName).Where(x => x.Count() > 1).Select(val => val.Key);
            foreach (var item in doblicate)
            {
                Console.WriteLine(item);
            }
        }

    }


}












