using QuickBuy.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        #region Definição da Forma de Pagamento
        public bool CartaoCredito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; }
        }

        public bool CartaoDebito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoDebito; }
        }

        public bool Boleto
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Boleto; }
        }

        public bool NaoDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }
        #endregion
    }
}
