using Microsoft.AspNetCore.Mvc;
using Project01.Models;

namespace Project01.Controllers
{
    public class PersonController : Controller
    {
        private List<Person> GetPersonsList()
        {
            return new List<Person>()
            {
                new Person() { Id = 1, Name = "Joe", Surname = "Crosswave", MaritalStatus = "Married", Age = 32, Birthday = DateTime.Now, IsWorking = false },
                new Person() { Id = 2, Name = "Merry", Surname = "Lisel", MaritalStatus = "Widowed", Age = 42, Birthday = DateTime.Now, IsWorking = false },
                new Person() { Id = 3, Name = "Henry", Surname = "Crux", MaritalStatus = "Single", Age = 29, Birthday = DateTime.Now, IsWorking = true },
                new Person() { Id = 4, Name = "Cody", Surname = "Jurut", MaritalStatus = "", Age = 49, Birthday = DateTime.Now, IsWorking = false },
                new Person() { Id = 5, Name = "Simon", Surname = "Scranton", MaritalStatus = "Single", Age = 34, Birthday = DateTime.Now, IsWorking = false },
                new Person() { Id = 6, Name = "Leena", Surname = "Laurent", MaritalStatus = "Divorced", Age = 19, Birthday = DateTime.Now, IsWorking = false },
                new Person() { Id = 7, Name = "Ode", Surname = "Cosmides", MaritalStatus = "Married", Age = 54, Birthday = DateTime.Now, IsWorking = true },
                new Person() { Id = 8, Name = "Nicky", Surname = "Cassel", MaritalStatus = "Married", Age = 32, Birthday = DateTime.Now, IsWorking = true }
            };
        }

        public IActionResult Index()
        {
            return View();
        }

        //See if have any confusion https://www.youtube.com/watch?v=Jiu-gb46Rjo
        public IActionResult Grid1()
        {
            // Result needs to be IQueryable in database scenarios, to make use of database side paging.
            return View(GetPersonsList().AsQueryable());
        }

        //https://stackoverflow.com/questions/67835041/how-to-render-custom-html-in-nonfactors-mvc6-grid
        public IActionResult Grid2()
        {
            //Initial data.
            var personvm = new PersonViewModel()
            {
                Persons = GetPersonsList(),
                SelectedName = new List<string>() { "Merry", "Henry", "Leena", "Nicky" }
            };
            return View(personvm);
        }
    }
}
