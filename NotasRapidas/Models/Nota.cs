using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace NotasRapidas.Models
{
    public class Nota
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Titulo { get; set; } = string.Empty;

        public string Contenido { get; set; } = string.Empty;

        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
