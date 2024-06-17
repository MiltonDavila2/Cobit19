using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

namespace Cobit19.Data
{
    public class MetasAlineamientoService
    {
        private readonly DbContextTablas _dbContextTablas;

        public MetasAlineamientoService(DbContextTablas dbContextTablas)
        {
            _dbContextTablas = dbContextTablas;
        }

        public async Task<List<MetasAlineamiento>> GetMetasAlineamientosAsync()
        {
            return await _dbContextTablas.MetasAlineamientos.ToListAsync();
        }

        public async Task<bool> InsertarMetaAlineamiento(MetasAlineamiento metasAlineamiento)
        {
            bool existe= await _dbContextTablas.MetasAlineamientos.AnyAsync(m=>m.MetaGobierno == metasAlineamiento.MetaGobierno);

            if (existe)
            {
                return false;
            }
            await _dbContextTablas.MetasAlineamientos.AddAsync(metasAlineamiento);
            await _dbContextTablas.SaveChangesAsync();

            return true;
        }

        public async Task<MetasAlineamiento> GetMetasAlineamiento(int id)
        {
            MetasAlineamiento metasAlineamiento = await _dbContextTablas.MetasAlineamientos.FirstOrDefaultAsync(m => m.Id.Equals(id));
            return metasAlineamiento;
        }

        public async Task<bool> ActualizarMetasAlineamiento(MetasAlineamiento metasAlineamiento)
        {
            _dbContextTablas.MetasAlineamientos.Update(metasAlineamiento);
            await _dbContextTablas.SaveChangesAsync();
            return true;
        }

        public async Task<bool> BorrarMetasAlineamiento(MetasAlineamiento metasAlineamiento)
        {
            _dbContextTablas.Remove(metasAlineamiento);
            await _dbContextTablas.SaveChangesAsync(); return true;
        }


    }
}
