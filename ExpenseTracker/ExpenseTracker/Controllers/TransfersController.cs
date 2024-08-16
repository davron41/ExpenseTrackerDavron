using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Infrastructure;
using ExpenseTracker.Stores.Interfaces;
using ExpenseTracker.ViewModels.Transfer;
using ExpenseTracker.Mappings;

namespace ExpenseTracker.Controllers
{
    public class TransfersController : Controller
    {
        private readonly ITransferStore _store;
        private readonly ICategoryStore _categoryStore;

        public TransfersController(ITransferStore store, ICategoryStore categoryStore)
        {
            _store = store;
            _categoryStore = categoryStore;
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

            var transfer = _store.GetById(id.Value);

            if (transfer is null)
            {
                return NotFound();
            }

            return View(transfer);
        }

        public IActionResult Create()
        {
            var categories = _categoryStore.GetAll("");
            ViewBag.Categories = categories;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateTransferViewModel transfer)
        {
            if (!ModelState.IsValid)
            {
                return View(transfer);
            }
            var createdTransfer=_store.Create(transfer);


            return RedirectToAction(nameof(Details), new {id=createdTransfer.Id});
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transfer =_store.GetById(id.Value);

            var categories = _categoryStore.GetAll("");
            ViewBag.Categories = categories;

            var category = categories.FirstOrDefault(x => x.Id == transfer.CategoryId);
            ViewBag.Value=category;

            if (transfer is null)
            {
                return NotFound();
            }

            return View(transfer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, TransferViewModel transfer)
        {
            if (id != transfer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                   _store.Update(transfer);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransferExists(transfer.Id))
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
            return View(transfer);
        }

        public  IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transfer=_store.GetById(id.Value);

            if (transfer is null)
            {
                return NotFound();
            }

            return View(transfer);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transfer=_store.GetById(id);

            if (transfer is null)
            {
                return NotFound();
            }

            _store.Delete(id);
            
            return RedirectToAction(nameof(Index));
        }

        private bool TransferExists(int id)
        {
            return _store.GetById(id) is not null;
        }
    }
}
