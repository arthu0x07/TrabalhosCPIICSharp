using System;

class CadastraLivro{
    string[] Info = new string[4];
    Menu temp = new Menu();

    public void Cadastro(){
        Console.Write("ISBN:");
        Info[0] = Console.ReadLine();
        Console.Write("Título:");
        Info[1] = Console.ReadLine();
        Console.Write("Gênero:");
        Info[2] = Console.ReadLine();
        Console.Write("Editora:");
        Info[3] = Console.ReadLine();

        livro newlivro = new livro(Info[0], Info[1], Info[2], Info[3]);

        BD.insert(newlivro);
        // jogar new livro pra lista do bd
    }
}

// vai chamar o construtor de livros para criar novos livros