

void findCoordinates ()
{
    Console.WriteLine("Enter coordinates");
    double k1 = Convert.ToInt32(Console.ReadLine());
    double k2 = Convert.ToInt32(Console.ReadLine());
    double b1 = Convert.ToInt32(Console.ReadLine());
    double b2 = Convert.ToInt32(Console.ReadLine());
    double x = (b1 - b2)/(k2 - k1);
    double y = x * k1 + b1;
    Console.WriteLine("{0} , {1}", x , y);
}

findCoordinates();