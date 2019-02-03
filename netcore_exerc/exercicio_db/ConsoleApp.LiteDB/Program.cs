using System;
using LiteDB;

namespace ConsoleApp.LiteDB {
    class Program {
        static void Main (string[] args) {
            //Console.WriteLine ("Hello World!");
            // Open database (or create if not exits)
            using (var db = new LiteDatabase (@"MyData.db")) {
                // Get customer collection
                var customers = db.GetCollection<Customer> ("customers");

                // Create your new customer instance
                var customer = new Customer {
                    Name = "John Doe",
                    Phones = new string[] { "8000-0000", "9000-0000" },
                    IsActive = true
                };

                // Insert new customer document (Id will be auto-incremented)
                customers.Insert (customer);

                // Update a document inside a collection
                customer.Name = "Joana Doe";

                customers.Update (customer);

                // Index document using a document property
                customers.EnsureIndex (x => x.Name);

                // Use Linq to query documents
                var results = customers.Find (x => x.Name.StartsWith ("Jo"));
                foreach( var item in results){
                    Console.WriteLine(item.Name);
                    foreach(var tel in item.Phones){
                        Console.WriteLine(tel);
                    }                    
                    Console.WriteLine(item.IsActive);

                }
            }
        }
    }
}