 private static void PrintType3(int n)
    {
        int[,] matrix = new int[n, n];
        int counter = 0;
        for (int diagonal = 1; diagonal <= n*2 - 1; diagonal++)
        {
            int col = 0;
            int row = n - diagonal;
            int cellstofill = diagonal;
            if (cellstofill>n)
            {
                cellstofill = 2 * n - cellstofill;
                col = diagonal - n;
                row = 0;
            }
            for (int action = 0; action < cellstofill; action++)
            {
                counter++;
                matrix[row, col] = counter;
                row++;
                col++;
            }
        }
        ShowMatrix(matrix);
    }
	/***
		https://github.com/fast4y/TelerikAcademy/blob/master/CSharp%20Part2/C2-2-MultiDimensionalArrays-Homework/01.%20Print4TypesOfMatrix/Print4TypesOfMatrix.cs
	*/