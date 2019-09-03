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

        public override void Validado()
        {
            if (ProdudoId == 0)
            {
                AdicionarCritica("Não foi identificado a referência do Produto");
            }

            if(Quantidade == 0)
            {
                AdicionarCritica("A Quantidade deve ser maior que Zero (0)");
            }
        }
    }
}
