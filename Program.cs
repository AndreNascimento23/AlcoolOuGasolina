		double etanol , gasolina;

        Console.WriteLine("--- Etanol ou Gasolina? ---\n");

        Console.Write("Digite o preço do Etanol (R$).....: ");
		etanol = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o preço do Gasolina (R$)...: ");
        gasolina = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(Razao(etanol, gasolina));

        if(Recomendação(etanol,gasolina))
        {
            Console.WriteLine("Recomendação: Abasteça com Gasolina.");
        }
        else
        {
            Console.WriteLine("Recomendação: Abasteça com Etanol.");
        }
    
    static string Razao (double valor1, double valor2)
    {
        double valor3 = (valor1 / valor2) ;
    
        return $"\nO preço do etanol corresponde a {valor3:P} do preço da gasolina.\n";
    }
    
	static bool Recomendação (double a , double g)
    { 
        bool gasolina = (
     
            (a/g)*100 >= 73 
        );
        return gasolina;
    }
