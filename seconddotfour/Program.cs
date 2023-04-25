Random r  = new Random();

int[,] mas = new int[15, 15];

for (int i = 0; i < 15; i++)
{
    for(int j = 0; j < 15; j++)
    {
        mas[i, j] = r.Next(0, 20);
    }
}

for (int i = 0; i < 15; i++)
{
    for (int j = 0;j < 15; j++)
    {
        if (mas[i, 0] == 1)
        {
            Console.WriteLine("Строка номер: " + i);
            int allNumsInRow = 0;
            for (int f = 0; f < 15; f++)
                allNumsInRow += mas[i, f];
            Console.WriteLine("Среднее арифметическое элементов строки: " + (allNumsInRow / 15));
        }
    }
}