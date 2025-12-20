using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Algos.Algorithms
{
    public class NumberOfIslands
    {
        public void Run()
        {
            char[][] grid = new char[][]
            {
                new char[] {'1','1','0','0','0'},
                new char[] {'1','1','0','0','0'},
                new char[] {'0','0','1','0','0'},
                new char[] {'0','0','0','1','1'}
            };
            int result = NumIslands(grid);
            
        }

        public int NumIslands(char[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int count = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        count++;
                        Dfs(grid, i, j);
                    }
                }
            }
            return count;
        }

        private void Dfs(char[][] grid, int i, int j)
        {
            if (i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length || grid[i][j] == '0')
                return;

            grid[i][j] = '0'; // mark visited

            Dfs(grid, i + 1, j);
            Dfs(grid, i - 1, j);
            Dfs(grid, i, j + 1);
            Dfs(grid, i, j - 1);
        }
    }
}
