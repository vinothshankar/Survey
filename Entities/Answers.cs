using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Survey.Entities
{
    [Table("answers")]
    public partial class Answers
    {
        [Key]
        [Column("answer_id")]
        public long AnswerId { get; set; }
        [Column("question_id")]
        public long QuestionId { get; set; }
        [Column("option_id")]
        public long OptionId { get; set; }
        [Required]
        [Column("user_nm")]
        [StringLength(128)]
        public string UserNm { get; set; }

    }
}
