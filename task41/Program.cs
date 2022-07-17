    Console.WriteLine("Enter yours massive");
    var a = Console.ReadLine()
        .Split(new[] {" "},StringSplitOptions.RemoveEmptyEntries)
        .Select(Int32.Parse);
    int positives = 0;
    foreach (var i in a)
{
    if (i > 0)
    {
        positives++;
    }
}
Console.WriteLine("Positives: {0}", positives);
