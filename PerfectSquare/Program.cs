    int x = 49;

    if (isPerfectSquare(x)){
    Console.WriteLine("True");
    }
    else

    Console.WriteLine("False");



    static bool isPerfectSquare(int x)
    {
    if (x >= 0) {

    int sr = (int)Math.Sqrt(x);
    Console.WriteLine(sr);
    return ((sr * sr) == x);
    }
    return false;
    }