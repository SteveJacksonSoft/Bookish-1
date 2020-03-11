using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Configuration;
using System.Collections.Specialized;
using System.Linq;
using Bookish.Models;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using Dapper;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;
using System.Data.Sql;
using Microsoft.Data.SqlCl


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
                var connectionString = "Server=localhost;Port=3306;Database=library_mangement;Uid=root;Pwd=myPassword"; ;
               //my server, port number, name of database, my id, my pwd

                using (SqlConnection connection  = new SqlConnection(connectionString))
                {
                    var books = connection.Query<LibraryModel.Books>("Select * From Books ");

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