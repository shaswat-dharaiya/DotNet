using System;

public class MethodOverloading
{
    public int add(int i, int j)
    {
        return i + j;
    }
    public Vector add(Vector v1, Vector v2)
    {
        Vector temp = new Vector();
        temp.i = v1.i + v2.i;
        return temp;
    }
    public void add(Matrix m1, Matrix m2)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
            }
        }
    }
    public MethodOverloading();
    public static void Main()
    {
        int a = 5, b = 10;
        Vector x = new Vector(20);
        Vector y = new Vector(30);
        Vector z;

        int  intg = add(a, b);
        Console.WriteLine(intg);

        z = add(x, y);
        Console.WriteLine(z.ToString());
            
    }
}
public class Vector
{
    int i;
    public Vector();
    public Vector(int i)
    {
        this.i = i;
    }
}
/*
public class Matrix
{
    int[,] matx = new int[3, 3];
    int[,] maty = new int[3, 3];
    public Matrix();
    public Matrix(int[,] matx, int[,] maty)
    {
        this.matx = matx;
        this.maty = maty;
    }
}*/