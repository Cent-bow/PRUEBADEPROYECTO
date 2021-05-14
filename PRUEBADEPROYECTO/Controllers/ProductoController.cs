using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PRUEBADEPROYECTO.Models;
using PRUEBADEPROYECTO.Data;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace PRUEBADEPROYECTO.Controllers
{
    public class ProductoController : Controller
    {

        private readonly ILogger<ProductoController> _logger;
        private readonly ApplicationDbContext _db;
              public ProductoController(ILogger<ProductoController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        public IActionResult Index()
        {
            var Productos = _db.Productos;
            return View(Productos);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Agregar()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Agregar(Producto producto)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(producto).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                // _db.Producto.Add (producto); //
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(producto);
        }
    }
      
    }

