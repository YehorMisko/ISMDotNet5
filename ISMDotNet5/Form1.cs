using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatrixLibrary;
using DataGridMatrixVis;


namespace ISMDotNet5
{
    public partial class MyMatrix : Form
    {
        public MyMatrix()
        {
            InitializeComponent();
        }

        private void GenerateMatrix_Click(object sender, EventArgs e)
        {
            
            Matrixfunc matrix = new Matrixfunc(Convert.ToInt32(numericRow.Value), 
                Convert.ToInt32(numericCol.Value));
            matrix.RandomFill();
          
            MatrixVisual dataGridViewVisualizer = new MatrixVisual(dataGridMatrix);
            
            dataGridViewVisualizer.Fill(matrix);
            dataGridViewVisualizer.NumerateRowsAndCols();
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            Matrixfunc matrix = new Matrixfunc(Convert.ToInt32(numericRow.Value),
                Convert.ToInt32(numericCol.Value));
            matrix.DataFill(dataGridMatrix);
            
          labelPositiveElementCount.Text = matrix.PositiveElementCount().ToString();
          labelPositiveElementCount.TextAlign = (ContentAlignment)HorizontalAlignment.Center;
          labelPositiveElementCount.Visible = true;
        }

        private void numericRow_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonMaxRepeatedElement_Click(object sender, EventArgs e)
        {
            Matrixfunc matrix = new Matrixfunc(Convert.ToInt32(numericRow.Value),
               Convert.ToInt32(numericCol.Value));
            matrix.DataFill(dataGridMatrix);

            labelMaxRepeatedElement.Text = matrix.MaxRepeatedElement().ToString();
            if (matrix.MaxRepeatedElement() == -1)
            {
               labelMaxRepeatedElement.Text = "No Repeating Elements";
            }
            labelMaxRepeatedElement.TextAlign = (ContentAlignment)HorizontalAlignment.Center;
            labelMaxRepeatedElement.Visible = true;
        }

        private void buttonNoZeroElementRow_Click(object sender, EventArgs e)
        {
            Matrixfunc matrix = new Matrixfunc(Convert.ToInt32(numericRow.Value),
               Convert.ToInt32(numericCol.Value));
            matrix.DataFill(dataGridMatrix);

            labelNoZeroElementsRows.Text = matrix.NoZeroElemntsRowCount().ToString();
            if (matrix.NoZeroElemntsRowCount() == 0)
            {
                labelNoZeroElementsRows.Text = "No rows without zeros";
            }
            labelNoZeroElementsRows.TextAlign = (ContentAlignment)HorizontalAlignment.Center;
            labelNoZeroElementsRows.Visible = true;
        }

        private void buttonColumnsWithZerosCount_Click(object sender, EventArgs e)
        {
            Matrixfunc matrix = new Matrixfunc(Convert.ToInt32(numericRow.Value),
               Convert.ToInt32(numericCol.Value));
            matrix.DataFill(dataGridMatrix);

            labelColumnsWithZerosCount.Text = matrix.ColumnWithZeroElementsCount().ToString();
            if (matrix.ColumnWithZeroElementsCount() == 0)
            {
                labelColumnsWithZerosCount.Text = "No Columns with Zeros";
            }
            labelColumnsWithZerosCount.TextAlign = (ContentAlignment)HorizontalAlignment.Center;
            labelColumnsWithZerosCount.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Matrixfunc matrix = new Matrixfunc(Convert.ToInt32(numericRow.Value),
               Convert.ToInt32(numericCol.Value));
            matrix.DataFill(dataGridMatrix);

            labelRowRepeatedElement.Text = matrix.MaxInARowIndex().ToString();
            if (matrix.MaxInARowIndex() == -1)
            {
                labelRowRepeatedElement.Text = "No Repeating Elements in rows";
            }
            labelRowRepeatedElement.TextAlign = (ContentAlignment)HorizontalAlignment.Center;
            labelRowRepeatedElement.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Matrixfunc matrix = new Matrixfunc(Convert.ToInt32(numericRow.Value),
               Convert.ToInt32(numericCol.Value));
            matrix.DataFill(dataGridMatrix);

            labelMaxSumDiagonalParallelMain.Text = matrix.MaxParalelSum().ToString();
            labelMaxSumDiagonalParallelMain.TextAlign = (ContentAlignment)HorizontalAlignment.Center;
            labelMaxSumDiagonalParallelMain.Visible = true;
        }

