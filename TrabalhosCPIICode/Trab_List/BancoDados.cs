using System;
using System.Collections.Generic;

class BancoDados{
    public static List<livro> BD_list = new List<livro>();

    public void adicionar(livro livro){
        BD_list.Add(livro);
    }

    public void listar(){
        for (int i = 0; i < BD_list.Count; i++)
        {
            Console.WriteLine("     Livro - {0} ", i);
            Console.WriteLine("");
            Console.WriteLine(BD_list[i].ISBN);
            Console.WriteLine(BD_list[i].Data);
            Console.WriteLine(BD_list[i].Editora);
            Console.WriteLine(BD_list[i].Titulo);
            Console.WriteLine("");
            Console.WriteLine("------------------------------");

        }

            Menu objmenu = new Menu();
            objmenu.menuinit();

    }
}