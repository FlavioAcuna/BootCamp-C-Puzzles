/*
Matriz Aleatoria
Se requiere: 
Crear una función llamada RandomArray() que devuelva una matriz de enteros​
Crea una matriz vacía que contenga 10 valores enteros.​
Recorre la matriz y asigna a cada índice un valor entero aleatorio entre 5 y 25.​
Imprime los valores mínimo y máximo de la matriz.​
Imprime la suma de todos los valores.​
*/
static int[] RandomArray(int[] numbers)
{

    Random rand = new Random();
    for (var i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rand.Next(5, 25);
        Console.WriteLine(numbers[i]);

    }
    int max = numbers[0];
    int min = numbers[0];
    int total = 0;
    for (var i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
        total += numbers[i];
    }
    Console.WriteLine($"Numero Mayor: {max}");
    Console.WriteLine($"Numero Menor: {min}");
    Console.WriteLine($"Total:{total}");
    return numbers;
};
RandomArray(new int[10]);
Console.WriteLine("-------------------------");
/*
Lanzamiento de Moneda
Se requiere: 
Crear una función llamada TossCoin() que devuelva una cadena. ​
Que la función imprima "¡Tirando una moneda!".​
Lanzar una moneda al azar con un resultado que señale cualquiera de las dos caras de la moneda. ​
Haz que la función imprima "Cara" o "Cruz".​
Por último, devuelve el resultado. ​
*/
static String TossCoin()
{
    int lanzar;
    string resultado = "";
    string resp = "";
    Console.WriteLine("¡Tirando una moneda!");
    Random rand = new Random();
    lanzar = rand.Next(0, 2);
    if (lanzar == 0)
    {
        resp = "Cara";
    }
    else
    {
        resp = "Cruz";
    }
    resultado = $"{resp}";
    return resultado;
};
Console.WriteLine(TossCoin());
Console.WriteLine("-------------------------");
/*
Opcional:
Crea otra función llamada TossMultipleCoins(int num) que devuelva un Doble. ​
Haz que la función llame a la función tossCoin varias veces en función del valor num.​
Haz que la función devuelva un Doble que refleje la relación entre el lanzamiento de cabezas y el lanzamiento total.​
*/
static double TossMultipleCoins(int num)
{
    double makak;
    double CountCara = 0;
    double CountCruz = 0;
    for (var i = 0; i < num; i++)
    {
        if (TossCoin() == "Cara")
        {
            CountCara++;

        }
        else
        {
            CountCruz++;
        }

    }
    makak = CountCara / num;
    return makak;
}
Console.WriteLine(TossMultipleCoins(5));
Console.WriteLine("-------------------------");
/*
Nombres
Construye una función Nombres que devuelva una lista de cadenas. En esta función:​
Se requiere: 
Crea una lista con los valores Todd, Tiffany, Charlie, Ginebra, Sydney. ​
Devuelve una lista que solo incluya nombres de más de 5 caracteres. ​
*/
static List<String> Nombres()
{

    List<String> ListaNombres = new List<string>() { "Todd", "Tiffany", "Charlie", "Ginebra", "Sydney" };

    int caracteres = 0;
    Random rand = new Random();

    for (var i = 0; i < ListaNombres.Count; i++)
    {
        caracteres = ListaNombres[i].Length;
        if (caracteres > 5)
        {
            Console.WriteLine(ListaNombres[i]);
        }

    }
    return ListaNombres;
};
Nombres();