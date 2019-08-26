using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> mensagensValidacao { get; set; }

        private List<string> mensagemValidação {
            get { return mensagensValidacao ?? (mensagensValidacao = new List<string>()); }
        }

        public abstract void Valido();

        protected bool EhValido
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
