﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Pessoa
    {
        public string Email { get; set; }
        public string Endereco { get; set; }
        //      public List<Telefone> Telefones { get; set; }

        public Pessoa(string email, string end)
        {
            this.Email = email;
            this.Endereco = end;
        }
    }
}
