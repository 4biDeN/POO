using E2.Classes;

class Program
{
    static void Main(string[] args)
    {
        var minhaAgenda = new Agenda();

        var amigo = new Amigo("João", "1234-5678", new DateTime(1990, 5, 15));
        var profissional = new ContatoProfissional("Maria", "8765-4321", "Tech Corp");
        var evento = new Evento("Conferência de TI", "1234-0000", new DateTime(2024, 9, 10), "Centro de Convenções");
        var compromisso = new Compromisso("Reunião de Projeto", "5555-1234", new DateTime(2024, 8, 15), DateTime.Now.AddDays(1), "Sala de Reuniões");

        minhaAgenda.AdicionarContato(amigo);
        minhaAgenda.AdicionarContato(profissional);
        minhaAgenda.AdicionarContato(evento);
        minhaAgenda.AdicionarContato(compromisso);

        Console.WriteLine("Lista de Contatos e Eventos:");
        minhaAgenda.ExibirContatos();

        Console.WriteLine("\nEnviando Lembretes:");
        minhaAgenda.EnviarLembretes();

        // Espera pela entrada de uma tecla para fechar o console
        Console.WriteLine("\nPressione qualquer tecla para fechar...");
        Console.ReadKey();
    }
}