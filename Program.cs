using System; 
using Aula02RH.models; 
using Aula02RH.models.Enuns; //referenciando as listas de tipos

namespace Aula02RH
{
    class Program
    {
        static void Main(string[] args)
        {      
            Funcionario func = new Funcionario();

            Console.WriteLine("============================================");
            Console.WriteLine("=== Digite as informações do funcionário ===");
            Console.WriteLine("============================================");

            Console.WriteLine("Digite o nome do funcionario: ");
            func.Nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF: ");
            func.Cpf = Console.ReadLine();

            Console.WriteLine("Digite a data de adimissão: ");
            func.DataAdmissao = DateTime.Parse(Console.ReadLine()); 

            Console.WriteLine("Digite o salario: ");
            func.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Escolha o tipo de Funcinário (1 - CLT | 2 - Aprendiz) ");
            int opcao = int.Parse(Console.ReadLine());
            
            // operador ternario
            func.TipoFuncionario = (opcao == 1) ? TipoFuncionarioEnum.CLT : TipoFuncionarioEnum.Aprendiz;

            // ExibirPeriodoExperiencia, contarCaracteres, validarCpf, tipoFuncionario
            // quando o metodo estiver "private" ele é somente reconhecido dentro do mesmo arquivo, não da para referenciar em outro

            func.ReajusteSalarial();
            decimal valorDescontoVT = func.CalcularDescontoVT(6); // % do desconto

            func.ExibirPeriodoExperiencia();
            string experiencia = func.ExibirPeriodoExperiencia();

            func.ValidarCpf();
            bool cpfValido = func.ValidarCpf();

                Console.WriteLine("==================================================");
                Console.WriteLine("***    Qual informação gostaria de saber?      ***");
                Console.WriteLine("***   Tecle qualquer outro numero para sair    ***");
                Console.WriteLine("==================================================");

                int choice;

            do
            {
                Console.WriteLine("==================================================");
                Console.WriteLine("1 - Validar CPF ");
                Console.WriteLine("2 - Hierarquia ");
                Console.WriteLine("3 - Periodo de experiência ");
                Console.WriteLine("4 - Reajuste salarial ");
                Console.WriteLine("5 - Desconto VT ");
                Console.WriteLine("==================================================\n");
                

                choice = int.Parse(Console.ReadLine());

                switch (choice){
                    case 1: 
                        Console.WriteLine($"O CPF digitado é valido: {cpfValido}. \n");
                        break;
                    case 2:
                        Console.WriteLine($"A hierarquia do funcionário é: {func.TipoFuncionario}\n");
                        break;
                    case 3:
                        Console.WriteLine($"{experiencia}. \n");
                        break;
                    case 4:
                        Console.WriteLine($"O sálario reajustado em 10% é: R${func.Salario}. \n");
                        break;
                    case 5:
                        Console.WriteLine($"O desconto do VT é de: R${valorDescontoVT}.\n");
                        break;
                    default:    
                        Console.WriteLine("Saindo do sistema...\n");
                        break;
                }
                
            } while (choice >= 1 && choice <= 5);
        }
    }
}

