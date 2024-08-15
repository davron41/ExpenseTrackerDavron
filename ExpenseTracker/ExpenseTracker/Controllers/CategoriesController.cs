using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExpenseTracker.Stores.Interfaces;
using ExpenseTracker.ViewModels.Category;
using ExpenseTracker.Stores;
using ExpenseTracker.Infrastructure.Repositories;
using ExpenseTracker.Mappings;

namespace ExpenseTracker.Controllers;

public class CategoriesController : Controller
{
    private readonly ICategoryStore _store;

    public CategoriesController(ICategoryStore store)
    {
        _store = store;
    }

    public IActionResult Index()
    {
        var result = _store.GetAll("");

        return View(result);
    }

    public IActionResult Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var result = _store.GetById(id.Value);

        return View(result);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(CreateCategoryViewModel category)
    {
        if (!ModelState.IsValid)
        {
            return View(category);
        }

        var createdCategory = _store.Create(category);

        return RedirectToAction(nameof(Details), new { id = createdCategory.Id });
    }

    public IActionResult Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var category = _store.GetById(id.Value);

        if (category is null)
        {
            return NotFound();
        }

        var viewModel = category.ToViewModel();

        return View(viewModel);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, UpdateCategoryViewModel category)
    {
        if (id != category.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _store.Update(category);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryExists(category.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToAction(nameof(Index));
        }
        return View(category);
    }

    public IActionResult Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var category = _store.GetById(id.Value);

        if (category is null)
        {
            return NotFound();
        }

        return View(category);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        var category = _store.GetById(id);

        if (category is null)
        {
            return NotFound();
        }

        _store.Delete(id);
        return RedirectToAction(nameof(Index));
    }

    private bool CategoryExists(int id)
    {
        return _store.GetById(id) is not null;
    }
}
