Console.WriteLine("Digite uma sequencia");
string dados = Console.ReadLine();

if (verificaSuporteBalanceadosValida(dados))
{
    Console.WriteLine("sequência de colchetes é válida");
}
else
{
    Console.WriteLine("sequência de colchetes não é válida");
}


static bool verificaSuporteBalanceadosValida(string sequencia)
{
    List<char> listaSequencia = new List<char>();

    foreach (var value in sequencia.ToArray())
    {
        char valor = value;
        if (valor == '[' || valor == '{' || valor == '(')
            listaSequencia.Add(valor);
        else if (valor == ']' || valor == '}' || valor == ')')
        {
            if (valor == ')')
            {
                if (listaSequencia.Last() != '(')
                {
                    return false;
                }
                else
                {
                    listaSequencia.Remove(listaSequencia.Last());
                }
            }
            else if (valor == '}')
            {
                if (listaSequencia.Last() != '{')
                {
                    return false;
                }
                else
                {
                    listaSequencia.Remove(listaSequencia.Last());
                }
            }
            else if (valor == ']')
            {
                if (listaSequencia.Last() != '[')
                {
                    return false;
                }
                else
                {
                    listaSequencia.Remove(listaSequencia.Last());
                }
            }
        }

    }

    if (listaSequencia.Count() == 0)
        return true;
    return false;
}