using System; 
 
class Atividade9 
{ 
    static void Main() 
    { 
        Console.WriteLine("Verificação de Estoque Crítico"); 
 
        int[] estoque = new int[3]; 
 
        Console.Write(" quantidade do Produto 1: "); 
        estoque[0] = int.Parse(Console.ReadLine()); 
 
        Console.Write(" quantidade do Produto 2: "); 
        estoque[1] = int.Parse(Console.ReadLine()); 
 
        Console.Write(" quantidade do Produto 3: "); 
        estoque[2] = int.Parse(Console.ReadLine()); 
 
        if (estoque[0] == 0) 
        { 
            Console.WriteLine("Atenção: O primeiro produto está esgotado."); 
        } 
    } 
}
