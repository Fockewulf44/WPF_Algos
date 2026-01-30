using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WPF_Algos.Algorithms
{
    public class MinimumNumberOfFlips
    {
        //Medium
        //3240. Minimum Number of Flips to Make Binary Grid Palindromic II
        //Medium
        //Topics
        //premium lock icon
        //Companies
        //Hint
        //You are given an m x n binary matrix grid.

        //A row or column is considered palindromic if its values read the same forward and backward.

        //You can flip any number of cells in grid from 0 to 1, or from 1 to 0.

        //Return the minimum number of cells that need to be flipped to make all rows and columns palindromic, and the total number of 1's in grid divisible by 4.

        public void Run()
        {
            int[][] grid = new int[][]
            {
                new int[] {1,0,0},
                new int[] {0,1,0},
                new int[] {0,0,1}
            };
            int result = MinFlips(grid);

            int[][] grid2 = new int[][]
            {
                new int[] {1},
                new int[] {1}
            };

            int result2 = MinFlips(grid2);

            int[][] grid3 = new int[][]
            {
                new int[] {1,1,1,0}
            };

            int result3 = MinFlips(grid3);

            int[][] grid4 = new int[][]
            {
                new int[] {1,0,0},
                new int[] {0,0,1},
                new int[] {0,0,1}
            };

            int result4 = MinFlips(grid4);

            //[[0, 0, 0],[1, 1, 0],[0, 1, 1],[0, 0, 1]]
            int[][] grid5 = new int[][]
            {
                new int[] {0,0,0},
                new int[] {1,1,0},
                new int[] {0,1,1},
                new int[] {0,0,1}
            };

            int result5 = MinFlips(grid5);

            int[][] grid6 = new int[][]
            {
                new int[] {1, 0, 1, 0, 1, 1}
            };

            int result6 = MinFlips(grid6);
        }

        public int MinFlips(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int flips = 0;
            int ones = 0;

            if (m == 1 && n == 1 && grid[0][0] == 1)
                return 1;

            for (int i = 0; i < m / 2; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    // Four cells that must all be equal
                    int cell1 = grid[i][j];
                    int cell2 = grid[i][n - 1 - j];
                    int cell3 = grid[m - 1 - i][j];
                    int cell4 = grid[m - 1 - i][n - 1 - j];

                    int sum = cell1 + cell2 + cell3 + cell4;

                    // Minimum flips to make all 4 cells equal: min(sum, 4-sum)
                    flips += Math.Min(sum, 4 - sum);
                    ones += sum >= 2 ? 4 : 0;
                }
            }

            int pairOnes = 0;

            // Step 2: center row
            int mflips = 0;
            if (m % 2 == 1)
            {
                int i = m / 2;
                for (int j = 0; j < n / 2; j++)
                {
                    if (grid[i][j] == grid[i][n - 1 - j])
                    {
                        if (grid[i][j] == 1)
                        {
                            pairOnes += 2;
                        }
                    }
                    else
                    {
                        mflips++;
                    }
                }
            }
            flips += mflips;

            // Step 3: center column
            int nflips = 0;
            if (n % 2 == 1)
            {
                int j = n / 2;
                for (int i = 0; i < m / 2; i++)
                {
                    if (grid[i][j] == grid[m - 1 - i][j])
                    {
                        if (grid[i][j] == 1)
                        {
                            pairOnes += 2;
                        }
                    }
                    else
                    {
                        nflips++;
                    }
                }
            }

            flips += nflips;

            ones += pairOnes;

            // If not divisible by 4 and center exists, flip it
            //This is the center cell when both m and n are odd
            if (m % 2 == 1 && n % 2 == 1 && grid[m / 2][n / 2] == 1)
                flips++;

            if (ones % 4 != 0)
            {
                if (nflips > 0 || mflips > 0)
                {

                }
                else if (pairOnes > 0)
                {
                    flips += 2;
                }
            }

            return flips;
        }
    }
}
