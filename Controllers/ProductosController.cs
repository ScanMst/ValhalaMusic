using Microsoft.AspNetCore.Mvc;
using ValhalaMusic.Models;
using Valhalla_Music;
using Valhalla_Music.Entities;

namespace ValhalaMusic.Controllers
{
    public class ProductosController: Controller
    {
     public readonly ApplicationDbContext _context;
     public ProductosController(ApplicationDbContext context)
     {
        _context=context;
        
     }

     public IActionResult ProductoList()
     {
        List<ProductoModel> list = 
        _context.Productos
            .Select(p => new ProductoModel()
                {
                    ProductoId = p.ProductoId,
                    Nombre = p.Nombre,
                    Precio = p.Precio,
                    Stock=p.Stock,
                })
            .ToList();

        return View(list);
     }

     public IActionResult ProductoAdd()
     {
       /* Producto entity = new Producto();
        entity.ProductoId = new int();
        entity.Nombre = "Guitarra";
        entity.Precio = 500;
        entity.Stock = 10;
            
        //Esto es para guardar en la base de datos.
        _context.Productos.Add(entity);
        _context.SaveChanges();*/
        return View();
     }

     public IActionResult ProductoSave()
     {
        return View();
     }



    
    }
}