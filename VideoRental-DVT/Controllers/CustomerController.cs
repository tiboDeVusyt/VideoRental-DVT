using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VideoRental_DVT.Data;
using VideoRental_DVT.Models;
using VideoRental_DVT.Repo;

namespace VideoRental_DVT.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerRepo _customerRepo;
        private readonly AppDbContext _Context;

        public CustomerController(AppDbContext context,CustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
            _Context = context;
        }
        public ViewResult Index(string sortOrder, string searchString)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.AgeSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            var customers = _Context.Customers.ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                customers = customers.Where(s => s.CustomerName.ToLower().Contains(searchString.ToLower())).ToList();
            }
            switch (sortOrder)
            {
                case "name_desc":
                    customers = customers.OrderByDescending(s => s.CustomerName).ToList();
                    break;
                case "Date":
                    customers = customers.OrderBy(s => s.Age).ToList();
                    break;
                case "date_desc":
                    customers = customers.OrderByDescending(s => s.Age).ToList();
                    break;
                default:
                    customers = customers.OrderBy(s => s.CustomerName).ToList();
                    break;
            }
            return View(customers.ToList());
        }
        public IActionResult Edit(int Id)
        {
            var customer = _customerRepo.GetCustomerById(Id);
            return View(customer);
        }
        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            _customerRepo.UpdateCustomer(customer);
            return View(customer);
        }
        public IActionResult Delete(int Id)
        {
            var customer = _customerRepo.GetCustomerById(Id);
            return View(customer);
        }
        [HttpPost]
        public IActionResult Delete(Customer customer)
        {
            _customerRepo.DeleteCustomer(customer);
            return View(customer);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Customer customer)
        {
            await _customerRepo.CreateCustomer(customer);
            return View(customer);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
