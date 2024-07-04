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

        public async Task<int> ContarMetasAlineamientosAsync()
        {
            return await _dbContextTablas.MetasAlineamientos.CountAsync();
        }

        public async Task<List<MetasAlineamiento>> GetMetasAlineamientosAsync()
        {

            var prioridades = new List<string>
            {
                "Asegurar el establecimiento y el mantenimiento del marco de gobierno",
                "Asegurar la obtención de beneficios",
                "Asegurar la optimización del riesgo",
                "Asegurar la optimización de los recursos",
                "Asegurar el compromiso de las partes interesadas",
                "Gestionar el marco de gestión de I&T",
                "Gestionar la estrategia",
                "Gestionar la arquitectura empresarial",
                "Gestionar la innovación",
                "Gestionar el portafolio",
                "Gestionar el presupuesto y los costes",
                "Gestionar los recursos humanos",
                "Gestionar las relaciones",
                "Gestionar los acuerdos de servicio",
                "Gestionar los proveedores",
                "Gestionar la calidad",
                "Gestionar el riesgo",
                "Gestionar la seguridad",
                "Gestionar los datos",
                "Gestionar los programas",
                "Gestionar la definición de requisitos",
                "Gestionar la identificación y construcción de soluciones",
                "Gestionar la disponibilidad",
                "Gestionar el cambio organizativo",
                "Gestionar los cambios de TI",
                "Gestionar la aceptación y la transición de los cambios de TI",
                "Gestionar el conocimiento",
                "Gestionar los activos",
                "Gestionar la configuración",
                "Gestionar los proyectos",
                "Gestionar las operaciones",
                "Gestionar las peticiones y los incidentes de servicio",
                "Gestionar los problemas",
                "Gestionar la continuidad",
                "Gestionar los servicios de seguridad",
                "Gestionar los controles de procesos de negocio",
                "Gestionar la monitorización del desempeño y la conformidad",
                "Gestionar el sistema de control interno",
                "Gestionar el cumplimiento de los requisitos externos",
                "Gestionar el aseguramiento"
            };


            var metas = await _dbContextTablas.MetasAlineamientos.ToListAsync();

            return metas.OrderBy(m => prioridades.IndexOf(m.MetaGobierno)).ToList();
        }

        public async Task<bool> InsertarMetaAlineamientoAsync(MetasAlineamiento metasAlineamiento)
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
