using DIO_C_.Models;


// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("PE");
// listaString.Add("RJ");
// listaString.Add("PB");

// Console.WriteLine($"Lista de estados: {listaString.Count}; Capacidade da lista: {listaString.Capacity}");

// listaString.Add("SC");

// Console.WriteLine($"Lista de estados: {listaString.Count}; Capacidade da lista: {listaString.Capacity}");

// listaString.Remove("SP");

// Console.WriteLine($"Lista de estados: {listaString.Count}; Capacidade da lista: {listaString.Capacity}");

// for(int contador= 0; contador < listaString.Count; contador++){
//     Console.WriteLine($"Posição N°: {contador} - {listaString[contador]}");
// }


// foreach(string lista in listaString){
//   Console.WriteLine($"{listaString}");
// }







// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;

// int[] arrayInteirosDobrados = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length);
// // Array.Resize(ref arrayInteiros ,arrayInteiros.Length * 2);

// for(int contador = 0; contador  < arrayInteiros.Length; contador++){
//   Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
// }






// Console.WriteLine("Percorrendo o Array com foreach");

// foreach(int valor in arrayInteiros){
//   Console.WriteLine(valor);
// }


















//string opcao;
// bool exibirMenu = true;

// while(exibirMenu){
//     Console.Clear(); //LIMPA O CONSOLE TODA VEZ QUE REINICIAR
//     Console.WriteLine("Digite sua opção");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");
 //  opcao = Console.ReadLine();

//     switch(opcao){
//         case "1":
//           Console.WriteLine("Cadastro de cliente");
//           break;

//         case "2":
//           Console.WriteLine("Busca de cliente");
//           break;  

//         case "3":
//           Console.WriteLine("Apagar cliente");
//           break;

//         case "4":
//           Console.WriteLine("Encerrar serviço");
//           Environment.Exit(0); // ENCERRA A EXECUÇÃO
//           break;  

//         default:
//          Console.WriteLine("Opção inválida");
//          break;  
//     }
// }

















// CONTADOR FOR
// int numero = 5;

// Console.WriteLine($"{numero} x 1 = {numero * 1} ");

// for(int contador = 0; contador <= 10; contador++){
//     Console.WriteLine($"{numero} x {contador} = {numero * contador} ");
// }



// CONTADOR WHILE

// int numero = 5;
// int contador = 0;
// while(contador <= 10){
//    Console.WriteLine($"{numero} x {contador} = {numero * contador} ");
//    contador++;
//}


// CONTADOR DO WHILE

// int soma = 0 , numero = 0;

// do {
//   Console.WriteLine("Digite um número (0 para parar)");
//   numero = Convert.ToInt32(Console.ReadLine());

//   soma += numero;
// } while(numero != 0);

// Console.WriteLine($"Total dos valores digitados é: {soma}");




// CALCULADORA
// Calculadora Calc = new Calculadora();

// Calc.Somar(14, 15);

// Calc.Subtrair(15, 14);

// Calc.Multiplicar(15, 16);

// Calc.Dividir(6, 2);



// DateTime Hoje = DateTime.Now.AddDays(0);


//  Pessoa pessoa1 = new Pessoa();

//  pessoa1.Nome = "igor";
//  pessoa1.Idade = 26;

//  pessoa1.Apresentar();
 


// SWITCH CASE

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra){
//    case "a":
//    case "e":
//    case "i":
//    case "o":
//    case "u":
//      Console.WriteLine("É uma vogal");
//      break;

//    default:
//      Console.WriteLine("Não é uma vogal");
//      break;
// }



// IF E ELSE

//  int a = convert.toInt32("5");
// int a = int.Parse("5"); 

// int quantidadeEmEstoque = 10;

// int quantidadeCompra = 4;

// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade de vendas: {quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");


// if (quantidadeCompra == 0){
//     Console.WriteLine("Não foram vendidos");
// }
// else if (possivelVenda){
//     Console.WriteLine("Venda realizada!");
// } else{
//   Console.WriteLine("Não temos em estoque");
// }
