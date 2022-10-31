using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Utilitario;

Funcionario  pedro = new Funcionario();

pedro.Nome = "Pedro";
pedro.Cpf = "123.456.789-89";
pedro.Salario = 2000;

Console.WriteLine(pedro.Nome );
Console.WriteLine(pedro.GetBonificacao());

Diretor roberta = new Diretor();
roberta.Nome = "Roberta Silva";
roberta.Cpf = "987654321";
roberta.Salario = 5000;

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

Console.WriteLine("Total de Bonificações: " + gerenciador.TotalDeBonificacao);