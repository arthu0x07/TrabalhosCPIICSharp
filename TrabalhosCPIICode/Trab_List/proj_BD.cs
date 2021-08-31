using System;
using System.Collections.Generic;

class BD{
    public static List<livro> banco = new List<livro>();

    public static void insert(livro livronovo){
        banco.Add(livronovo);
    }

    public static void GetBanco(){
        Console.WriteLine(banco[0]);
    } 
}