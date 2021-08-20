using Microsoft.AspNetCore.Mvc;
using formulario1.Models;

namespace formulario1.Controllers
{
    public class VentaProductoController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Vender(VentaProducto Provender)
        {
            double subtotal=0;
            double total=0;
            double igv=1.18;

            subtotal =Provender.Cantidad*Provender.Precio;
            total = subtotal*igv;

            ViewData["Message"] = "El total del producto es: "+ total;
            return View("Index");
        }
    }
}