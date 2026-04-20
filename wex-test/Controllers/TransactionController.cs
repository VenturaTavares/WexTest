using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using wex_test.Application.Services;
using wex_test.Application.ViewModels;

namespace wex_test.Controllers
{
    public class TransactionController : Controller
    {
        private readonly ITransactionService _transactionService;   

        public TransactionController(ITransactionService transactionService)
        {
             this._transactionService = transactionService;
        }

        // GET: Transaction
        public async Task<IActionResult> Index()
        {
            return View(await _transactionService.GetTransactions());
        }

        // GET: Transaction/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Transaction/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TransactionID,Description,TransactionDate,PurchaseAmount,CountryCurrencyDescription")] TransactionViewModel transactionViewModel)
        {


            ModelState.Remove("CountryCurrencyDescription");
            
            if (ModelState.IsValid)
            {
                
                await _transactionService.CreateTransaction(transactionViewModel);
                return RedirectToAction(nameof(Index));
            }
            return View(transactionViewModel);
        }

   
    }
}
