using System;
using ZeroToHero.Models.Enums;

namespace ZeroToHero.Models
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime AssistidoEm { get; set; }
        public Status Status { get; set; }
        public string Genero { get; set; }
        public string Sinopse { get; set; }
        public Elenco Elenco { get; set; }
    }
}
