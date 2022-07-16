

void findCoordinates (double k1, double k2, double b1, double b2)
{
    double x = (b1 - b2)/(k2 - k1);
    double y = x * k1 + b1;
    Console.WriteLine("{0} , {1}", x , y);
}

findCoordinates(5,9,2,4);