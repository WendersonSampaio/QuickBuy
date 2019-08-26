using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        public int UsuarioId { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public string NumeroEndereco { get; set; }


        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        /// Em um Pedido deverá ter ao menos um item
        /// </summary>
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Valido()
        {
            LimparMensagensValidacao();

            if (!ItensPedido.Any())
                AdicionarCritica("Crítica: Um pedido tem que ter ao menos um item");

            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("Crítica: O CEP é obrigatório!");
            
        }
    }
}
