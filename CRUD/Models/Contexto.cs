using Microsoft.EntityFrameworkCore;

namespace CRUD.Models
{
	public class Contexto : DbContext
	{
		public Contexto(DbContextOptions<Contexto> options) : base(options)
		{

		}

		public DbSet<Curso> Curso { get; set; }

	}
}

