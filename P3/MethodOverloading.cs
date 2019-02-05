using System;

public class MethodOverloading
{
    public static int add(int i, int j)
    {
        return i + j;
    }
    public static Vector add(Vector v1, Vector v2)
    {
        Vector temp = new Vector();
        temp.i = v1.i + v2.i;
        return temp;
    }
    public static Matrix add(Matrix m1, Matrix m2)
    {
        Matrix temp = new Matrix();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                temp.mat[i,j] = m1.mat[i, j] + m2.mat[i, j];
            }
        }
        return temp;
    }
    public static void Main()
    {
        int a = 5, b = 10;
        Vector x = new Vector(20);
        Vector y = new Vector(30);
        Vector z;

        int[,] a1 = new int[3, 3];
        int[,] a2 = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                a1[i, j] = i + j;
                a2[j, i] = i + j;
            }
        }
        Matrix mat1 = new Matrix(a1);
        Matrix mat2 = new Matrix(a2);
        Matrix mat = new Matrix();

        int  intg = add(a, b);
        Console.WriteLine(intg);

        z = add(x, y);
        Console.WriteLine(z.ToString());

        mat = add(mat1, mat2);
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(mat.mat[i,j].ToString() + " ");
            }
            Console.WriteLine();
        }
        
            
    }
}
public class Vector
{
    public int i;
    public Vector() { }
    public Vector(int i)
    {
        this.i = i;
    }
    
    public override String ToString()
    {
        return i.ToString();
    }
}

public class Matrix
{
    public int[,] mat = new int[3, 3];
    public Matrix() { }
    public Matrix(int[,] mat)
    {
        this.mat = mat;
    }

    public override string ToString()
    {
        return mat.ToString();
    }
}