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
        private string nome;
        private string localitaAppuntamento;

        public Appuntamento(DateTime dataAppuntamento, string nome, string localitaAppuntamento)
        {
            //controllo la validità della data
            try
            {
                controlloDataAppuntamento(this.dataAppuntamento); 
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            this.nome = nome;
            this.localitaAppuntamento = localitaAppuntamento;
        }

        //metodo lancia eccezione se data non valida
        public void controlloDataAppuntamento(DateTime dataAppuntamento) 
        {
            if (dataAppuntamento < DateTime.Now)
            {
                throw new ArgumentOutOfRangeException("Data non valida");
            }
            else
            {
                this.dataAppuntamento = dataAppuntamento;
            }
        }

        public DateTime GetDataAppuntamento()
        { return dataAppuntamento; }

        //metodo cambia la data
        public DateTime cambiaData(DateTime nuovaData) 
        {
            controlloDataAppuntamento(nuovaData);
            return this.dataAppuntamento;
        }

        public override string ToString()
        {
            string stampaAppuntamento = "";

            stampaAppuntamento += "-----Appuntamento----- \n";
            stampaAppuntamento += "Nome: " + this.nome + "\n";
            stampaAppuntamento += "Data: " + this.dataAppuntamento + "\n";
            stampaAppuntamento += "Località: " + this.localitaAppuntamento + "\n";
            
            return stampaAppuntamento;
        }

    }
}
