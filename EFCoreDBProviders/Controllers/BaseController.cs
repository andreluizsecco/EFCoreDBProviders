using System;
using System.Linq;
using EFCoreDBProviders.Context;
using EFCoreDBProviders.Models;
using EFCoreDBProviders.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDBProviders.Controllers
{
    public class BaseController : Controller
    {
        private readonly LivroRepository _repository;

        public BaseController(DbContext context)
        {
            _repository = new LivroRepository(context);
        }

        public IActionResult Index()
        {
            return View(_repository.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View(_repository.GetById(id));
        }

        [HttpPost]
        public IActionResult Create(Livro livro)
        {
            if (ModelState.IsValid)
            {
                _repository.Add(livro);
                return RedirectToAction("Index");
            }
            else
                return View("Create", livro);
        }

        [HttpPost]
        public IActionResult Edit(Livro livro)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(livro);
                return RedirectToAction("Index");
            }
            else
                return View("Edit", livro);
        }

        public IActionResult Delete(int id)
        {
            _repository.RemoveById(id);

            return RedirectToAction("Index");
        }
    }
}