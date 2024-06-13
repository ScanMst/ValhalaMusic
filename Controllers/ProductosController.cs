using Microsoft.AspNetCore.Mvc;
using Valhalla_Music;

namespace ValhalaMusic.Controllers
{
    public class ProductosController: Controller
    {
     public readonly ApplicationDbContext _context;
     public ProductosController(ApplicationDbContext context)
     {
        _context=context;
     }

     public IActionResult PoductosList()
     {
        return View();
     }



    
    }
}