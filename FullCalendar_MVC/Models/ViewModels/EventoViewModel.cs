﻿using System;

namespace FullCalendar_MVC.Models.ViewModels
{
    public class EventoViewModel
    {
        public String Titulo { get; set; }

        public String DataEvento { get; set; }

        public String HoraEvento { get; set; }

        public String DuracaoEvento { get; set; }

        public String ProfissionalId { get; set; }
    }
}