using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Survey.Entities
{
    [Table("surveys")]
    public partial class Surveys
    {
        public Surveys()
        {
        }

        [Key]
        [Column("survey_id")]
        public long SurveyId { get; set; }
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
