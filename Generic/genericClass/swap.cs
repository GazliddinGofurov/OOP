static class Swapper<T>
{
    public static  void Swap(ref T x, ref T y)
    {
        T temp = x;
        x = y;
        y =temp;
    }
}


    

