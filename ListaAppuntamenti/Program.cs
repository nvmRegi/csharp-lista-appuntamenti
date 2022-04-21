using ListaAppuntamenti;

Console.WriteLine("BENVENUTO NELLA MIA AGENDA PERSONALE!\n");

List<Appuntamento> listaAppuntamenti = new List<Appuntamento>();

Console.Write("Quanti appuntamenti vuoi inserire? ");
int numeroAppuntamenti = Convert.ToInt32(Console.ReadLine());

DateTime dataUtente;
string nomeAppuntamento;
string localita;

while(numeroAppuntamenti > 0)
{
    Console.Write("Inserisci il nome dell'evento: ");
    nomeAppuntamento = Console.ReadLine();
    Console.Write("Inserisci la data dell'evento: ");
    dataUtente = DateTime.Parse(Console.ReadLine());
    Console.Write("Inserisci la località: ");
    localita = Console.ReadLine();

    listaAppuntamenti.Add(new Appuntamento(dataUtente, nomeAppuntamento, localita));
    if (listaAppuntamenti[listaAppuntamenti.Count-1].appuntamentoValido)
    {
        numeroAppuntamenti--;
    } else
    {
        Console.WriteLine("Riscrivere i dati dell'appuntamento.");
    }
    
}

scansionaLista();

Console.ReadKey();

Console.WriteLine("\nVuoi modificare un appuntamento? (si/no) ");

string risposta = Console.ReadLine();
if(risposta == "si")
{
    string ricercaNomeAppuntamento = Console.ReadLine();

    int indiceNome = 0;
    for(int i = 0; i < listaAppuntamenti.Count; i++)
    {
        if (ricercaNomeAppuntamento == listaAppuntamenti[i].GetNome())
        {
            indiceNome = i;
        }
    }

    Console.WriteLine("Inserire la nuova data: ");
    DateTime nuovaData = DateTime.Parse(Console.ReadLine());

    do
    {
        listaAppuntamenti[indiceNome].cambiaData(nuovaData);
    } while (!listaAppuntamenti[listaAppuntamenti.Count - 1].appuntamentoValido);
    

    scansionaLista();

    Console.ReadKey();
    Console.Clear();
}
else if(risposta == "no")
{
    Console.WriteLine("ARRIVEDERCI!");
}


//Funzione stampa
void scansionaLista()
{
    foreach (Appuntamento elementoAppuntamento in listaAppuntamenti)
    {
        Console.WriteLine(elementoAppuntamento.ToString());
    }
}
