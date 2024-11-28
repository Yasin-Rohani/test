using Bulky2.Data;
using Bulky2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bulky2.Controllers;

public class CategoryController : Controller
{
    // GET

   private readonly ApplicationDbContext _db;
    public CategoryController(ApplicationDbContext db)
    {
        _db = db;
    }
    public IActionResult Index()
    {
        List<Category>objCategoryList= _db.Categories.ToList();   
        return View(objCategoryList);
    }
}