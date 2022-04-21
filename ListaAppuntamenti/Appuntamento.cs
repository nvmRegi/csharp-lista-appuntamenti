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
        public bool appuntamentoValido = true;

        public Appuntamento(DateTime dataAppuntamento, string nome, string localitaAppuntamento)
        {
            //controllo la validità della data
            try
            {
                controlloDataAppuntamento(dataAppuntamento); 
            } catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                appuntamentoValido = false;
            }

            this.nome = nome;
            this.localitaAppuntamento = localitaAppuntamento;
        }

        //metodo lancia eccezione se data non valida
        public void controlloDataAppuntamento(DateTime dataAppuntamento) 
        {
            if (dataAppuntamento < DateTime.Now)
            {
                throw new ArgumentOutOfRangeException("dataAppuntamento", "La data inserita è nel passato");
            }
            else
            {
                this.dataAppuntamento = dataAppuntamento;
            }
        }

        public string GetNome() 
        { return this.nome; }

        public DateTime GetDataAppuntamento()
        { return dataAppuntamento; }

        //metodo cambia la data
        public DateTime cambiaData(DateTime nuovaData) 
        {
            appuntamentoValido = true;
            try
            {
                controlloDataAppuntamento(nuovaData);
            } catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                appuntamentoValido = false;
            }
            return this.dataAppuntamento;
        }

        public override string ToString()
        {
            string stampaAppuntamento = "";

            stampaAppuntamento += "\n-------Appuntamento------- \n";
            stampaAppuntamento += "Nome: " + this.nome + "\n";
            stampaAppuntamento += "Data: " + this.dataAppuntamento + "\n";
            stampaAppuntamento += "Località: " + this.localitaAppuntamento + "\n";
            stampaAppuntamento += "--------------------------";
            return stampaAppuntamento;
        }

    }
}
