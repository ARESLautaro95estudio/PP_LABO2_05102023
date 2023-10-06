using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaBinario:Numeracion
    {
        public SistemaBinario(string valor):base (valor) 
        { 
        }

        public static implicit operator SistemaBinario(string valor)
        { 
            return new SistemaBinario(valor);
        }

        internal override double ValorNumerico 
        {
            get
            {
                return double.Parse(this.valor);
                //if (this.esNumeracionValida(this.valor))
                //{
                   
                //}
                //else { return -15; }//double.MinValue; }
            }
        }
        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if (sistema == ESistema.Binario)
            {
                return new SistemaBinario(base.Valor);
            }

            return this.BinarioADecimal();
            return new SistemaDecimal(base.Valor);
        }
        protected bool esNumeracionValida(String valor) 
        {
            return base.EsNumeracionValida(valor) && this.EsSistemaBinarioValido(valor);
        } 
        private bool EsSistemaBinarioValido(String valor) 
        {
            foreach (var i in valor)
            {
                if (i != '0' && i != '1')
                    return false;
            }
            return true;
        }
        private SistemaDecimal BinarioADecimal()
        {
            if (base.valor != Numeracion.msgError)
            {
                int retorno = 0, potencia = 0;
                for (int i = base.valor.Length - 1; i >= 0; i--)
                {
                    int digito = int.Parse(valor[i].ToString());
                    retorno += digito * (int)Math.Pow(2, potencia);
                    potencia++;
                }
                return new SistemaDecimal(retorno.ToString());
            }
            return double.MinValue;

        }
    }
}
