using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Utilitario;

Funcionario  pedro = new Funcionario("123456789",2000);
pedro.Nome = "Pedro";

Console.WriteLine(pedro.Nome );
Console.WriteLine(pedro.GetBonificacao());

Diretor roberta = new Diretor("987654321",5000);
roberta.Nome = "Roberta Silva";

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

Console.WriteLine("Total de Bonificações: " + gerenciador.TotalDeBonificacao);
Console.WriteLine("Total de Bonificações: " + Funcionario.TotalDeFuncionarios);

pedro.AumentarSalario();
roberta.AumentarSalario();

Console.WriteLine("novo Salario Pedro " + pedro.Salario);

Console.WriteLine("novo salario Roberta " + roberta.Salario);