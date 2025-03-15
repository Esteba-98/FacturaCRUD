using FacturaCRUD.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FacturaCRUD.Services
{
    public class FacturaService
    {
        private readonly GestionFacturasContext _context;

        public FacturaService(GestionFacturasContext context)
        {
            _context = context;
        }

        // Obtener todas las facturas (Estado se calculará automáticamente en el modelo)
        public async Task<List<Factura>> ObtenerFacturasAsync()
        {
            return await _context.Facturas.ToListAsync();
        }

        // Obtener una factura por ID
        public async Task<Factura> ObtenerFacturaPorIdAsync(int id)
        {
            return await _context.Facturas.FindAsync(id);
        }

        // Agregar nueva factura
        public async Task<bool> AgregarFacturaAsync(Factura factura)
        {
            _context.Facturas.Add(factura);
            await _context.SaveChangesAsync();
            return true;
        }

        // Editar factura existente
        public async Task<bool> EditarFacturaAsync(Factura factura)
        {
            _context.Update(factura);
            await _context.SaveChangesAsync();
            return true;
        }

        // Eliminar factura
        public async Task<bool> EliminarFacturaAsync(int id)
        {
            var factura = await _context.Facturas.FindAsync(id);
            if (factura == null) return false;

            _context.Facturas.Remove(factura);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
