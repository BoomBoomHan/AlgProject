using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgProject.LabForms;

//定义n*n矩阵类
internal class Matrix
{
	private int n;
	private int[,] matrix;

	public Matrix(int n)
	{
		this.n = n;
		matrix = new int[n, n];
	}

	//构造矩阵并可以指定初值
	public Matrix(int n, int val)
	{
		this.n = n;
		matrix = new int[n, n];
		for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < n; j++)
			{
				matrix[i, j] = val;
			}
		}
	}

	public int this[int i, int j]
	{
		get => matrix[i, j];
		set => matrix[i, j] = value;
	}

	public int N => n;

	//随机生成一个n阶方阵，n=2^k,k>=3，方阵的每个元素的值在0~100之间
	public static Matrix GenerateRandomMatrix(int n, Random random)
	{
		var matrix = new Matrix(n);
		for (var i = 0; i < n; i++)
		{
			for (var j = 0; j < n; j++)
			{
				matrix[i, j] = random.Next(0, 100);
			}
		}
		return matrix;
	}

	//将矩阵转换为字符串，每个元素占4个字符，右对齐
	public override string ToString()
	{
		var sb = new StringBuilder();
		for (var i = 0; i < n; i++)
		{
			for (var j = 0; j < n; j++)
			{
				sb.Append(matrix[i, j].ToString().PadLeft(8));
			}
			sb.Append(Environment.NewLine);
		}
		return sb.ToString();
	}

	//计算矩阵A+B，需要检测
	public static Matrix operator +(Matrix a, Matrix b)
	{
		if (a.N != b.N)
		{
			throw new Exception("矩阵A和B的阶数不相等");
		}
		var c = new Matrix(a.N);
		for (var i = 0; i < a.N; i++)
		{
			for (var j = 0; j < a.N; j++)
			{
				c[i, j] = a[i, j] + b[i, j];
			}
		}
		return c;
	}

	//计算矩阵A-B，需要检测
	public static Matrix operator -(Matrix a, Matrix b)
	{
		if (a.N != b.N)
		{
			throw new Exception("矩阵A和B的阶数不相等");
		}
		var c = new Matrix(a.N);
		for (var i = 0; i < a.N; i++)
		{
			for (var j = 0; j < a.N; j++)
			{
				c[i, j] = a[i, j] - b[i, j];
			}
		}
		return c;
	}

	//合并四个矩阵，需要检测
	private static Matrix Combine(Matrix m1, Matrix m2, Matrix m3, Matrix m4)
	{
		if (m1.N != m2.N || m1.N != m3.N || m1.N != m4.N)
		{
			throw new Exception("矩阵的阶数不相等");
		}
		var n = m1.N;
		var c = new Matrix(2 * n);
		for (var i = 0; i < n; i++)
		{
			for (var j = 0; j < n; j++)
			{
				c[i, j] = m1[i, j];
				c[i, j + n] = m2[i, j];
				c[i + n, j] = m3[i, j];
				c[i + n, j + n] = m4[i, j];
			}
		}
		return c;
	}

	//通过蛮力法计算N阶方阵C=A*B
	public static Matrix Mult_Force(Matrix a, Matrix b)
	{
		var n = a.N;
		var c = new Matrix(n);
		for (var i = 0; i < n; i++)
		{
			for (var j = 0; j < n; j++)
			{
				c[i, j] = 0;
				for (var k = 0; k < n; k++)
				{
					c[i, j] += a[i, k] * b[k, j];
				}
			}
		}
		return c;
	}
	
	public static Matrix Mult_Strassen(Matrix a, Matrix b)
	{
		var n = a.N;
		
		//如果矩阵大小为1，则直接相乘
		if (n == 1)
		{
			return new Matrix(1, a[0, 0] * b[0, 0]);
		}

		//将矩阵分为四个子矩阵
		Matrix a11 = new Matrix(n / 2);
		Matrix a12 = new Matrix(n / 2);
		Matrix a21 = new Matrix(n / 2);
		Matrix a22 = new Matrix(n / 2);
		Matrix b11 = new Matrix(n / 2);
		Matrix b12 = new Matrix(n / 2);
		Matrix b21 = new Matrix(n / 2);
		Matrix b22 = new Matrix(n / 2);
		Matrix c11, c12, c21, c22;
		for (var i = 0; i < n / 2; i++)
		{
			for (var j = 0; j < n / 2; j++)
			{
				a11[i, j] = a[i, j];
				a12[i, j] = a[i, j + n / 2];
				a21[i, j] = a[i + n / 2, j];
				a22[i, j] = a[i + n / 2, j + n / 2];
				b11[i, j] = b[i, j];
				b12[i, j] = b[i, j + n / 2];
				b21[i, j] = b[i + n / 2, j];
				b22[i, j] = b[i + n / 2, j + n / 2];
			}
		}
		//计算子矩阵C11、C12、C21、C22
		c11 = Mult_Strassen(a11, b11) + Mult_Strassen(a12, b21);
		c12 = Mult_Strassen(a11, b12) + Mult_Strassen(a12, b22);
		c21 = Mult_Strassen(a21, b11) + Mult_Strassen(a22, b21);
		c22 = Mult_Strassen(a21, b12) + Mult_Strassen(a22, b22);
		//将子矩阵C11、C12、C21、C22合并为矩阵C并返回
		return Combine(c11, c12, c21, c22);
	}
}