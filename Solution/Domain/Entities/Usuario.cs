﻿
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Utils.Enum.Enums;

namespace Domain.Entities
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public string DNI { get; set; }
        public DateTime FechaNac { get; set; }

        [DefaultValue(Estados.Active)]
        public Estados Estado { get; set; }

        public int EventoId { get; set; }
        public Evento Evento { get; set; }
    }
}

