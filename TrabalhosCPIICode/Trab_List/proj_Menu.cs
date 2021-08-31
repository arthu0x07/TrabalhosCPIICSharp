using System;

class Menu{
    CadastraLivro cadastraLivro = new CadastraLivro();
    Apresentar apresentar = new Apresentar();


    public void MenuInicial(){
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("1) Menu | 2) Listar Livros | 3) Sair");
        Console.WriteLine("--------------------------------------------------------------");

        string choice = Console.ReadLine();

        switch (choice){
            case "1":
                cadastraLivro.Cadastro();
                break;

            case "2":
                apresentar.view();
                break;
        }
    }
}