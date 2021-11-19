using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EFGetStarted
{
    internal class Program
    {
        private static void Main()
        {
            using (var db = new BloggingContext())
            {
                // Note: This sample requires the database to be created before running.
                Console.WriteLine($"Database path: {db.DbPath}.");

                // Create
                Console.WriteLine("Inserting a new blog");
                db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
                db.SaveChanges();

                // Read
                Console.WriteLine("Querying for a blog");
                var blog = db.Blogs
                    .OrderBy(b => b.BlogId)
                    .First();

                // Update
                Console.WriteLine("Updating the blog and adding a post");
                blog.Url = "https://devblogs.microsoft.com/dotnet";
                blog.Posts.Add(
                    new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" });
                db.SaveChanges();

                // Delete
                Console.WriteLine("Delete the blog");
                db.Remove(blog);
                blog.Authors.Add(
                    new Author { FirstName = "Konrad", LastName = "Summer" });
                blog.Authors.Add(
                    new Author { FirstName = "Anne", LastName = "Hoxer" });
                db.SaveChanges();
                Blog mad = new Blog();
                mad.Url = "MadHouse";
                var konrad = db.Authors
                    .First(a => a.FirstName == "Konrad");
                var Anne = db.Authors
                    .First(a => a.FirstName == "Anne");
                mad.Authors.Add(Anne);
                mad.Authors.Add(konrad);
                db.Add(mad);
                db.SaveChanges();
                mad.Posts.Add(
                    new Post { Title = "Testing", Content = "For tests...." });
                db.SaveChanges();
                Post per = db.Posts.First(p => p.Title == "Testing");
                per.Title = "new Testing";
                db.SaveChanges();
                mad.Posts.Remove(per);
                db.SaveChanges();

                mad = db.Blogs.Include(b => b.Authors).First(b => b.Url == "MadHouse");
                foreach (var author in mad.Authors)
                {
                    Console.WriteLine("{0} {1}", author.FirstName, author.LastName);
                }
                
            }
        }
    }
}