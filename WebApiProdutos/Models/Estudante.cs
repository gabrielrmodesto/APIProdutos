using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiProdutos.Models
{
    public class Estudante
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public string Genero { get; set; }
        public int Idade { get; set; }
    }
}