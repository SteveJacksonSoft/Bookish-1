    using System;
    using System.Diagnostics;
    using Bookish.Models;
    using Microsoft.AspNetCore.Mvc;
    using Bookish.Models;
    using Dapper;
    using Microsoft.Extensions.Logging;
    using System.Data.SqlClient;
    using Microsoft.Extensions.Localization;


    namespace Bookish.Controllers
    {
        
        [Route("books")]
        public class LibraryController : Controller
        {
            private readonly ILogger<LibraryController> _logger;

            public LibraryController(ILogger<LibraryController> logger)
            {
                _logger = logger;
            }

            // GET
            [HttpGet("all")]
            public IActionResult Index()
            {

                {
                    var connectionString = "Server=localhost; Port=3306; Database=library_mangement; Uid=root; Pwd=password;";
                    ;
                    //my server, port number, name of database, my id, my pwd

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        var books = connection.Query<LibraryModel.Books>("SELECT * FROM Books");
                        
                        Console.WriteLine(books);
                        Console.WriteLine("Hello World");
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