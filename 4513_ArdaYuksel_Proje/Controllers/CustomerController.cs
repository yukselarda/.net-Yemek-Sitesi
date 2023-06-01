using _4513_ArdaYuksel_Proje.Entities;
using _4513_ArdaYuksel_Proje.Models;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace _4513_ArdaYuksel_Proje.Controllers
{
	public class CustomerController : Controller
	{
		//DI Dependency Injection
		private readonly AppDbContext context;

		public CustomerController(AppDbContext context)
		{
			this.context = context;
		}

		[HttpGet("Müşteriler", Name = "Müşteriler-route")]
		public IActionResult Index()
		{
			var dlist = this.context.Customers.ToList();

			var model = new CustomerIndexViewModel
			{
           Customers = dlist,
			};
			return View(model);
		}

		[HttpGet("MüşteriEkle", Name = "ekle-route")]
		public IActionResult Create()
		{
			return View();

		}
		[HttpPost("MüşteriEkle", Name = "ekle-route")]
		public IActionResult Create(CustomerCreateViewModel viewModel)
		{
			var customer = new Customer()
			{
				Name = viewModel.Name,
				Surname = viewModel.Surname,
				Email = viewModel.Email

			};

			context.Customers.Add(customer);
			int result = context.SaveChanges();
			//0 dan farklı değer donduyse işlem başarılı olmuştur.
			return RedirectToAction("Index");
		}

	}
}
