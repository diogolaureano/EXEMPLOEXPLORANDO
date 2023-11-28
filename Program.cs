﻿using EXEMPLOEXPLORANDO.Models;
using System.Globalization; //Alterando a localização do sistema

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

decimal valor = 11158.23M;

//A letra ":C" pega a moeda corrente e faz a conversao monetaria.
Console.WriteLine($"{valor:C}");


//Outra forma de formatar a localização
Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

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

