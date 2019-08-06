using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProHaus.PortalOnline.Dominio.Entidades
{
    public abstract class Entidade
    {
        private List<string> _mensagemValidacao { get; set; }
        private List<string> MensagemValidacacao {
            get { return _mensagemValidacao ?? (_mensagemValidacao = new List<string>()); }
            
         }

        protected void LimparMensagemValidacao()
        {
            MensagemValidacacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            MensagemValidacacao.Add(mensagem);
        }
        public abstract void Validate();

        /// <summary>
        /// Se não houver nenhuma regra de negocio violada, consideramos a classe valida.
        /// </summary>
        protected bool EhValido
        {
            get { return !MensagemValidacacao.Any(); }
        }
    }
}
