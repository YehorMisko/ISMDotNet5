using MatrixLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGridMatrixVis;

namespace DataGridMatrixVis
{
    public class MatrixVisual
    {
        protected DataGridView DataGrid;
        public MatrixVisual(DataGridView n)
        {
            DataGrid = n;
        }
        public void Initialize(int rowsCount, int collsCount)
        {
            DataGrid.RowCount = rowsCount;
            DataGrid.ColumnCount = collsCount;
            for (int i = 0; i < DataGrid.ColumnCount; i++)
            {
                DataGrid.Columns[i].Width = 80;
            }
        }

        public void Fill(Matrixfunc matrix)
        {
            int[,] matr = matrix.GetMatrix();
            Initialize(matr.GetLength(0), matr.GetLength(1));
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    DataGrid[j, i].Value = matr[i, j];

                }
            }
        }
        public void ArrayFill(int[,] arr)
        {
           
            Initialize(arr.GetLength(0), arr.GetLength(1));
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    DataGrid[j, i].Value = arr[i, j];

                }
            }
        }
        public void NumerateRowsAndCols()
        {
            for (int i = 0; i < DataGrid.ColumnCount; i++)
            {
                DataGrid.Columns[i].HeaderText = i.ToString();
            }

            for (int i = 0; i < DataGrid.RowCount; i++)
            {
                DataGrid.Rows[i].HeaderCell.Value = i.ToString();
            }
            DataGrid.RowHeadersWidth = 80;

        }
    }
    }

