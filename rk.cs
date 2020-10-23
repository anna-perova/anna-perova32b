using System;
class Program
{
    delegate int PlusOrMinus(int p1, int p2);
    static int Plus(int p1, int p2)
    {
        return p1 + p2;
    }
  static int Minus(int p1, int p2)
    {
        return p1 - p2;
    }
    static void PlusOrMinusMethod(
    string str,
    int i1,
    int i2,
    PlusOrMinus PlusOrMinusParam)
    {
        int Result = PlusOrMinusParam(i1, i2);
        Console.WriteLine(str + Result.ToString());
    }
    static void Main(string[] args)
    {
        int i1 = 3;
        int i2 = 2;
        PlusOrMinusMethod("Плюс: ", i1, i2, Plus);
        PlusOrMinusMethod("Минус: ", i1, i2, Minus);
    }
}