char[] Insere(char letra,char[] pilha, int topo)
{
    pilha[topo] = letra;
    return pilha;
}

bool EstaVazia(int topo)
{
    return topo == 0;
}

void Inverter(string frase)
{
    int qtd_caracteres = frase.Length;
    char[] frase_invertida = new char[qtd_caracteres];
    int topo = 0;

    for (int i = 0; i <= qtd_caracteres - 1; i++)
    {
            Insere(frase[i], frase_invertida, topo);
            topo += 1;
    }

    while(!EstaVazia(topo))
    {
        topo -= 1;
        Console.Write(frase_invertida[topo]);
    }
}

string frase = "Eu faco ADS";
Inverter(frase); 

