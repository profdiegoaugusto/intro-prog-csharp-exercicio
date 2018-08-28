using System;

namespace IntroProgramacaoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. Escreva um aplicativo que apresente os números de 1 a 40 separados por um espaço em branco, da seguinte maneira:
            // Use uma única instrução Console.Write
            Console.WriteLine("1. Escreva um aplicativo que apresente os números de 1 a 40 separados por um espaço em branco, da seguinte maneira:");
            Console.WriteLine("\na. Use uma única instrução Console.Write:");
            Console.Write("1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 32 33 34 35 36 37 38 39 40");

            // Use quatro instruções Console.Write
            Console.WriteLine("\n\nb. Use quatro instruções Console.Write:");
            Console.Write("1 2 3 4 5 6 7 8 9 10 ");
            Console.Write("11 12 13 14 15 16 17 18 19 20 ");
            Console.Write("21 22 23 24 25 26 27 28 29 30 ");
            Console.Write("31 32 33 34 35 36 37 38 39 40");


            Console.WriteLine("\n\n");
            /* 
             * 2. O que aparece na janela do console, quando cada uma das instruções C# abaixo são executadas, para x = 2 e y = 3 ? 
             * a. Console.WriteLine(“x = ” + x);
             * b. Console.WriteLine(“O valor de x + x é ” + (x + x));
             * c. Console.WriteLine(“x = ”);
             * d. Console.WriteLine((x + y) + “ = “ + (y + x));
             */         
            int x = 2;
            int y = 3;

            Console.WriteLine("2. O que aparece na janela do console, quando cada uma das instruções C# abaixo são executadas, para x = 2 e y = 3 ? ");
            Console.WriteLine("\na. Console.WriteLine(“x = ” + x);");
            Console.WriteLine("x = " + x);

            Console.WriteLine("\nb. Console.WriteLine(“O valor de x + x é ” + (x + x));");
            Console.WriteLine("O valor de x + x é " +(x + x));

            Console.WriteLine("\nc. Console.WriteLine(“x = ”);");
            Console.WriteLine("x = ");

            Console.WriteLine("\nd. Console.WriteLine((x + y) + “ = “ + (y + x));");
            Console.WriteLine((x + y) + " = " +(y + x));


            Console.WriteLine("\n\n\n");
            //3. O que o código a seguir imprime? Console.WriteLine(“*\n**\n***\n****\n*****”);
            Console.WriteLine(@"3. O que o código a seguir imprime? Console.WriteLine(“*\n**\n***\n****\n*****”);");
            Console.WriteLine("*\n**\n***\n****\n*****");


            Console.WriteLine("\n\n");
            /*
             * 4. O que o código a seguir imprime? 
             * Console.Write(“*”);
             * Console.Write(“***”);
             * Console.WriteLine(“*****”);
             * Console.Write(“****”);
             * Console.WriteLine(“**”);
             */
            Console.WriteLine("4. O que o código a seguir imprime? ");
            Console.WriteLine("Console.Write(“*”);\nConsole.Write(“***”);\nConsole.WriteLine(“*****”);\nConsole.Write(“****”);\nConsole.WriteLine(“**”);\n");
            Console.Write("*");
            Console.Write("***");
            Console.WriteLine("*****");
            Console.Write("****");
            Console.WriteLine("**");


            Console.WriteLine("\n\n");
            /*
             * 5. Escreva um programa que leia o nome, o sobrenome e o número de matrícula de um estudante. Em seguida, formate e imprima os dados lidos da seguinte 
             * forma: 99999 - nome sobrenome, onde, o número de matrícula e nome deverão ter cores de fonte diferentes à sua escolha. Dica: pesquise pela propriedade
             * Console.ForegroundColor
             */
            Console.WriteLine("5. Escreva um programa que leia o nome, o sobrenome e o número de matrícula de um estudante. Em seguida, formate e imprima os dados " +
                "lidos da seguinte forma: 99999 - nome sobrenome, onde, o número de matrícula e nome deverão ter cores de fonte diferentes à sua escolha. Dica: " +
                "pesquise pela propriedade Console.ForegroundColor");

            Console.Write("\nDigite o NOME do estudante: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o SOBRENOME do estudante: ");
            string sobrenome = Console.ReadLine();

            Console.Write("Digite a MATRÍCULA do estudante: ");
            string matricula = Console.ReadLine();

            Console.Write("ESTUDANTE: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(matricula);

            Console.ResetColor();
            Console.Write(" - ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(nome + " " + sobrenome);

            Console.ResetColor();
            Console.WriteLine("\n\n");

  
            // 6. Escreva um programa que solicite do usuário dois números, e imprima o resultado da soma, subtração, multiplicação e divisão.
            Console.WriteLine("6. Escreva um programa que solicite do usuário dois números, e imprima o resultado da soma, subtração, multiplicação e divisão.");
            Console.WriteLine("Digite um número positivo inteiro, diferente de zero");

            Console.Write("\nNúmero 1: ");
            int numero1 = Int32.Parse(Console.ReadLine());

            Console.Write("Número 2: ");
            int numero2 = Int32.Parse(Console.ReadLine());

            int soma = numero1 + numero2;
            Console.WriteLine("{0} + {1} = {2}", numero1, numero2, soma);

            int subtracao = numero1 - numero2;
            Console.WriteLine("{0} - {1} = {2}", numero1, numero2, subtracao);

            int multiplicacao = numero1 * numero2;
            Console.WriteLine("{0} × {1} = {2}", numero1, numero2, multiplicacao);

            int divisao = numero1 / numero2;
            Console.WriteLine("{0} ÷ {1} = {2}", numero1, numero2, divisao);


            Console.WriteLine("\n\n");
            /*
             * 7. Escreva um programa que receba como entrada o raio de um círculo e imprima o diâmetro, a circunferência e a área. Para isso, 
             * utilize as fórmulas: diâmetro = 2r; circunferência = 2πr, área = πr² 
             */
            Console.WriteLine("Escreva um programa que receba como entrada o raio de um círculo e imprima o diâmetro, a circunferência e a área. " +
                "Para isso, utilize as fórmulas: diâmetro = 2r; circunferência = 2πr, área = πr² ");

            Console.Write("\nRaio: ");
            double raio = Double.Parse(Console.ReadLine());

            double diametro = 2 * raio;
            double circunferencia = 2 * Math.PI * raio;
            double area = Math.PI * Math.Pow(raio, 2);

            Console.WriteLine("Diâmetro = " + diametro);
            Console.WriteLine("Circunferência = " + circunferencia);
            Console.WriteLine("Área = " + area);

            Console.WriteLine("\n\n");

            /*
             * 8. Escreva um programa que leia dois números inteiros e determine e verifique se o primeiro é um múltiplo do segundo. 
             * Por exemplo: se o usuário digitar 15 e 3, o primeiro número será múltiplo do segundo; se o usuário digitar 2 e 4, o primeiro 
             * número não será múltiplo do segundo. Dica: use o operador módulo para obter o resto da divisão.
             */
            Console.WriteLine("Escreva um programa que leia dois números inteiros e determine e verifique se o primeiro é um múltiplo do segundo. " +
                "Por exemplo: se o usuário digitar 15 e 3, o primeiro número será múltiplo do segundo; se o usuário digitar 2 e 4, o primeiro número " +
                "não será múltiplo do segundo. Dica: use o operador módulo para obter o resto da divisão.");
            Console.WriteLine("Digite um número positivo inteiro, diferente de zero");

            Console.Write("\nNúmero 1: ");
            int numeroInteiro1 = Int32.Parse(Console.ReadLine());

            Console.Write("Número 2: ");
            int numeroInteiro2 = Int32.Parse(Console.ReadLine());
            int resto = numeroInteiro1 % numeroInteiro2;


            if (resto > 0)
                Console.WriteLine("{0} NÃO é múltiplo de {1}", numeroInteiro1, numeroInteiro2);
            else
                Console.WriteLine("{0} é múltiplo de {1}", numeroInteiro1, numeroInteiro2);


            Console.WriteLine("\n\n");
            /*
             * 9. Escreva um programa que receba como entrada um número de 5 dígitos, separe o número em dígitos individuais e os imprima separados por 
             * 3 espaços cada um. Por exemplo, se o usuário digitar 42339, o programa deverá imprimir: 4    2    3    3    9. Dica: utilize as operações
             * de divisão e módulo para extrair cada dígito do número.
             */
            Console.WriteLine("9. Escreva um programa que receba como entrada um número de 5 dígitos, separe o número em dígitos individuais e os imprima " +
                "separados por 3 espaços cada um. Por exemplo, se o usuário digitar 42339, o programa deverá imprimir: 4    2    3    3    9. Dica: utilize " +
                "as operações de divisão e módulo para extrair cada dígito do número.");

            int unidade = 0;
            int dezena = 0;
            int centena = 0;
            int unidadeDeMilhar = 0;
            int dezenaDeMilhar = 0;
            int restoDivisao = 0;
            int quociente = 0;

            const int DECIMAL = 10;

            // Lê dado do usuário
            Console.WriteLine("Digite um número inteiro com 5 dígitos");
            Console.Write("\nNúmero: ");
            int numeroCincoDigitos = Int32.Parse(Console.ReadLine());

            // Obtém digito das unidades
            restoDivisao = numeroCincoDigitos % DECIMAL;
            quociente = numeroCincoDigitos / DECIMAL;
            unidade = restoDivisao;

            // Obtém dígito das dezenas
            restoDivisao = quociente % DECIMAL;
            quociente = quociente / DECIMAL;
            dezena = restoDivisao;

            // Obtém dígito das centenas
            restoDivisao = quociente % DECIMAL;
            quociente = quociente / DECIMAL;
            centena = restoDivisao;

            // Obtém dígito das unidades de milhar
            restoDivisao = quociente % DECIMAL;
            quociente = quociente / DECIMAL;
            unidadeDeMilhar = restoDivisao;

            // Obtém dígito das dezenas de milhar
            dezenaDeMilhar = quociente;
            
            Console.WriteLine("Número Espaçado: {0}   {1}   {2}   {3}   {4}", dezenaDeMilhar, unidadeDeMilhar, centena, dezena, unidade);


            Console.WriteLine("\n\n");
            /*
            * 10. Escreva um programa que calcule o quadrado e o cubo dos números de 0 a 10, e imprima os valores em forma de tabela.
            */
            Console.WriteLine("10. Escreva um programa que calcule o quadrado e o cubo dos números de 0 a 10, e imprima os valores em forma de tabela.");

            int numero = 0;
            double quadrado = 0.0;
            double cubo = 0.0;

            Console.WriteLine("\nNúmero\t\tQuadrado\tCubo");

            quadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

            numero = numero + 1;
            quadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

            numero = numero + 1;
            quadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

            numero = numero + 1;
            quadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

            numero = numero + 1;
            quadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

            numero = numero + 1;
            quadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

            numero = numero + 1;
            quadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

            numero = numero + 1;
            quadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

            numero = numero + 1;
            quadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

            numero = numero + 1;
            quadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

            numero = numero + 1;
            quadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("{0}\t\t{1}\t\t{2}", numero, quadrado, cubo);

            Console.ReadKey(true);

        } // Fim do método Main

    } // Fim da classe Program

} // Fim do namespace IntroProgramaCsharp
