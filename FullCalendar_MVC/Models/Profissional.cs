﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FullCalendar_MVC.Models
{
    [Table("Profissional")]
    public class Profissional
    {
        [Key]
        public Guid ProfissionalId { get; set; }

        public String Nome { get; set; }

        //Relacionamento com tabela eventos
        public virtual ICollection<Eventos> Eventos { get; set; }
    }
}