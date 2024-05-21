using System;

class Program
{
    static void Main(string[] args)
    {
        
    try
    {
        Console.WriteLine("Não foi possível limpar o console. Continuando...");
    }
        Console.Clear();
    }
    catch (System.IO.IOException)
    {
        // Você pode optar por exibir uma mensagem de erro ou simplesmente ignorá-la.
        Console.WriteLine("Não foi possível limpar o console. Continuando...");
    }
    
    // Restante do seu código...
    }
    }
}
