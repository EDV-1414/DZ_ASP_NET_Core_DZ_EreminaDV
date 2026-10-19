using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy2.Models
{
    public class Teacher
    {
        [Key]
        [Column("teacher_id")]
        public short teacher_id { get; set; }

        [Column("last_name")]
        public string? last_name { get; set; }

        [Column("first_name")]
        public string? first_name { get; set; }

        [Column("middle_name")]
        public string? middle_name { get; set; }

        [Column("birth_date", TypeName = "DATE")]
        public DateOnly? birth_date { get; set; }

        [Column("email")]
        public string? email { get; set; }

        [Column("phone")]
        public string? phone { get; set; }

        [Column("photo")]
        public byte[]? photo { get; set; }

        [Column("work_since", TypeName = "DATE")]
        public DateOnly? work_since { get; set; }

        [Column("rate", TypeName = "SMALLMONEY")]
        public decimal? rate { get; set; }
    }
}
