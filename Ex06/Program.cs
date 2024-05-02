namespace Ex06
{
    class Program06
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro("Toyota Corolla", 2021, "Prata", 4);
            Moto moto = new Moto("Yamaha YZF", 2022, "Azul", 600);
            Bicicleta bicicleta = new Bicicleta("Caloi Andes", 2020, "Vermelho", 21);

            Console.WriteLine();
            carro.ExibirInformacoes();
            Console.WriteLine();
            moto.ExibirInformacoes();
            Console.WriteLine();
            bicicleta.ExibirInformacoes();
            Console.WriteLine();
        }
    }
}