        private void buttonProductOfRowsWithNoNegativeElements_Click(object sender, EventArgs e)
        {
            Matrixfunc matrix = new Matrixfunc(Convert.ToInt32(numericRow.Value),
               Convert.ToInt32(numericCol.Value));
            matrix.DataFill(dataGridMatrix);

            labelProductOfNoNegagitveElementRows.Text = matrix.ProductOfRowNoNegativeElements().ToString();
            if (matrix.ProductOfRowNoNegativeElements() == 0)
            {
                labelProductOfNoNegagitveElementRows.Text = "No Negativeles Rows Elements";
            }
            labelProductOfNoNegagitveElementRows.TextAlign = (ContentAlignment)HorizontalAlignment.Center;
            labelProductOfNoNegagitveElementRows.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonMisSumParallel_Click(object sender, EventArgs e)
        {

            Matrixfunc matrix = new Matrixfunc(Convert.ToInt32(numericRow.Value),
               Convert.ToInt32(numericCol.Value));
            matrix.DataFill(dataGridMatrix);

            labelMinSumParallel.Text = matrix.MinParalelSum().ToString();
            labelMinSumParallel.TextAlign = (ContentAlignment)HorizontalAlignment.Center;
            labelMinSumParallel.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Matrixfunc matrix = new Matrixfunc(Convert.ToInt32(numericRow.Value),
               Convert.ToInt32(numericCol.Value));
            matrix.DataFill(dataGridMatrix);

            labelCollSumNoNegative.Text = matrix.SumOfNonNegativeColElements().ToString();
            if (matrix.SumOfNonNegativeColElements() == 0)
            {
                labelCollSumNoNegative.Text = "There are no Columns without Negative Elements";
            }
            labelCollSumNoNegative.TextAlign = (ContentAlignment)HorizontalAlignment.Center;
            labelCollSumNoNegative.Visible = true;
        }

        private void labelSumOfColsWithNeagtiveElements_Click(object sender, EventArgs e)
        {

        }

        private void buttonSumOfColsWithNegativeElements_Click(object sender, EventArgs e)
        {
            Matrixfunc matrix = new Matrixfunc(Convert.ToInt32(numericRow.Value),
               Convert.ToInt32(numericCol.Value));
            matrix.DataFill(dataGridMatrix);

            labelSumOfColsWithNeagtiveElements.Text = matrix.SumOfNegativeColElements().ToString();
            if (matrix.SumOfNegativeColElements() == 0)
            {
                labelSumOfColsWithNeagtiveElements.Text = "There are no Columns with Negative Elements";
            }
            labelSumOfColsWithNeagtiveElements.TextAlign = (ContentAlignment)HorizontalAlignment.Center;
            labelSumOfColsWithNeagtiveElements.Visible = true;
        }

        private void buttonTranspontMatrix_Click(object sender, EventArgs e)
        {
            Matrixfunc matrix = new Matrixfunc(Convert.ToInt32(numericRow.Value),
               Convert.ToInt32(numericCol.Value));
            matrix.DataFill(dataGridMatrix);

            //   MatrixVisual dataGridViewVisualizer = new MatrixVisual(dataGridMatrix);

          
            MatrixVisual dataGridViewVisualizer = new MatrixVisual(dataGridMatrixTranspont);
            int[,] arr = matrix.TranspontMatrix(); 
            dataGridViewVisualizer.ArrayFill(arr);
            dataGridMatrixTranspont.Visible = true;
            dataGridViewVisualizer.NumerateRowsAndCols();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
