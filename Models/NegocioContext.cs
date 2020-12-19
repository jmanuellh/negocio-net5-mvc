namespace negocio_net5_mvc.Models
{
    public class NegocioContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public NegocioContext(Microsoft.EntityFrameworkCore.DbContextOptions<NegocioContext> options)
            : base(options)
        {}

        public Microsoft.EntityFrameworkCore.DbSet<Home.Persona> Personas {get;set;}
    }
}
