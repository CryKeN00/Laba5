Console.WriteLine("Введите размер массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] mass =  new int[N];
for (int i = 0; i < N; i++)
{
    Console.WriteLine($"Введите элемент массива №{i + 1}");
    mass[i] = Convert.ToInt32(Console.ReadLine());
}
int zero = 0;
for (int i = 0; i < N; i++)
{
    if (mass[i] == 0)
    {
        zero++;
    }
}
int[] nol = new int[N - zero];
int ind = 0;
for (int i = 0; i < N; i++)
{
    if (mass[i] != 0)
    {
        nol[ind] = mass[i];
        ind++;
    }
}
for (int i = 0; i < nol.Length; i++)
{
    Console.WriteLine($"Элемент нового массива {nol[i]}");
}

