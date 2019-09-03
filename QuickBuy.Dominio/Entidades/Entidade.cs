using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        private List<string> _mensagensValidacao { get; set; }

        private List<string> mensagemValidação {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        public abstract void Validado();

        protected bool Valido
        {
            get { return !mensagemValidação.Any(); }
        }

        protected void LimparMensagensValidacao()
        {
            mensagemValidação.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            mensagemValidação.Add(mensagem);
        }

    }
}
