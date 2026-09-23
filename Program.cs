static void ImprimirNotas(int [] notasx)
{ for (int i=0;i<notasx.Length;i++)
    {
        System.Console.WriteLine($"Nota{i+1}:{notasx[i]}");

    }    
}
int [] notas={5,18,12,17,20};
ImprimirNotas(notas);