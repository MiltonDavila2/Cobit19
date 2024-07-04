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
            var prioridad = new List<string>
            {
                "Cumplimiento y soporte de I&T",
                "Gestión de riesgo relacionado con I&T",
                "Beneficios obtenidos del portafolio de inversiones",
                "Calidad de la información financiera",
                "Prestación de servicios de I&T",
                "Agilidad para convertir los requisitos",
                "Seguridad de la información",
                "Habilidad y dar soporte a procesos de negocio",
                "Ejecución de programas dentro del plazo",
                "Calidad de la información sobre gestión de I&T",
                "Cumplimiento de I&T con las políticas internas",
                "Personal competente y motivado",
                "Conocimiento, experiencia e iniciativas"
            };

            var metas = await _dbContextTablas.MetasEmpresarialess.ToListAsync();

            return metas.OrderBy(m => prioridad.IndexOf(m.MetaAlineamiento)).ToList();
        }


        public async Task<int> ContarMetasEmpresarialesAsync()
        {
            return await _dbContextTablas.MetasEmpresarialess.CountAsync();
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
