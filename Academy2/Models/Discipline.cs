using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy2.Models
{
    [Table("Disciplines")]
    public class Discipline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "SMALLINT")]
        public int discipline_id { get; set; }

        [Required]
        [StringLength(150)]
        [Column(TypeName = "NVARCHAR(150)")]
        public string discipline_name { get; set; }

        [Required]
        [Column(TypeName = "TINYINT")]
        public int number_of_lessons { get; set; }

        // Связь с преподавателями (оставили как было, но добавили инициализацию)
        public ICollection<Teacher>? Teachers { get; set; } = new List<Teacher>();

        // НОВОЕ: Связь с направлениями (многие ко многим)
        public ICollection<Direction>? Directions { get; set; } = new List<Direction>();
    }
}