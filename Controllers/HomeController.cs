using Microsoft.AspNetCore.Mvc;
using SyncfusionCoreUploader.Models;
using System.Diagnostics;

namespace SyncfusionCoreUploader.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}
		public IActionResult Index()
		{
			ControlName model = new ControlName();
			model.SupportCoordinatorDataList = new Countries().CountriesList();
			model.val = "DE";
			return View(model);
		}

	}
	public class ControlName
	{
		public List<Countries> SupportCoordinatorDataList { get; set; }
		public string val { get; set; }

	}
	public class Countries
	{
		public string Name { get; set; }
		public string Code { get; set; }

		// Modify this method to retrieve data from SQL Server
		public List<Countries> CountriesList()
		{
			// Simulated data retrieval from SQL Server
			List<Countries> country = new List<Countries>();
			country.Add(new Countries { Name = "Australia", Code = "AU" });
			country.Add(new Countries { Name = "Bermuda", Code = "BM" });
			country.Add(new Countries { Name = "Canada", Code = "CA" });
			country.Add(new Countries { Name = "Cameroon", Code = "CM" });
			country.Add(new Countries { Name = "Denmark", Code = "DK" });
			country.Add(new Countries { Name = "France", Code = "FR" });
			country.Add(new Countries { Name = "Finland", Code = "FI" });
			country.Add(new Countries { Name = "Germany", Code = "DE" });
			country.Add(new Countries { Name = "Greenland", Code = "GL" });
			country.Add(new Countries { Name = "Hong Kong", Code = "HK" });
			country.Add(new Countries { Name = "India", Code = "IN" });
			country.Add(new Countries { Name = "Italy", Code = "IT" });
			country.Add(new Countries { Name = "Japan", Code = "JP" });
			country.Add(new Countries { Name = "Mexico", Code = "MX" });
			country.Add(new Countries { Name = "Norway", Code = "NO" });
			country.Add(new Countries { Name = "Poland", Code = "PL" });
			country.Add(new Countries { Name = "Switzerland", Code = "CH" });
			country.Add(new Countries { Name = "United Kingdom", Code = "GB" });
			country.Add(new Countries { Name = "United States", Code = "US" });
			return country;
		}
	}

}