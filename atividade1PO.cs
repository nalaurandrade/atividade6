/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Documento
{
    public string Texto { get; set; }

    public Documento(string texto)
    {
        Texto = texto;
    }
}

class Impressora
{
    private Documento documento;

    public Impressora(Documento doc)
    {
        documento = doc;
    }

    public void Imprimir(int quantidade = 1)
    {
        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine(documento.Texto);
        }
    }

    public string SolicitarTexto()
    {
        Console.WriteLine("Digite o texto a ser impresso:");
        return Console.ReadLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Impressora impressora = new Impressora(new Documento(""));

        string texto = impressora.SolicitarTexto();

        Documento doc = new Documento(texto);

        impressora = new Impressora(doc);
        impressora.Imprimir();
    }
}
