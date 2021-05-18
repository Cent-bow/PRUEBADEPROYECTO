using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRUEBADEPROYECTO.Controllers
{
    public class AdministradorController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public AdministradorController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CrearRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CrearRole(string Nombre)
        {
           await _roleManager.CreateAsync(new IdentityRole(Nombre));
            return View();
        }

       


    }
}
