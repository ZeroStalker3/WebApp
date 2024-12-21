using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using WebApp.Services;

namespace WebApp.Controllers
{
    public class GenericController<T> : Controller where T : class
    {
        private readonly ApiService<T> _apiService;

        public GenericController(string apiUrl)
        {
            _apiService = new ApiService<T>(apiUrl);
        }

        public async Task<IActionResult> Index()
        {
            var items = await _apiService.GetAllAsync();
            return View(items);
        }

        public async Task<IActionResult> Details(int id)
        {
            var item = await _apiService.GetAsync(id);
            return View(item);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(T item)
        {
            if (ModelState.IsValid)
            {
                await _apiService.CreateAsync(item);
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var item = await _apiService.GetAsync(id);
            return View(item);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, T item)
        {
            if (ModelState.IsValid)
            {
                await _apiService.UpdateAsync(id, item);
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _apiService.GetAsync(id);
            return View(item);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            await _apiService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
