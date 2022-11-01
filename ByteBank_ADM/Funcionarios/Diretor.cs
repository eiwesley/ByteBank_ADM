using ByteBank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public class Diretor: FuncionarioAutenticavel
    {
        public string Senha { get ; set ; }

        public Diretor(string cpf) : base(cpf, 5000)
        {

        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.50;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}
