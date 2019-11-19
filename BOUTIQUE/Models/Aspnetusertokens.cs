using System;
using System.Collections.Generic;

namespace BOUTIQUE.Models
{
    public partial class Aspnetusertokens
    {
        public string UserId { get; set; }
        public string LoginProvider { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public Aspnetusers User { get; set; }
    }
}
