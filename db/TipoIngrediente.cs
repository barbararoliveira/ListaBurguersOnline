﻿using System;
using System.Collections.Generic;

namespace listaburguersonline.db
{
    public partial class TipoIngrediente
    {
        public TipoIngrediente()
        {
            Ingrediente = new HashSet<Ingrediente>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Ingrediente> Ingrediente { get; set; }
    }
}
