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
        result += ((char)(s + array[i]));

    }

}

void decoder(string str, string key, out string resultDecod)
{
    resultDecod = "";
    for (int i = 0; i < str.Length; i++)
    {
        char s = str[i];
        resultDecod += (char)(s - (key[i] - '0'));

    }
}

Console.WriteLine("Enter number 1 or 2. Where 1 is for encoding and 2 is for decoding characters: ");
int a = 1;
a = Int32.Parse(Console.ReadLine());
if (a <= 1)
{
    string result;
    string key;
    Console.WriteLine("Input some: ");
    var str = Console.ReadLine();
    cypher(str, out result, out key);
    Console.WriteLine("This is key: ");
    Console.WriteLine(key);
    Console.WriteLine("This is result: ");
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Input coded result: ");
    var str = Console.ReadLine();
    Console.WriteLine("Input key: ");
    var key = Console.ReadLine();
    Console.WriteLine("This is result: ");
    string resultDecod;
    decoder(str, key, out resultDecod);
    Console.WriteLine(resultDecod);
}