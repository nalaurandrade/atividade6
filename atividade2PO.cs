/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Veiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Placa { get; set; }
    public int Ano { get; set; }
    public float PrecoDiaria { get; set; }

    public Veiculo(string marca, string modelo, string placa, int ano, float precoDiaria)
    {
        Marca = marca;
        Modelo = modelo;
        Placa = placa;
        Ano = ano;
        PrecoDiaria = precoDiaria;
    }

    public string Mostrar()
    {
        return $"Veículo: {Marca} {Modelo}, Ano: {Ano}, Preço da Diária: R$ {PrecoDiaria}";
    }
}

class Carro : Veiculo
{
    public int NumeroPortas { get; set; }

    public Carro(string marca, string modelo, string placa, int ano, float precoDiaria, int numeroPortas)
        : base(marca, modelo, placa, ano, precoDiaria)
    {
        NumeroPortas = numeroPortas;
    }

    public string MostrarNumeroDePortas()
    {
        return $"Número de portas: {NumeroPortas}";
    }
}

class Moto : Veiculo
{
    public int Cilindradas { get; set; }

    public Moto(string marca, string modelo, string placa, int ano, float precoDiaria, int cilindradas)
        : base(marca, modelo, placa, ano, precoDiaria)
    {
        Cilindradas = cilindradas;
    }

    public string MostrarCilindradas()
    {
        return $"Cilindradas: {Cilindradas}";
    }
}

class Caminhao : Veiculo
{
    public float CapacidadeCarga { get; set; }

    public Caminhao(string marca, string modelo, string placa, int ano, float precoDiaria, float capacidadeCarga)
        : base(marca, modelo, placa, ano, precoDiaria)
    {
        CapacidadeCarga = capacidadeCarga;
    }

    public string MostrarCarga()
    {
        return $"Capacidade de carga: {CapacidadeCarga} toneladas";
    }
}

class Aluguel
{
    public static void Main(string[] args)
    {
        Carro carro = new Carro("Toyota", "Corolla", "ABC1234", 2020, 150, 4);
        Moto moto = new Moto("Honda", "CB500", "DEF5678", 2019, 100, 500);
        Caminhao caminhao = new Caminhao("Volvo", "FH", "GHI9012", 2018, 300, 20);

        Console.WriteLine(carro.Mostrar());
        Console.WriteLine(carro.MostrarNumeroDePortas());

        Console.WriteLine(moto.Mostrar());
        Console.WriteLine(moto.MostrarCilindradas());

        Console.WriteLine(caminhao.Mostrar());
        Console.WriteLine(caminhao.MostrarCarga());
    }
}