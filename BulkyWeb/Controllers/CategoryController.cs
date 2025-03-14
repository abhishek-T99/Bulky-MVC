using System.Data.Common;
using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers;

public class CategoryController: Controller
{
    private readonly ApplicationDbContext _db;

    public CategoryController(ApplicationDbContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        var objCategoryList = _db.Categories.ToList();
        return View(objCategoryList);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Category obj)
    {
        if (ModelState.IsValid)
        {
            _db.Categories.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View();
    }

    public IActionResult Edit(int? id)
    {
        if (id==null || id==0)
        {
            return NotFound();
        }
        _db.Categories.Find(id);
        return View();
    }

    [HttpPost]
    public IActionResult Edit(Category obj)
    {
        if (ModelState.IsValid)
        {
            _db.Categories.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View();
    }
}
