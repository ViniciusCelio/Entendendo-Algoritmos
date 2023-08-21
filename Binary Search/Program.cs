//Função que preenche um vetor com valores aleatórios de 0 a 9
int [] RandomicArray (int [] array) {
    Random rdn = new Random();

    for(int i = 0; i < array.Length; i++)
        array[i] = rdn.Next(10);
    
    return array;
}

//Função que executa a busca binária em um vetor, retornando o indíce que o valor procurado se encontra, ou -1 caso o valor não exista
int BinarySearch(int [] lista, int valorProcurado) {
    int baixo = 0;
    int alto = lista.Length - 1;

    while (baixo <= alto) {
        int meio = (baixo + alto) / 2;
        int chute = lista[meio];
        if (chute == valorProcurado) return meio;
        if (chute > valorProcurado) alto = meio - 1;
        else baixo = meio + 1;
    }
    return -1;
}

int [] lista = new int [10];
int procurado = 5;

Array.Sort(RandomicArray(lista));

Console.WriteLine($"Valores no vetor: {String.Join(" ", lista)}");
Console.WriteLine($"Valor a ser procurado: {procurado}");
int indice = BinarySearch(lista, procurado);
string resultado = indice != -1 ? $"Valor encontrado no índice: {indice}" : "Valor não encontrado!";
Console.WriteLine($"{resultado}");