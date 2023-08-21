List <int> RandomicList (List <int> lista, int tamanho) {
    Random rdn = new Random ();

    for (int i = 0; i < tamanho; i++)
        lista.Add(rdn.Next(100));
    
    return lista;
}

int BuscaMenor (List <int> lista) {
    int menor = lista.First();
    int menor_indice = 0;

    for(int i = 1; i < lista.Count; i++) {
        if(lista[i] < menor) {
            menor = lista[i];
            menor_indice  = i;
        }
    }

    return menor_indice;
}

List <int> SelectionSort (List <int> lista) {
    int tamanho = lista.Count;
    List <int> newArray = new List<int>();

    for(int i = 0; i < tamanho; i++) {
        int menor = BuscaMenor(lista);
        newArray.Add(lista[menor]);
        lista.RemoveAt(menor);
    }   

    return newArray;
}

List <int> lista = new List<int>();
lista = RandomicList(lista, 5);
Console.WriteLine($"Lista inicial: {String.Join(" ", lista)}");

lista = SelectionSort(lista);
Console.WriteLine($"Lista ordenada: {String.Join(" ", lista)}");