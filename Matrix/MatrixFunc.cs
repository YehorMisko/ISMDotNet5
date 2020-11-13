using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixLibrary

{
    public class Matrixfunc
    {
        protected int[,] Matr;

        public Matrixfunc(int rowCount, int colCount)
        {
            Matr = new int[rowCount, colCount];
        }
        public int[,] GetMatrix()
        {
            return Matr;
        }
        public int PositiveElementCount()
        {
            int k = 0;
            for (int i = 0; i < Matr.GetLength(0); i++)
            {
                for(int j = 0; j < Matr.GetLength(1); j++)
                {
                    if (Matr[i, j] > 0)
                        k++;
                }
               
            }
            return k;
        }
        public void RandomFill(int min = -100, int max = 100)
        {
            Random rnd = new Random();
            for (int i = 0; i < Matr.GetLength(0); i++)
            {
                for (int j = 0; j < Matr.GetLength(1); j++)
                {
                    Matr[i, j] = rnd.Next(min, max);
                }
            }
        }
        public int MaxRepeatedElement()
        {
            int q = -1;
            int[] arr = new int[Matr.GetLength(0) * Matr.GetLength(1)];
            for (int i = 0, k = 0; i < Matr.GetLength(0); i++)
            {
                for (int j = 0; j < Matr.GetLength(1); j++)
                {
                   arr[k] = Matr[i, j];
                    k++;  
                }
            }
            Array.Sort(arr);
          for (int i = arr.Length - 1; i > 0; i--)
            {
                if(arr[i] == arr[i - 1])
                {
                    q = arr[i];
                    break;
                }
             
            }
        
            return q;
        }
        public int NoZeroElemntsRowCount()
        {
            int n = 0;
            
            for (int i = 0; i < Matr.GetLength(0); i++)
            {
                for (int j = 0; j < Matr.GetLength(1); j++)
                {
                    if(Matr[i,j] == 0)
                    {
                        n++;
                        break;
                    }
                }
            }
            return Matr.GetLength(0) - n;
        }
        public int ColumnWithZeroElementsCount()
        {
            int n = 0;

            for (int i = 0; i < Matr.GetLength(0); i++)
            {
                for (int j = 0; j < Matr.GetLength(1); j++)
                {
                    if (Matr[i, j] == 0)
                    {
                        n++;
                        break;
                    }
                }
            }
            return n;
        }
        public int MaxInARowIndex()
        {
            int k = 0;
            int[] jeff = new int[Matr.GetLength(0)];

            for (int i = 0; i < Matr.GetLength(0); i++)
            {
                int n = 0;
                int q = 0;
                for (int j = 0; j < Matr.GetLength(1) - 1; j++)
                {
                    while(Matr[i,j] == Matr[i,j+1] && j < Matr.GetLength(1))
                    {
                        n++;
                        j++;
                    }
                    if (q < n)q = n;
                    n = 0;
                }
                jeff[k] = q;
                k++;
            }
            int r = -1;
            int b = 0;
            for (int i = 0; i < Matr.GetLength(0); i++)
            {
                if (b < jeff[i]) { b = jeff[i]; r = i; }
            }
            return r;
        }
        public int ProductOfRowNoNegativeElements()
        {
            int n = 1;
            int k = 0;
            for (int i = 0; i < Matr.GetLength(0); i++)
            {
                bool f = false;

                for (int j = 0; j < Matr.GetLength(1); j++)
                {
                    if (Matr[i, j] < 0)
                    {
                        f = true;
                        k++;
                        break;
                    }
                }
                if (f == true)
                    for (int j = 0; j < Matr.GetLength(1); j++)
                    {
                        n *= Matr[i, j];

                    }

            }
            if (k == 0) return 0;
            else
                return n;
        }
        public int MaxParalelSum()
        {
            int[] arr = new int[Matr.GetLength(0) + Matr.GetLength(1) - 2];
            int k = 0;
           
                for (int j = 1; j < Matr.GetLength(1); j++)
                {
                    int n = 0;
                   
                    for(int q = j; q < Matr.GetLength(1);q++)
                    {
                    if (n > Matr.GetLength(0) - 1)
                        break;
                    arr[k] += Matr[n,q];
                        n++;                     
                    }
                k++;
                }
          
            
            for (int i = 1; i < Matr.GetLength(0); i++)
            {
                int n = 0;

                for (int q = i; q < Matr.GetLength(0); q++)
                {
                    if (n > Matr.GetLength(1) - 1)
                        break;
                    arr[k] += Matr[q, n];
                    n++;
                }
                k++;
            }
            Array.Sort(arr);
            return arr[arr.GetLength(0)-1];

        }

        public int MinParalelSum()
        {

            int[] arr = new int[Matr.GetLength(0) + Matr.GetLength(1) - 2];
            int k = 0;

           for (int i = Matr.GetLength(0) - 2; i >= 0; i--)
            {
                int n = 0;
               
                for (int q = i; q >= 0; q--)
                {
                    if (n == Matr.GetLength(1))
                        break;
                    arr[k] += Math.Abs(Matr[q, n]);
                    n++;
         
                }
                k++;
            }

        for (int j = 1; j < Matr.GetLength(1); j++)
            {
                int n = Matr.GetLength(0)-1;
               
                for (int q = j; q < Matr.GetLength(1); q++)
                {
                    if (n < 0)
                        break;
                    arr[k] += Math.Abs(Matr[n, q]);
                    n--;
   
                }
                k++;
            }
  
            Array.Sort(arr);
            return arr[0];
        }
        public int SumOfNegativeColElements()
        {
            int n = 0;
            int k = 0;
      
                for (int i = 0; i < Matr.GetLength(1); i++)
                {
                    bool f = false;

                    for (int j = 0; j < Matr.GetLength(0); j++)
                    {
                        if (Matr[j, i] < 0)
                        {
                            f = true;
                            k++;
                            break;
                        }
                    }
                    if (f == true)
                        for (int j = 0; j < Matr.GetLength(0); j++)
                        {
                            n += Matr[j, i];

                        }
            }
           
            if (k == 0) return 0;
            else
                return n;
        }
        public int SumOfNonNegativeColElements()
        {
            int n = 0;
            int k = 0;
            
               for (int i = 0; i < Matr.GetLength(1); i++)
                {
                    bool f = false;

                    for (int j = 0; j < Matr.GetLength(0); j++)
                    {
                        if (Matr[j, i] < 0)
                        {
                            f = true;    
                            break;
                        }
                    }
                    if (f == false)
                        for (int j = 0; j < Matr.GetLength(0); j++)
                        {
                            n += Matr[j, i];
                             k++;
                        }

                }   
                if (k == 0) return -1;
            else
                return n;
        }
        public int[,] TranspontMatrix()
        {
            int[,] arr = new int[Matr.GetLength(1), Matr.GetLength(0)];
            for (int i = 0; i < Matr.GetLength(0); i++)
            {
                for (int j = 0; j < Matr.GetLength(1); j++)
                {
                    arr[j, i] = Matr[i, j];
                }
               
            }
            return arr;
        }
        public int[,] DataFill(DataGridView DataGrid)
        {
            
           for (int i = 0; i < Matr.GetLength(0); i++)
            {
                for (int j = 0; j < Matr.GetLength(1); j++)
                {
                    Matr[i, j] = (int)DataGrid[j, i].Value;

                }
            }
                return Matr;
        }
    }
}
