
using Estacionamento.classes;



int precoNormal;
int precoHora;

Console.WriteLine("1 - Preço padrão:");
precoNormal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Preço por hora:");
precoHora = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite sua opção: ");
Console.WriteLine("1 - Cadastrar veículo ");
Console.WriteLine("2 - Remover veículo ");
Console.WriteLine("3 - Listar veículos ");
Console.WriteLine("4 - Encerrar ");

var escolha = Console.ReadLine();
Console.WriteLine("Qual a sua placa?");
var placa = Console.ReadLine();


List<string> listaString = new List<string>();

string[] placas = new string[3];

placas[0] = placa;
placas[1] = "ATX-344";
placas[2] = "BMW-433";


switch(escolha){
    case "1":
     Console.WriteLine("Digite a placa do veiculo:");
     Console.ReadLine();
    break;

    case "2":
      Console.WriteLine("Quantas horas você ficou estacionado?");
      int horas;
      horas = Convert.ToInt32(Console.ReadLine());
      if (horas > 1){
       Console.WriteLine($"O preço a se pagar é {precoNormal} + {precoHora + horas} = {precoNormal + (precoHora + horas)}");
      } else{
       Console.WriteLine($"O preço é {precoNormal}");
      }
      Console.WriteLine("Como deseja realizar o pagamento?");
      Console.ReadLine();
      Console.WriteLine($"Pagamento realizado! Veículo de placa: {placa} saiu do estacionamento");
    break;

    case "3":
     Console.WriteLine("Os veículos no estacionamento são:");
     foreach (string carros in placas){
        Console.WriteLine($"{carros}");
     }
    break;

    case "4":
      Console.WriteLine("Encerrando");
      Environment.Exit(0);
    break;

    default:
    Console.WriteLine("Inválido");
    break;
}

