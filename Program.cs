static void ImprimirNotas(int [] notasx)
{ for (int i=0;i<notasx.Length;i++)
    {
        System.Console.WriteLine($"Nota{i+1}:{notasx[i]}");

    }    
}
//Funcion de promedio de notas
static double PromedioNotas(int[] notasx)
{
    int suma=0;
    for (int i=0;i<notasx.Length;i++)
    {
       suma +=notasx[i];
    } 
    return (double)suma/notasx.Length;
}

int [] notas={15,18,12,17,20};

//Imprimir el arreglo de notas

ImprimirNotas(notas);

//Promedio de las notas
double promedio = PromedioNotas(notas);

Console.WriteLine($"Promedio de las notas:{promedio:F2}");