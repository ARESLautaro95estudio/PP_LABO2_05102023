using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        private string nombreAlumno;
        private List<string> operaciones;
        private Numeracion primerOperando, segundoOperando,resultado;
        private static ESistema sistema;

        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public List<string> Operaciones { get => operaciones; }
        public Numeracion PrimerOperando { get => primerOperando; set => primerOperando = value; }
        public Numeracion SegundoOperando { get => segundoOperando; set => segundoOperando = value; }
        public Numeracion Resultado { get => resultado;  }
        public static ESistema Sistema { get => sistema; set => sistema = value; }

        static Calculadora()
        {
            Calculadora.Sistema = ESistema.Decimal;
        }
        public Calculadora()
        { 
            this.operaciones= new List<string>();
        }
        public Calculadora(string nombreAlumno) : this()
        { 
            this.NombreAlumno=nombreAlumno;
        }

        public void Calcular()
        {
            if (this.primerOperando.GetType() == this.SegundoOperando.GetType())
            {
                this.resultado = this.Mapearesultado(this.PrimerOperando.ValorNumerico + this.SegundoOperando.ValorNumerico);
            }
            this.resultado = this.Mapearesultado((double.MinValue));
        }
        public void Calcular(char operador)
        {
            if (this.primerOperando.GetType() == this.SegundoOperando.GetType())
            {
                //if (this.primerOperando.GetType()==typeof(SistemaBinario)) 
                //{
                //    this.primerOperando.CambiarSistemaDeNumeracion(ESistema.Decimal);
                //    this.SegundoOperando.CambiarSistemaDeNumeracion(ESistema.Decimal);
                    switch (operador)
                    {
                        case '+':
                            this.resultado = this.Mapearesultado(this.PrimerOperando.ValorNumerico + this.SegundoOperando.ValorNumerico);
                            break;
                        case '-':
                            this.resultado = this.Mapearesultado(this.PrimerOperando.ValorNumerico - this.SegundoOperando.ValorNumerico);
                            break;
                        case '/':
                            this.resultado = this.Mapearesultado(this.PrimerOperando.ValorNumerico / this.SegundoOperando.ValorNumerico);
                            break;
                        case '*':
                            this.resultado = this.Mapearesultado(this.PrimerOperando.ValorNumerico * this.SegundoOperando.ValorNumerico);
                            break;
                    //}
                }
                
            }
            else { this.resultado = this.Mapearesultado((double.MinValue)); }
        }
        private Numeracion Mapearesultado(double valor)
        {
            if (Calculadora.Sistema == ESistema.Binario)
            {
                SistemaDecimal aux = new SistemaDecimal(valor.ToString());
                return aux.CambiarSistemaDeNumeracion(Calculadora.Sistema);

                //return new SistemaBinario(aux.Valor);
            }
            else 
            {
                return new SistemaDecimal(valor.ToString());
            }
        }
        public void ActualizarHistorialDeOperaciones(char operador)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Sistema:{Calculadora.Sistema.ToString()} ");
            sb.AppendLine($"{this.PrimerOperando.Valor} ");
            sb.AppendLine($"{operador} ");
            sb.AppendLine($"{this.SegundoOperando.Valor}");
            
            this.operaciones.Add(sb.ToString());
        }
        public void EliminarHistorialDeOperaciones()
        {
            this.operaciones.Clear();
        }
    }
}