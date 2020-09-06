using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Survey.Entities
{
    [Table("questions")]
    public partial class Questions
    {
        public Questions()
        {

        }

        [Key]
        [Column("question_id")]
        public long QuestionId { get; set; }
        [Column("survey_id")]
        public long SurveyId { get; set; }
        [Required]
        [Column("title", TypeName = "text")]
        public string Title { get; set; }
        [Column("sub_title", TypeName = "text")]
        public string SubTitle { get; set; }
        [Column("question_typ")]
        public int? QuestionTyp { get; set; }
        [Required]
        [Column("created_by")]
        [StringLength(128)]
        public string CreatedBy { get; set; }
        [Column("created_date", TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        [NotMapped]
        public List<Options> options { get; set; }

    }
}
