using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAppuntamenti
{
    internal class Appuntamento //salva e gestisce gli appuntamenti
    {
        public DateTime dataAppuntamento;
        public string nome;
        public string localitaAppuntamento;

        public Appuntamento(DateTime dataAppuntamento, string nome, string localitaAppuntamento)
        {
            this.dataAppuntamento = dataAppuntamento;

            //controllo la validità della data
            controlloDataAppuntamento(); 

            this.nome = nome;
            this.localitaAppuntamento = localitaAppuntamento;
        }

        //metodo lancia eccezione se data non valida
        private void controlloDataAppuntamento() 
        {
            if (this.dataAppuntamento < DateTime.Now)
            {
                throw new InvalidTimeZoneException("Data non valida");
            }
        }

        //metodo cambia la data
        public DateTime cambiaData(DateTime nuovaData) 
        {
            if (nuovaData < DateTime.Now)
            {
                throw new InvalidTimeZoneException("Data non valida");
            }
            else 
            { 
                this.dataAppuntamento = nuovaData;
            }
            return this.dataAppuntamento;
        }
        
    }
}
