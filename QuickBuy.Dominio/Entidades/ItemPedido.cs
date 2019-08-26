using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }

        public int PedidoId { get; set; }

        public int ProdudoId { get; set; }

        public int Quantidade { get; set; }

        public override void Valido()
        {
            throw new NotImplementedException();
        }
    }
}
