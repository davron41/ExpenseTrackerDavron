using ExpenseTracker.Application.Requests.Category;
using ExpenseTracker.Application.ViewModels.Category;
using ExpenseTracker.Stores.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Controllers;

public class CategoriesController : Controller
{
    private readonly ICategoryStore _store;

    public CategoriesController(ICategoryStore store)
    {
        _store = store;
    }

    public IActionResult Index([FromQuery] GetCategoriesRequest request)
    {
        var categories = _store.GetAll(request);

        ViewBag.Search = request.Search;

        return View(categories);
    }

    public IActionResult Details([FromRoute] CategoryRequest request)
    {
        var category = _store.GetById(request);

        return View(category);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create([FromForm] CreateCategoryRequest request)
    {
        if (!ModelState.IsValid)
        {
            return View(request);
        }

        _store.Create(request);

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit([FromRoute] CategoryRequest request)
    {
        var category = _store.GetById(request);

        return View(category);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit([FromRoute] int id, [FromForm] UpdateCategoryRequest request)
    {
        if (id != request.Id)
        {
            return BadRequest($"Route id does not match with body id.");
        }

        if (!ModelState.IsValid)
        {
            return View(request);
        }

        _store.Update(request);

        return RedirectToAction(nameof(Details), new { id = request.Id });
    }

    public IActionResult Delete([FromRoute] CategoryRequest request)
    {
        var category = _store.GetById(request);

        return View(category);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed([FromRoute] CategoryRequest request)
    {
        _store.Delete(request);

        return RedirectToAction(nameof(Index));
    }

    /// <summary>
    /// Filters categories
    /// </summary>
    /// <param name="search"></param>
    /// <returns>List of filtered categories</returns>
    [Route("getCategories")]
    public ActionResult<CategoryViewModel> GetCategories([FromQuery] GetCategoriesRequest request)
    {
        var categories = _store.GetAll(request);

        return Ok(categories);
    }
}