using EXEMPLOEXPLORANDO.Models;
using System.Data;
using System.Globalization; //Alterando a localização do sistema


//Tratativa de erro com Try Catch
try
{
    //Realizando a leitura de um arquivo texto.
    string[] strings = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach (string string1 in strings)
    {
        Console.WriteLine(string1);
    }

}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção generica {ex.Message}");

}



// //Utilizando conversão de data com tratamento de exceção TryParse
// string dataString = "2022-10-22 18:00";
// variavel, formato da data   , conversão local             , estilo da data     , saida.
// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);
// if (sucesso)
// {
// Console.WriteLine($"Conversão realizada com sucesso, Data: {data}");
// }
// else
// {
// Console.WriteLine($"{dataString} não é uma data válida");
// }

// Console.WriteLine(data);


// //Trabalhando com DataTime
// DateTime data = DateTime.Now;

// //Data e hora completa
// Console.WriteLine(data);

// //Data formatada
// Console.WriteLine(data.ToString("dd/MM/yy HH:mm"));

// //Formatar para pegar apenas a data
// Console.WriteLine(data.ToShortDateString());

// //Formatar para pegar apenas a hora
// Console.WriteLine(data.ToShortTimeString());



// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// decimal valor = 11158.23M;

// //A letra ":C" pega a moeda corrente e faz a conversao monetaria.
// Console.WriteLine($"{valor:C}");


// //Outra forma de formatar a localização
// Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));


// Console.WriteLine(valor.ToString("C2")); //C2 moeda, localização corrente + casas decimais
// Console.WriteLine(valor.ToString("N2")); //N2 numero + casas decimais

// double porcetagem = .1425;
// //formatando com porcentagem
// Console.WriteLine(porcetagem.ToString("P"));

// int numeros = 123456;
// //formatação personalizada
// Console.WriteLine(numeros.ToString("##-##-##"));

// Pessoa p1 = new Pessoa(nome:"Diogo", sobrenome:"Sousa");
// Pessoa p2 = new Pessoa(nome:"Jorge", sobrenome:"Santos");


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();




// p1.Nome = "Diogo";
// p1.Sobrenome = "Sousa";
// p1.Idade = 33;
// p1.Apresentar();

