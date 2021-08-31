using System;

class livro{
    string ISBN;
    string Titulo;
    string Genero;
    string Editora;
    DateTime Data;

    public livro(string ISBN, string Titulo, string Genero, string Editora){
        this.ISBN = ISBN;
        this.Titulo = Titulo;
        this.Genero = Genero;
        this.Editora = Editora;
        this.Data = new DateTime();
    }
}