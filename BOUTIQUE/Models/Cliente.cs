using System;
using System.Collections.Generic;

namespace BOUTIQUE.Models
{
    public partial class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
    }
}
