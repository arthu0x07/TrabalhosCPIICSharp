using System;

class Apresentar{
    public void view(){
        Console.WriteLine("ISBN | Título | Gênero | Editora | Ano");
        BD.GetBanco();
    }
}