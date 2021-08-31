using System;

class Menu{
    // Chamado pelo main que chama os métodos do item selecionado. Caso criar chama o metodo de cadastro.

    public void menuinit(){
        Console.WriteLine("----------------------------------------------------------------------");
        Console.WriteLine("1) Criar | 2) Listar | 3) Sair");
        Console.WriteLine("----------------------------------------------------------------------");

        switch (Console.ReadLine())
        {
            case "1":
                CadastroLivros objcad = new CadastroLivros();
                objcad.Cadastro();
            break;

            case "2":
                Apresentar objaprese = new Apresentar();
                objaprese.listar();
            break;

            case "3":
            
            break;

        }
    
    }
}