using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace NotasRapidas.Models
{
    public class Historial
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Accion { get; set; } = string.Empty;

        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}