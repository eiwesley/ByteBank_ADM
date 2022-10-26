using ByteBank_ADM.Funcionarios;

Funcionario  pedro = new Funcionario();

pedro.Nome = "Pedro";
pedro.Cpf = "123.456.789-89";
pedro.Salario = 2000;

Console.WriteLine(pedro.Nome );
Console.WriteLine(pedro.GetBonificacao());
