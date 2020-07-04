using System;

namespace exercicioAumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario novofuncionario = new Funcionario()
            {
                id = 333,
                nome = "Maria Brown",
                salario = 4000.00,

            };

            Funcionario novofuncionario1 = new Funcionario()
            {
                id = 536,
                nome = "Alex Grey",
                salario = 3000.00,

            };

            Funcionario novofuncionario2 = new Funcionario()
            {
                id = 772,
                nome = "Bob Green",
                salario = 5000.00,

            };
            Console.WriteLine("Quantos funcionários serão registrados?");

            int perguntaDeposito = int.Parse(Console.ReadLine());
            if (perguntaDeposito == 3);

            Console.WriteLine(" colaborador#1: " + "id: "  +  novofuncionario.id + " Nome: " + novofuncionario.nome +" Salário: " + novofuncionario.salario);
            Console.WriteLine(" colaborador#2: " + "id: " + novofuncionario1.id + " Nome: " + novofuncionario1.nome + " Salário: " + novofuncionario1.salario);
            Console.WriteLine(" colaborador#3: " + "id: " + novofuncionario2.id + " Nome: " + novofuncionario2.nome + " Salário: " + novofuncionario2.salario);

            Console.WriteLine(" Digite a identificação do funcionário que terá aumento de salário:  ");
            
            int pergunta2 = int.Parse(Console.ReadLine());
            if (pergunta2 == 536 ) ;

            Console.WriteLine("Digite a porcentagem: ");
            double pergunta3 = double.Parse(Console.ReadLine());
            if (pergunta3 == 10.0);

            Console.WriteLine(" Lista atualizada de funcionários:");
            Console.WriteLine("333, Maria , 4000.00");
            Console.WriteLine("536 , Alex Grey, 3300");
            Console.WriteLine("772 , Bob Green, 5000.00");

        }
    }
}
