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
    //    //ATRIBUTOS 
    //    private double valorNumerico;
    //    private ESistema sistema;
    //    //
    //    //PROPIEDADES
    //    public string Valor { get => this.valorNumerico.ToString(); }
    //    public ESistema Sistem { get => this.sistema; }
    //    //

    //    //CONSTRUCTORES
    //    public Numeracion(double valorNumerico, ESistema sistema)
    //    {
    //        this.valorNumerico = valorNumerico;
    //        this.sistema = sistema;
    //    }
    //    public Numeracion(string valorNumerico, ESistema sistema)
    //    {
    //        this.inicializarValores(valorNumerico, sistema);
    //    }
    //    //

    //    //METODOS
    //    private void inicializarValores(string valor, ESistema sistema)
    //    {
    //        this.sistema = sistema;
    //        if (this.sistema == ESistema.Decimal)
    //        {
    //            double aux;
    //            double.TryParse(valor, out aux);
    //            this.valorNumerico = aux;
    //        }
    //        else
    //        {
    //            this.valorNumerico = this.BinarioADecimal(valor);
    //        }
    //    }

    //    public string ConvertirA(ESistema Sistema)
    //    {
    //        if (this.sistema == Sistema)
    //        {
    //            return this.Valor;
    //        }
    //        else
    //        {
    //            if (ESistema.Decimal == Sistema)
    //            {
    //                return this.BinarioADecimal(this.Valor).ToString();
    //            }
    //            else
    //            {
    //                return this.DecimalABinario(this.Valor);
    //            }
    //        }
    //        //if (ESistema.Decimal == Sistema)
    //        //{
    //        //    if (this.sistema == Sistema)
    //        //    {
    //        //        return this.Valor;
    //        //    }
    //        //    return this.BinarioADecimal(this.Valor).ToString();
    //        //}
    //        //else 
    //        //{
    //        //    if (this.sistema==Sistema) 
    //        //    {
    //        //        return this.Valor;
    //        //    }
    //        //    return this.DecimalABinario(this.Valor);
    //        //}
    //    }
    //    private double BinarioADecimal(string valor)
    //    {
    //        int retorno = 0, potencia = 0;
    //        for (int i = valor.Length - 1; i >= 0; i--)
    //        {
    //            int digito = int.Parse(valor[i].ToString());
    //            retorno += digito * (int)Math.Pow(2, potencia);
    //            potencia++;
    //        }
    //        return retorno;
    //    }
    //    private string DecimalABinario(int numeroEntero)
    //    {
    //        string numero = string.Empty;
    //        while (numeroEntero > 0)
    //        {
    //            numero = (numeroEntero % 2) + numero;
    //            numeroEntero /= 2;
    //        }
    //        return numero;
    //    }
    //    private string DecimalABinario(string valor)
    //    {
    //        int aux;
    //        int.TryParse(valor, out aux);
    //        string numero = string.Empty;
    //        while (aux > 0)
    //        {
    //            numero = (aux % 2) + numero;
    //            aux /= 2;
    //        }
    //        return numero;
    //    }

    //    private bool EsBinario(string valor)
    //    {
    //        char aux = (char)1;
    //        char aux2 = (char)0;
    //        for (int i = 0; i < valor.Length; i++)
    //        {
    //            if (valor[i] != aux || valor[i] != aux2)
    //            {
    //                return false;
    //            }
    //        }
    //        return true;
    //    }
    //    //
    //    //SOBRECARGAS de igualaCION
    //    public static bool operator ==(ESistema sistema, Numeracion numeracion)
    //    {
    //        return sistema == numeracion.sistema;
    //    }
    //    public static bool operator !=(ESistema sistema, Numeracion numeracion)
    //    {
    //        return !(sistema == numeracion);
    //    }
    //    public static bool operator ==(Numeracion n1, Numeracion n2)
    //    {
    //        return n1.sistema == n2.sistema;
    //    }
    //    public static bool operator !=(Numeracion n1, Numeracion n2)
    //    {
    //        return !(n1 == n2);
    //    }
    //    //
    //    //SOBRECARGAS ARITMETICAS
    //    public static Numeracion operator -(Numeracion n1, Numeracion n2)
    //    {
    //        double aux1, aux2;
    //        double.TryParse(n1.Valor, out aux1);
    //        double.TryParse(n2.Valor, out aux2);
    //        return new Numeracion(aux1 - aux2, ESistema.Decimal);
    //    }
    //    public static Numeracion operator +(Numeracion n1, Numeracion n2)
    //    {
    //        double aux1, aux2;
    //        double.TryParse(n1.Valor, out aux1);
    //        double.TryParse(n2.Valor, out aux2);
    //        return new Numeracion(aux1 + aux2, ESistema.Decimal);
    //    }
    //    public static Numeracion operator *(Numeracion n1, Numeracion n2)
    //    {
    //        double aux1, aux2;
    //        double.TryParse(n1.Valor, out aux1);
    //        double.TryParse(n2.Valor, out aux2);
    //        return new Numeracion(aux1 * aux2, ESistema.Decimal);
    //    }
    //    public static Numeracion operator /(Numeracion n1, Numeracion n2)
    //    {
    //        double aux1, aux2;
    //        double.TryParse(n1.Valor, out aux1);
    //        double.TryParse(n2.Valor, out aux2);
    //        return new Numeracion(aux1 / aux2, ESistema.Decimal);
    //    }
    //}
    
}
