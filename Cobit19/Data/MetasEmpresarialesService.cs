using Microsoft.EntityFrameworkCore;

namespace Cobit19.Data
{
    public class MetasEmpresarialesService
    {
        private readonly DbContextTablas _dbContextTablas;

        public MetasEmpresarialesService(DbContextTablas dbContextTablas)
        {
            _dbContextTablas = dbContextTablas;
        }


        public async Task<List<MetasEmpresariales>> GetMetasEmpresarialesAsync()
        {
            return await _dbContextTablas.MetasEmpresarialess.ToListAsync();
        }

        public async Task<bool> InsertarMetaEmpresarialAsync(MetasEmpresariales metasEmpresariales)
        {

            bool existe = await _dbContextTablas.MetasEmpresarialess.AnyAsync(m=>m.MetaAlineamiento == metasEmpresariales.MetaAlineamiento);
            
            if (existe)
            {
                return false;
            }

            await _dbContextTablas.MetasEmpresarialess.AddAsync(metasEmpresariales);
            await _dbContextTablas.SaveChangesAsync();
            return true;

        }


        public async Task<MetasEmpresariales> GetMetasEmpresarialesAsync(int id)
        {
            MetasEmpresariales metasEmpresariales = await _dbContextTablas.MetasEmpresarialess.FirstOrDefaultAsync(m=>m.Id.Equals(id));
            return metasEmpresariales;
        }

        public async Task<bool> ActualizarMetaEmpresarial(MetasEmpresariales metasEmpresariales)
        {
            _dbContextTablas.MetasEmpresarialess.Update(metasEmpresariales);
            await _dbContextTablas.SaveChangesAsync();
            return true;
        }

        public async Task<bool> BorrarMetaEmpresarial(MetasEmpresariales metasEmpresariales)
        {
            _dbContextTablas.Remove(metasEmpresariales);
            await _dbContextTablas.SaveChangesAsync();
            return true;
        }
    }
}
