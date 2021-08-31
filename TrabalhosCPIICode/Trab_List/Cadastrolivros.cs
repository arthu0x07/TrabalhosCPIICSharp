using System;

//Cria objetos da classe Livro os armazenando em um Vetor de Objetos, toda vez que vão criar um novo livro, criam na proxima posição do vetor.

//Em seguida, guarda esse objeto da classe livro numa lista da classe Banco de dados passando para um método da mesma usando um objeto criado neste namespace.



class CadastroLivros{
    int i = 0;
    livro[] newlivro = new livro[15];
    string[] Info = new string[4];


    public void Cadastro(){

        Console.Write("ISBN:");
        Info[0] = Console.ReadLine();
        Console.Write("Título:");
        Info[1] = Console.ReadLine();
        Console.Write("Gênero:");
        Info[2] = Console.ReadLine();
        Console.Write("Editora:");
        Info[3] = Console.ReadLine();

        newlivro[i] = new livro(Info[0], Info[1], Info[2], Info[3]);

        BancoDados objbd = new BancoDados();
        objbd.adicionar(newlivro[i]);

        i++;
        
        Menu objmenu = new Menu();
        objmenu.menuinit();
    }
}