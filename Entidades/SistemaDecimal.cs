using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaDecimal : Numeracion
    {
        public SistemaDecimal(string valor) : base(valor)
        {
        }
        public static implicit operator SistemaDecimal(double aux)
        { 
            return new SistemaDecimal(aux.ToString());
        }
        public static implicit operator SistemaDecimal(string valor)
        { 
            return new SistemaDecimal(valor);
        }
        internal override double ValorNumerico
        {
            get 
            {
                if (this.EsSistemaDecimalValido(this.valor))
                {
                    return double.Parse(this.valor);
                }
                return -1;
            }
        }
        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
            {
                if (sistema == ESistema.Binario)
                {
                        //new SistemaBinario(this.valor);

                    return new SistemaBinario(this.DecimalABinario());
                }
                return new SistemaDecimal(this.valor);
            }
        private string DecimalABinario()
            {
                int aux;
                int.TryParse(base.valor, out aux);
                string numero = string.Empty;
                if (aux > 0)
                {
                    while (aux > 0)
                    {
                        numero = (aux % 2) + numero;
                        aux /= 2;
                    }
                    //this.valor = numero;
                    return numero;
                }
                return Numeracion.msgError;
            }
        public bool EsNumeracionValida(string valor) 
        {
            if (base.EsNumeracionValida(valor) && this.EsSistemaDecimalValido(valor))
            {
                return true;
            }
            return false;
        }
        private bool EsSistemaDecimalValido(string valor)
        {
            return (double.TryParse(valor, out double aux));
        }
    }
}
