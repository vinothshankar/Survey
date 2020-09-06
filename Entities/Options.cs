using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Survey.Entities
{
    [Table("options")]
    public partial class Options
    {
        public Options()
        {
        }

        [Key]
        [Column("option_id")]
        public long OptionId { get; set; }
        [Column("question_id")]
        public long QuestionId { get; set; }
        [Required]
        [Column("text", TypeName = "text")]
        public string Text { get; set; }


    }
}
