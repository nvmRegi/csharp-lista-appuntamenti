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

    numeroAppuntamenti--;
}

foreach (Appuntamento elementoAppuntamento in listaAppuntamenti)
{
    Console.WriteLine(elementoAppuntamento.ToString());
}