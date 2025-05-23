﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotasUnivoDev.Models
{
    public class CareersSubjectsModel:BaseModel
    {
        [Key]
        public int CareerSubjectId { get; set; }
        [ForeignKey(nameof(CareerId))]
        public int CareerId { get; set; }
        [ForeignKey(nameof(SubjectId))]
        public int SubjectId { get; set; }
        public int Cycle { get; set; }

        public virtual CareersModel Career { get; set; }
        public virtual SubjectsModel Subject { get; set; }

    }
}
