static void ImprimirNotas(int [] notasx)
{ for (int i=0;i<notasx.Length;i++)
    {
        System.Console.WriteLine($"Nota{i+1}:{notasx[i]}");

    }    
}
int [] notas={15,18,12,17,20};
//Imprimir el arreglo de notas

ImprimirNotas(notas);

//Promedio de las notas
int suma=0;
for (int i=0;i<notas.Length;i++)
{
    suma +=notas[i];
}
Console.WriteLine($"Promedio de las notas:{(double)suma/notas.Length:F2}");