using System.Diagnostics;
using System.Threading.Tasks;
using aaa.DanceIntegration.Repository;
using aaa.DanceIntegration.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace aaa.DanceIntegration.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _usersRepository;

        private ILogger _logger;

        public HomeController(ILoggerFactory loggerFactory, IUserRepository usersRepository)
        {
            _usersRepository = usersRepository;
            _logger = loggerFactory.CreateLogger(nameof(HomeController));
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Opening index");
            return View();
        }

        public async Task<IActionResult> DbView()
        {
            _logger.LogInformation("Opening dbView");
            return View(await _usersRepository.Get());
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
