using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy2.Models
{
    public class Group
    {
        [Key]
        public int group_id { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string? group_name { get; set; } = string.Empty;

        [Column("direction", TypeName = "TINYINT")]
        [ForeignKey(nameof(Direction))]
        public int direction { get; set; }

        [Column("weekdays", TypeName = "TINYINT")]
        public int? learning_days { get; set; }

        [Column("start_time", TypeName = "TIME(0)")]
        public TimeOnly? start_time { get; set; }

        [Column("start_date", TypeName = "DATE")]
        public DateOnly? start_date { get; set; }

        //Navigation properties:
        public Direction? Direction { get; set; } = null!;

        // Добавлено для пункта 6: количество студентов в группе (вычисляется в коде, в БД не хранится)
        [NotMapped]
        public int students_count { get; set; }
    }
}