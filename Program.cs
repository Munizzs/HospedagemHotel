using ExercicioHospedagem.models;

Console.WriteLine("--------------------Hospedagem--------------------");


Console.WriteLine("\n\n|SUITE|");

System.Console.WriteLine("Digite a quantidade de dias reservados:");
int reserva = int.Parse(Console.ReadLine());
Reserva r = new Reserva(reserva);

Console.WriteLine("\nDigite o tipo de suite:");
string tipo = Console.ReadLine();

Console.WriteLine("Digite a capacidade da suite:");
int cap = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor da diaria:");
decimal valor = decimal.Parse(Console.ReadLine());

Suite suit = new Suite(tipo,cap,valor);
r.CadastrarSuite(suit);

int o;

do
{
    Console.WriteLine("\n\nSelecione:\n1. Cadastrar Hospede\n0. Sair");
    o = int.Parse(Console.ReadLine());

    switch(o)
    {
        case 1:
            Console.WriteLine("\nDigite o nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o Sobrenome:");
            string sobre = Console.ReadLine();

            Pessoa pes = new Pessoa(nome,sobre);
            r.CadastrarHospedes(pessoa: pes);
        break;
    }
}while(o!=0);

if(r.ObterQuantidadeHospedes() == -1)
{
    System.Console.WriteLine("\nCapacide maxima da suite ultrapasada");
    Environment.Exit(0);
}

Console.WriteLine($"\n\nSuíte:{suit.TipoSuite}");
Console.WriteLine($"Hóspedes: {r.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {r.CalcularValorDiaria().ToString("C")}");

