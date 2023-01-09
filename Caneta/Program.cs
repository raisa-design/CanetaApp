
using CanetaApp;
using System.Collections.Generic;
using System.Linq;


//Caneta c1 = new Caneta();
//c1.modelo = "bic";
////c1.cor = "   ";
//c1.setColor(2);
//c1.ponta = 0.5f;
//c1.tampar();
//var teste =  c1.somarNum(2, 4);
//c1.status();
//c1.Rabiscar("Olá Mundo");

var  listaDeCanetas = new List<Caneta>();


string opt = "";

do
{
    Console.WriteLine("Escolha um das opções");
    Console.WriteLine("0:Fechar");
    Console.WriteLine("1: adicionar caneta");
    Console.WriteLine("2: Mostrar lista");
    Console.WriteLine("3: Excluir  lista");
    opt = Console.ReadLine();

    if (opt == "1")
    {
        var caneta = new Caneta(2);
        Console.WriteLine("Digite o nome caneta");
        caneta.setNome(Console.ReadLine());
        Console.WriteLine("Digite o modelo da caneta");
        caneta.setModelo(Console.ReadLine());
        Console.WriteLine("Digite a cor da caneta- Rosa= 1 e Azul= 2");
        caneta.setColor(Convert.ToInt32(Console.ReadLine()));
       //onsole.ReadKey();


        listaDeCanetas.Add(caneta);


    }
    if (opt == "2")
    {
        foreach (Caneta caneta in listaDeCanetas)
        {
            caneta.status();
        }
    }

    if (opt == "3")
    {
        Console.WriteLine("Digite o nome do item que deseja excluir");
        var item = Console.ReadLine();
        Console.ReadKey();
        var name = Console.ReadLine();
        Caneta caneta  = listaDeCanetas.Find(x => x.getNome() == name);
        listaDeCanetas.Remove(caneta);
        
    }

    if (opt == "4")
    {
        Console.WriteLine("Digite o nome da caneta que você deseja usar ");
        var name = Console.ReadLine();
        Caneta caneta = listaDeCanetas.Find(x => x.getNome() == name);
        Console.WriteLine("Digite a palavra que deseja escrever");
        var palavra = Console.ReadLine();
        caneta.Rabiscar(palavra);


    }




} while (opt != "0");

Console.WriteLine("Programa finalizado");