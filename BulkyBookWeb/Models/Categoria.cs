﻿using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Categoria
    {
        //Anotação chave primária
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int OrdemExibicao { get; set; }
        public DateTime HoraCriada { get; set; } = DateTime.Now;
    }
}
