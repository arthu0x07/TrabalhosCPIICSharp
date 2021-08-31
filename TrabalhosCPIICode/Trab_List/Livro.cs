using System;

class livro{
    public string ISBN;
    public string Titulo;
    public string Genero;
    public string Editora;
    public DateTime Data;

    public livro(string ISBN, string Titulo, string Genero, string Editora){
        this.ISBN = ISBN;
        this.Titulo = Titulo;
        this.Genero = Genero;
        this.Editora = Editora;
        this.Data = new DateTime();
    }
}