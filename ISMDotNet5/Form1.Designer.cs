namespace ISMDotNet5
{
    partial class MyMatrix
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridMatrix = new System.Windows.Forms.DataGridView();
            this.GenerateMatrix = new System.Windows.Forms.Button();
            this.numericRow = new System.Windows.Forms.NumericUpDown();
            this.numericCol = new System.Windows.Forms.NumericUpDown();
            this.buttonPositiveElCount = new System.Windows.Forms.Button();
            this.labelPositiveElementCount = new System.Windows.Forms.Label();
            this.buttonMaxRepeatedElement = new System.Windows.Forms.Button();
            this.buttonNoZeroElementRow = new System.Windows.Forms.Button();
            this.buttonColumnsWithZerosCount = new System.Windows.Forms.Button();
            this.buttonRowWithMostRepeatedElements = new System.Windows.Forms.Button();
            this.buttonMaxOfSumDiag = new System.Windows.Forms.Button();
            this.buttonProductOfRowsWithNoNegativeElements = new System.Windows.Forms.Button();
            this.buttonMisSumParallel = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonSumOfColsWithNegativeElements = new System.Windows.Forms.Button();
            this.labelMaxRepeatedElement = new System.Windows.Forms.Label();
            this.labelNoZeroElementsRows = new System.Windows.Forms.Label();
            this.labelColumnsWithZerosCount = new System.Windows.Forms.Label();
            this.labelRowRepeatedElement = new System.Windows.Forms.Label();
            this.labelMaxSumDiagonalParallelMain = new System.Windows.Forms.Label();
            this.labelProductOfNoNegagitveElementRows = new System.Windows.Forms.Label();
            this.labelMinSumParallel = new System.Windows.Forms.Label();
            this.labelCollSumNoNegative = new System.Windows.Forms.Label();
            this.labelSumOfColsWithNeagtiveElements = new System.Windows.Forms.Label();
            this.buttonTranspontMatrix = new System.Windows.Forms.Button();
            this.dataGridMatrixTranspont = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatrixTranspont)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMatrix
            // 
            this.dataGridMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMatrix.Location = new System.Drawing.Point(10, 102);
            this.dataGridMatrix.Name = "dataGridMatrix";
            this.dataGridMatrix.Size = new System.Drawing.Size(856, 150);
            this.dataGridMatrix.TabIndex = 0;
            // 
            // GenerateMatrix
            // 
            this.GenerateMatrix.Location = new System.Drawing.Point(405, 73);
            this.GenerateMatrix.Name = "GenerateMatrix";
            this.GenerateMatrix.Size = new System.Drawing.Size(75, 23);
            this.GenerateMatrix.TabIndex = 1;
            this.GenerateMatrix.Text = "Generate Matrix";
            this.GenerateMatrix.UseVisualStyleBackColor = true;
            this.GenerateMatrix.Click += new System.EventHandler(this.GenerateMatrix_Click);
            // 
            // numericRow
            // 
            this.numericRow.Location = new System.Drawing.Point(723, 50);
            this.numericRow.Name = "numericRow";
            this.numericRow.Size = new System.Drawing.Size(120, 20);
            this.numericRow.TabIndex = 2;
            this.numericRow.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericRow.ValueChanged += new System.EventHandler(this.numericRow_ValueChanged);
            // 
            // numericCol
            // 
            this.numericCol.Location = new System.Drawing.Point(67, 50);
            this.numericCol.Name = "numericCol";
            this.numericCol.Size = new System.Drawing.Size(120, 20);
            this.numericCol.TabIndex = 3;
            this.numericCol.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // buttonPositiveElCount
            // 
            this.buttonPositiveElCount.Location = new System.Drawing.Point(10, 268);
            this.buttonPositiveElCount.Name = "buttonPositiveElCount";
            this.buttonPositiveElCount.Size = new System.Drawing.Size(205, 23);
            this.buttonPositiveElCount.TabIndex = 4;
            this.buttonPositiveElCount.Text = "Amount of Positive Elements";
            this.buttonPositiveElCount.UseVisualStyleBackColor = true;
            this.buttonPositiveElCount.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // labelPositiveElementCount
            // 
            this.labelPositiveElementCount.Location = new System.Drawing.Point(44, 311);
            this.labelPositiveElementCount.Name = "labelPositiveElementCount";
            this.labelPositiveElementCount.Size = new System.Drawing.Size(152, 13);
            this.labelPositiveElementCount.TabIndex = 5;
            this.labelPositiveElementCount.Text = "labelSumoFPositiveElements";
            this.labelPositiveElementCount.Visible = false;
            // 
            // buttonMaxRepeatedElement
            // 
            this.buttonMaxRepeatedElement.Location = new System.Drawing.Point(224, 268);
            this.buttonMaxRepeatedElement.Name = "buttonMaxRepeatedElement";
            this.buttonMaxRepeatedElement.Size = new System.Drawing.Size(205, 23);
            this.buttonMaxRepeatedElement.TabIndex = 6;
            this.buttonMaxRepeatedElement.Text = "Maximum Repeated Element";
            this.buttonMaxRepeatedElement.UseVisualStyleBackColor = true;
            this.buttonMaxRepeatedElement.Click += new System.EventHandler(this.buttonMaxRepeatedElement_Click);
            // 
            // buttonNoZeroElementRow
            // 
            this.buttonNoZeroElementRow.Location = new System.Drawing.Point(440, 268);
            this.buttonNoZeroElementRow.Name = "buttonNoZeroElementRow";
            this.buttonNoZeroElementRow.Size = new System.Drawing.Size(205, 23);
            this.buttonNoZeroElementRow.TabIndex = 8;
            this.buttonNoZeroElementRow.Text = "Amount of Rows with no Zeros";
            this.buttonNoZeroElementRow.UseVisualStyleBackColor = true;
            this.buttonNoZeroElementRow.Click += new System.EventHandler(this.buttonNoZeroElementRow_Click);
            // 
            // buttonColumnsWithZerosCount
            // 
            this.buttonColumnsWithZerosCount.Location = new System.Drawing.Point(661, 268);
            this.buttonColumnsWithZerosCount.Name = "buttonColumnsWithZerosCount";
            this.buttonColumnsWithZerosCount.Size = new System.Drawing.Size(205, 23);
            this.buttonColumnsWithZerosCount.TabIndex = 9;
            this.buttonColumnsWithZerosCount.Text = "Amount of Columns with Zeros";
            this.buttonColumnsWithZerosCount.UseVisualStyleBackColor = true;
            this.buttonColumnsWithZerosCount.Click += new System.EventHandler(this.buttonColumnsWithZerosCount_Click);
            // 
            // buttonRowWithMostRepeatedElements
            // 
            this.buttonRowWithMostRepeatedElements.Location = new System.Drawing.Point(10, 351);
            this.buttonRowWithMostRepeatedElements.Name = "buttonRowWithMostRepeatedElements";
            this.buttonRowWithMostRepeatedElements.Size = new System.Drawing.Size(205, 23);
            this.buttonRowWithMostRepeatedElements.TabIndex = 10;
            this.buttonRowWithMostRepeatedElements.Text = "Row With the Most Repeated Elements";
            this.buttonRowWithMostRepeatedElements.UseVisualStyleBackColor = true;
            this.buttonRowWithMostRepeatedElements.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonMaxOfSumDiag
            // 
            this.buttonMaxOfSumDiag.Location = new System.Drawing.Point(438, 351);
            this.buttonMaxOfSumDiag.Name = "buttonMaxOfSumDiag";
            this.buttonMaxOfSumDiag.Size = new System.Drawing.Size(200, 23);
            this.buttonMaxOfSumDiag.TabIndex = 11;
            this.buttonMaxOfSumDiag.Text = "Max sum of Diagonals parallel to main";
            this.buttonMaxOfSumDiag.UseVisualStyleBackColor = true;
            this.buttonMaxOfSumDiag.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonProductOfRowsWithNoNegativeElements
            // 
            this.buttonProductOfRowsWithNoNegativeElements.Location = new System.Drawing.Point(224, 351);
            this.buttonProductOfRowsWithNoNegativeElements.Name = "buttonProductOfRowsWithNoNegativeElements";
            this.buttonProductOfRowsWithNoNegativeElements.Size = new System.Drawing.Size(205, 23);
            this.buttonProductOfRowsWithNoNegativeElements.TabIndex = 12;
            this.buttonProductOfRowsWithNoNegativeElements.Text = "Product of Negativeless Rows";
            this.buttonProductOfRowsWithNoNegativeElements.UseVisualStyleBackColor = true;
            this.buttonProductOfRowsWithNoNegativeElements.Click += new System.EventHandler(this.buttonProductOfRowsWithNoNegativeElements_Click);
            // 
            // buttonMisSumParallel
            // 
            this.buttonMisSumParallel.Location = new System.Drawing.Point(639, 351);
            this.buttonMisSumParallel.Name = "buttonMisSumParallel";
            this.buttonMisSumParallel.Size = new System.Drawing.Size(235, 23);
            this.buttonMisSumParallel.TabIndex = 13;
            this.buttonMisSumParallel.Text = "Min sum of Abs Diagonals parallel to additional";
            this.buttonMisSumParallel.UseVisualStyleBackColor = true;
            this.buttonMisSumParallel.Click += new System.EventHandler(this.buttonMisSumParallel_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(10, 439);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(282, 23);
            this.button8.TabIndex = 14;
            this.button8.Text = "Sum Of Elements, in Columns without Negative Elements";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // buttonSumOfColsWithNegativeElements
            // 
            this.buttonSumOfColsWithNegativeElements.Location = new System.Drawing.Point(584, 439);
            this.buttonSumOfColsWithNegativeElements.Name = "buttonSumOfColsWithNegativeElements";
            this.buttonSumOfColsWithNegativeElements.Size = new System.Drawing.Size(282, 23);
            this.buttonSumOfColsWithNegativeElements.TabIndex = 15;
            this.buttonSumOfColsWithNegativeElements.Text = "Sum of Columns with Negative Elements";
            this.buttonSumOfColsWithNegativeElements.UseVisualStyleBackColor = true;
            this.buttonSumOfColsWithNegativeElements.Click += new System.EventHandler(this.buttonSumOfColsWithNegativeElements_Click);
            // 
            // labelMaxRepeatedElement
            // 
            this.labelMaxRepeatedElement.Location = new System.Drawing.Point(255, 311);
            this.labelMaxRepeatedElement.Name = "labelMaxRepeatedElement";
            this.labelMaxRepeatedElement.Size = new System.Drawing.Size(152, 13);
            this.labelMaxRepeatedElement.TabIndex = 18;
            this.labelMaxRepeatedElement.Text = "labelMaxRepeatedElement";
            this.labelMaxRepeatedElement.Visible = false;
            // 
            // labelNoZeroElementsRows
            // 
            this.labelNoZeroElementsRows.Location = new System.Drawing.Point(472, 311);
            this.labelNoZeroElementsRows.Name = "labelNoZeroElementsRows";
            this.labelNoZeroElementsRows.Size = new System.Drawing.Size(152, 13);
            this.labelNoZeroElementsRows.TabIndex = 19;
            this.labelNoZeroElementsRows.Text = "labelNoZeroElementsRows";
            this.labelNoZeroElementsRows.Visible = false;
            // 
            // labelColumnsWithZerosCount
            // 
            this.labelColumnsWithZerosCount.Location = new System.Drawing.Point(691, 311);
            this.labelColumnsWithZerosCount.Name = "labelColumnsWithZerosCount";
            this.labelColumnsWithZerosCount.Size = new System.Drawing.Size(152, 13);
            this.labelColumnsWithZerosCount.TabIndex = 20;
            this.labelColumnsWithZerosCount.Text = "labelColumnsWithZerosCount";
            this.labelColumnsWithZerosCount.Visible = false;
            // 
            // labelRowRepeatedElement
            // 
            this.labelRowRepeatedElement.Location = new System.Drawing.Point(15, 405);
            this.labelRowRepeatedElement.Name = "labelRowRepeatedElement";
            this.labelRowRepeatedElement.Size = new System.Drawing.Size(203, 13);
            this.labelRowRepeatedElement.TabIndex = 21;
            this.labelRowRepeatedElement.Text = "labelRowRepeatedElement";
            this.labelRowRepeatedElement.Visible = false;
            // 
            // labelMaxSumDiagonalParallelMain
            // 
            this.labelMaxSumDiagonalParallelMain.Location = new System.Drawing.Point(451, 405);
            this.labelMaxSumDiagonalParallelMain.Name = "labelMaxSumDiagonalParallelMain";
            this.labelMaxSumDiagonalParallelMain.Size = new System.Drawing.Size(194, 13);
            this.labelMaxSumDiagonalParallelMain.TabIndex = 22;
            this.labelMaxSumDiagonalParallelMain.Text = "labelMaxSumDiagonalParallelMain";
            this.labelMaxSumDiagonalParallelMain.Visible = false;
            // 
            // labelProductOfNoNegagitveElementRows
            // 
            this.labelProductOfNoNegagitveElementRows.Location = new System.Drawing.Point(224, 405);
            this.labelProductOfNoNegagitveElementRows.Name = "labelProductOfNoNegagitveElementRows";
            this.labelProductOfNoNegagitveElementRows.Size = new System.Drawing.Size(205, 13);
            this.labelProductOfNoNegagitveElementRows.TabIndex = 23;
            this.labelProductOfNoNegagitveElementRows.Text = "labelProductOfNoNegagitveElementRows";
            this.labelProductOfNoNegagitveElementRows.Visible = false;
            // 
            // labelMinSumParallel
            // 
            this.labelMinSumParallel.Location = new System.Drawing.Point(672, 405);
            this.labelMinSumParallel.Name = "labelMinSumParallel";
            this.labelMinSumParallel.Size = new System.Drawing.Size(202, 13);
            this.labelMinSumParallel.TabIndex = 24;
            this.labelMinSumParallel.Text = "labelMinSumParallel";
            this.labelMinSumParallel.Visible = false;
            // 
            // labelCollSumNoNegative
            // 
            this.labelCollSumNoNegative.Location = new System.Drawing.Point(18, 485);
            this.labelCollSumNoNegative.Name = "labelCollSumNoNegative";
            this.labelCollSumNoNegative.Size = new System.Drawing.Size(282, 13);
            this.labelCollSumNoNegative.TabIndex = 25;
            this.labelCollSumNoNegative.Text = "labelCollSumNoNegative";
            this.labelCollSumNoNegative.Visible = false;
            // 
            // labelSumOfColsWithNeagtiveElements
            // 
            this.labelSumOfColsWithNeagtiveElements.Location = new System.Drawing.Point(584, 485);
            this.labelSumOfColsWithNeagtiveElements.Name = "labelSumOfColsWithNeagtiveElements";
            this.labelSumOfColsWithNeagtiveElements.Size = new System.Drawing.Size(279, 13);
            this.labelSumOfColsWithNeagtiveElements.TabIndex = 26;
            this.labelSumOfColsWithNeagtiveElements.Text = "labelSumOfColsWithNeagtiveElements";
            this.labelSumOfColsWithNeagtiveElements.Visible = false;
            this.labelSumOfColsWithNeagtiveElements.Click += new System.EventHandler(this.labelSumOfColsWithNeagtiveElements_Click);
            // 
            // buttonTranspontMatrix
            // 
            this.buttonTranspontMatrix.Location = new System.Drawing.Point(405, 466);
            this.buttonTranspontMatrix.Name = "buttonTranspontMatrix";
            this.buttonTranspontMatrix.Size = new System.Drawing.Size(75, 23);
            this.buttonTranspontMatrix.TabIndex = 27;
            this.buttonTranspontMatrix.Text = "Transpont Matrix";
            this.buttonTranspontMatrix.UseVisualStyleBackColor = true;
            this.buttonTranspontMatrix.Click += new System.EventHandler(this.buttonTranspontMatrix_Click);
            // 
            // dataGridMatrixTranspont
            // 
            this.dataGridMatrixTranspont.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMatrixTranspont.Location = new System.Drawing.Point(10, 514);
            this.dataGridMatrixTranspont.Name = "dataGridMatrixTranspont";
            this.dataGridMatrixTranspont.Size = new System.Drawing.Size(861, 150);
            this.dataGridMatrixTranspont.TabIndex = 28;
            this.dataGridMatrixTranspont.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(727, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Input amount of Rows";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Input amount of Columns";
            // 
            // MyMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(875, 695);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridMatrixTranspont);
            this.Controls.Add(this.buttonTranspontMatrix);
            this.Controls.Add(this.labelSumOfColsWithNeagtiveElements);
            this.Controls.Add(this.labelCollSumNoNegative);
            this.Controls.Add(this.labelMinSumParallel);
            this.Controls.Add(this.labelProductOfNoNegagitveElementRows);
            this.Controls.Add(this.labelMaxSumDiagonalParallelMain);
            this.Controls.Add(this.labelRowRepeatedElement);
            this.Controls.Add(this.labelColumnsWithZerosCount);
            this.Controls.Add(this.labelNoZeroElementsRows);
            this.Controls.Add(this.labelMaxRepeatedElement);
            this.Controls.Add(this.buttonSumOfColsWithNegativeElements);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.buttonMisSumParallel);
            this.Controls.Add(this.buttonProductOfRowsWithNoNegativeElements);
            this.Controls.Add(this.buttonMaxOfSumDiag);
            this.Controls.Add(this.buttonRowWithMostRepeatedElements);
            this.Controls.Add(this.buttonColumnsWithZerosCount);
            this.Controls.Add(this.buttonNoZeroElementRow);
            this.Controls.Add(this.buttonMaxRepeatedElement);
            this.Controls.Add(this.labelPositiveElementCount);
            this.Controls.Add(this.buttonPositiveElCount);
            this.Controls.Add(this.numericCol);
            this.Controls.Add(this.numericRow);
            this.Controls.Add(this.GenerateMatrix);
            this.Controls.Add(this.dataGridMatrix);
            this.Name = "MyMatrix";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatrixTranspont)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMatrix;
        private System.Windows.Forms.Button GenerateMatrix;
        private System.Windows.Forms.NumericUpDown numericRow;
        private System.Windows.Forms.NumericUpDown numericCol;
        private System.Windows.Forms.Button buttonPositiveElCount;
        private System.Windows.Forms.Label labelPositiveElementCount;
        private System.Windows.Forms.Button buttonMaxRepeatedElement;
        private System.Windows.Forms.Button buttonNoZeroElementRow;
        private System.Windows.Forms.Button buttonColumnsWithZerosCount;
        private System.Windows.Forms.Button buttonRowWithMostRepeatedElements;
        private System.Windows.Forms.Button buttonMaxOfSumDiag;
        private System.Windows.Forms.Button buttonProductOfRowsWithNoNegativeElements;
        private System.Windows.Forms.Button buttonMisSumParallel;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button buttonSumOfColsWithNegativeElements;
        private System.Windows.Forms.Label labelMaxRepeatedElement;
        private System.Windows.Forms.Label labelNoZeroElementsRows;
        private System.Windows.Forms.Label labelColumnsWithZerosCount;
        private System.Windows.Forms.Label labelRowRepeatedElement;
        private System.Windows.Forms.Label labelMaxSumDiagonalParallelMain;
        private System.Windows.Forms.Label labelProductOfNoNegagitveElementRows;
        private System.Windows.Forms.Label labelMinSumParallel;
        private System.Windows.Forms.Label labelCollSumNoNegative;
        private System.Windows.Forms.Label labelSumOfColsWithNeagtiveElements;
        private System.Windows.Forms.Button buttonTranspontMatrix;
        private System.Windows.Forms.DataGridView dataGridMatrixTranspont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

