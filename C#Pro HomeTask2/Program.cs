void cypher(string str, out string result, out string key)
{
    Random rnd = new Random();
    int[] array = new int[str.Length];
    result = "";
    key = "";
    for (int i = 0; i < str.Length; i++)
    {
        array[i] = rnd.Next(10);
        key += array[i];
        char s = str[i];
        //Console.WriteLine(array[i]);
        result += ((char)(s + array[i]));

    }

}

    string result;
    string key;
    Console.WriteLine("Input some: ");
    var str = Console.ReadLine();
    cypher(str, out result, out key);
    Console.WriteLine("This is key: ");
    Console.WriteLine(key);
    Console.WriteLine("This is result: ");
    Console.WriteLine(result);
