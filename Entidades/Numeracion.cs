using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Numeracion
    {
        protected static string msgError;
        protected string valor;
        public string Valor { get => this.valor; }
        internal abstract double ValorNumerico { get; }

        static Numeracion()
        {
            /// <summary>
            /// Constructor de clase encargado de declarar el atributo de clases
            /// </summary>
            Numeracion.msgError = "Numero invalido";
        }
        protected Numeracion(string valor)
        {
            this.inicializaValor(valor);
        }

        public static explicit operator double(Numeracion numeracion)
        {
            return double.Parse(numeracion.valor);
        }
        private void inicializaValor(string valor)
        {
            if (this.EsNumeracionValida(valor))
            {
                this.valor = valor;
            }
            //this.valor = Numeracion.msgError;
            this.valor = valor;
        }

        public abstract Numeracion CambiarSistemaDeNumeracion(ESistema sistema);

        protected bool EsNumeracionValida(string valor)
        {
            if (valor != null && valor != string.Empty)
            {
                return true;
            }
            return false;
        }
        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            if (n1 != null && n2 != null && n1.GetType() == n2.GetType())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return !(n1 == n2);
        }
    }
       
}
