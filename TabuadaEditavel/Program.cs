using System;

class URI
{

    static void Main(string[] args)
    {
        int n, r, x, rep = 0;
        char resp;
        Console.WriteLine("Tabuada Editavel\n");

        do
        {
            Console.WriteLine("Qual número deseja multiplicar na tabuada?");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("E até que número deseja multiplicar esse valor?");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Segue a Tabuada de {n} multiplicada até o valor {x}\n");
            for (int cont = 1; cont <= x; cont++)
            {
                r = cont * n;
                Console.WriteLine(n + " x " + cont + " = " + r);
            }
            Console.WriteLine();
            Console.WriteLine("Deseja saber a tabuada de outro número? s/n\n");
            resp = char.Parse(Console.ReadLine());

            while (resp != 's' && resp != 'S' && resp != 'n' && resp != 'N')
            {
                Console.WriteLine("Escreva uma resposta valida");
                resp = char.Parse(Console.ReadLine());
                rep++;
                if (rep == 3)
                {
                    Console.WriteLine("Você já tá me tirando!!");
                    return;
                }
            }

        }
        while (resp != 'n' && resp != 'N');
    }
}