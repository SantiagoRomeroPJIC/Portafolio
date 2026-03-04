using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<ProyectoDTO> ObtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {
    
        public List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO>() { new ProyectoDTO
            {
                Titulo="E-Poli",
                Descripcion="Repositorio de proyecto web realizado con Java y Springboot en mi proceso formativo en  PJIC",
                Link="https://github.com/SantiagoRomeroPJIC/e-poli",
                ImagenURL="/imagenes/GitHub_Logo.png"
            },
                new ProyectoDTO
             {
                Titulo="Peluqueria Juanita",
                Descripcion="Repositorio de aplicativo de escritorio, realizado con Java en mi proceso formativo en  PJIC",
                Link="https://github.com/SantiagoRomeroPJIC/PPI-Juanita",
                ImagenURL="/imagenes/GitHub_Logo.png"
             }
            };
        }
    }
}
