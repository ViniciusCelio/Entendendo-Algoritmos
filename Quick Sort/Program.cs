//Função que preenche um vetor com valores aleatórios de 0 a 99
int[] RandomicArray(int[] array)
{
    Random rdn = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = rdn.Next(100);

    return array;
}

//Função que ordena um determinado vetor recursivamente
int[] QuickSort(int[] array, int leftIndex, int rightIndex)
{
    int i = leftIndex;
    int j = rightIndex;
    int pivo = array[leftIndex];

    while (i <= j)
    {
        while (array[i] < pivo)
            i++;
        while (array[j] > pivo)
            j--;

        if (i <= j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            i++;
            j--;
        }
    }

    if (leftIndex < j)
        QuickSort(array, leftIndex, j);
    if (i < rightIndex)
        QuickSort(array, i, rightIndex);

    return array;
}


int[] array = new int [10];
array = RandomicArray(array);
Console.WriteLine($"Vetor inicial: {String.Join(' ', array)}");
array = QuickSort(array, 0, array.Length - 1);
Console.WriteLine($"Vetor ordenado via QuickSort: {String.Join(' ', array)}");