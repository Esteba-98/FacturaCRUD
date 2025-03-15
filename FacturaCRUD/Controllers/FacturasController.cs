using FacturaCRUD.Models;
using FacturaCRUD.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FacturaCRUD.Controllers
{
    public class FacturasController : Controller
    {
        private readonly FacturaService _facturaService;

        public FacturasController(FacturaService facturaService)
        {
            _facturaService = facturaService;
        }

        // GET: Facturas
        public async Task<IActionResult> Index()
        {
            return View(await _facturaService.ObtenerFacturasAsync());
        }

        // GET: Facturas/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var factura = await _facturaService.ObtenerFacturaPorIdAsync(id);
            if (factura == null) return NotFound();
            return View(factura);
        }

        // GET: Facturas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Facturas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Factura factura)
        {
            if (!ModelState.IsValid) return View(factura);

            await _facturaService.AgregarFacturaAsync(factura);
            return RedirectToAction(nameof(Index));
        }

        // GET: Facturas/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var factura = await _facturaService.ObtenerFacturaPorIdAsync(id);
            if (factura == null) return NotFound();
            return View(factura);
        }

        // POST: Facturas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Factura factura)
        {
            if (!ModelState.IsValid) return View(factura);

            await _facturaService.EditarFacturaAsync(factura);
            return RedirectToAction(nameof(Index));
        }

        // GET: Facturas/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var factura = await _facturaService.ObtenerFacturaPorIdAsync(id);
            if (factura == null) return NotFound();
            return View(factura);
        }

        // POST: Facturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var factura = await _facturaService.ObtenerFacturaPorIdAsync(id);
            if (factura == null) return NotFound();

            await _facturaService.EliminarFacturaAsync(id);
            return Json(new { success = true, message = $"Factura {factura.NumeroFactura} eliminada correctamente." });
        }

        // GET: Facturas/GetFactura/5
        public async Task<IActionResult> GetFactura(int id)
        {
            var factura = await _facturaService.ObtenerFacturaPorIdAsync(id);
            if (factura == null) return NotFound();
            return Json(factura);
        }
    }
}
