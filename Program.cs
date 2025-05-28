/*
 *  Soma Móvel (Moving Sum)
Escreva um método que, dado uma lista de números (List<float>) e um windowSize, retorne uma lista com a soma de cada janela deslizante.
Exemplo:
Entrada: [1, 2, 3, 4], windowSize = 2
Saída: [3, 5, 7]
(1+2, 2+3, 3+4) 
 */


IEnumerable<float> CalculateSumMobile(IList<float> list, int windowSize)
{
    var res = new List<float>();

    if (list == null || list?.Count == 0 || list?.Count < windowSize)
    {
        return res;
    }

    for (int i = 0; i <= list?.Count - windowSize; i++)
    {
        float avgWindow = 0;

        for(int j = i; j < i+ windowSize; j++)
        {
            avgWindow = list![j] + avgWindow;
        }

        res.Add(avgWindow/windowSize);
    }

    return res;
}


var list = new List<float> { 1, 2, 3, 4 };

var windowSize = 2;

var result = CalculateSumMobile(list, windowSize);

Console.WriteLine($"windowsize={windowSize} result shall be [{string.Join(", ", result)}]");