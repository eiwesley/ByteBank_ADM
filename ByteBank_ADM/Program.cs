using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Utilitario;

Funcionario  pedro = new Funcionario("123456789");

pedro.Nome = "Pedro";
pedro.Salario = 2000;

Console.WriteLine(pedro.Nome );
Console.WriteLine(pedro.GetBonificacao());

Diretor roberta = new Diretor("987654321");
roberta.Nome = "Roberta Silva";
roberta.Salario = 5000;

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

Console.WriteLine("Total de Bonificações: " + gerenciador.TotalDeBonificacao);
Console.WriteLine("Total de Bonificações: " + Funcionario.TotalDeFuncionarios);