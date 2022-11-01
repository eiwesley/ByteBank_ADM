using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Parceria;
using ByteBank_ADM.SistemaInterno;
using ByteBank_ADM.Utilitario;

#region 
//Funcionario  pedro = new Funcionario("123456789", 2000);
//pedro.Nome = "Pedro";

//Console.WriteLine(pedro.Nome );
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor("987654321");
//roberta.Nome = "Roberta Silva";

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de Bonificações: " + gerenciador.TotalDeBonificacao);
//Console.WriteLine("Total de Bonificações: " + Funcionario.TotalDeFuncionarios);

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine("novo Salario Pedro " + pedro.Salario);

//Console.WriteLine("novo salario Roberta " + roberta.Salario);
#endregion

//CalcularBonificacao();
UsarSistema();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("123456789");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("987654321");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("963852741");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("741852963");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(ulisses);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);

    Console.WriteLine("Total de Bonificação: " + gerenciador.TotalDeBonificacao);

}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("123456789");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("987654321");
    ursula.Nome = "Ursula Alcantara";
    ursula.Senha = "231";

    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "999";

    sistema.Logar(ingrid, "123");
    sistema.Logar(ursula, "963");
    sistema.Logar(caio, "999");

}


