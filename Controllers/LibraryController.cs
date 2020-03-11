using System;
using System.Diagnostics;
using Bookish.Models;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using Dapper;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;


namespace Bookish.Controllers
{
    public class LibraryController : Controller
    {
        private readonly ILogger<LibraryController> _logger;

        public LibraryController(ILogger<LibraryController> logger)
        {
            _logger = logger;
        }

        // GET
        public IActionResult Index()
        {

            {
                var connectionString = "Server=(local);Port=3306;Database=library_mangement;Uid=root;Pwd=Manga239498!";
                ;
                //my server, port number, name of database, my id, my pwd

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    var books = connection.Query<LibraryModel.Books>("Select * From Books ");

                    Console.WriteLine(LibraryModel.Books.);
                    Console.WriteLine(books);
                    Console.ReadLine();
                    return View(books);
                }

            }
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}