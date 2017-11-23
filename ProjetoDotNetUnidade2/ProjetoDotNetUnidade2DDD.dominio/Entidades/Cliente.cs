using System;
using System.Collections.Generic;

namespace ProjetoDotNetUnidade2DDD.dominio.Entidades
{
    public class Cliente
    {

        public int ClienteID { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public bool Ativo { get; set; }

        public virtual IEnumerable<Produto> Produtos { get; set; }

        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.Ativo;
        }
         

        }
}
