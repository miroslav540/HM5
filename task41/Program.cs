int M = Convert.ToInt32(Console.ReadLine());
int howManyPositives = 0;
for(int i = 0; i< M; i++)
{
    int digit = Convert.ToInt32(Console.ReadLine());
    if (digit > 0)
    {
        howManyPositives++;
    }
}

Console.WriteLine("Positives: {0}", howManyPositives);