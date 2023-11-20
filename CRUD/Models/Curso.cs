using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD.Models
{
	[Table("Curso")]
	public class Curso
	{
		[Key]
		[Column("Id")]
        public int Id { get; set; }
		[Column("NomeCurso")]
		[Display(Name ="Nome do Curso")]
		public string NomeCurso { get; set; }
		[Column("MateriaCurso")]
		[Display(Name = "Matéria do Curso")]
		public string MateriaCurso { get; set; }
		[Column("NomeProfessor")]
		[Display(Name = "Nome do Professor")]
		public string NomeProfessor { get; set; }
		[Column("EmailProfessor")]
		[Display(Name = "Email do Professor")]
		
		public string EmailProfessor { get; set; }
	}
}
