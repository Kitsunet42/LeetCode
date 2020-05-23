public class Solution
{
    public int MaxAreaOfIsland(int[][] grid)
    {
        bool[][] visited = new bool[grid.Length][];
        for (int i = 0; i < grid.Length; i++)
        {
            visited[i] = new bool[grid[i].Length];
        }

        var res = 0;
        var count = 0;
        var que1 = new Queue<int>();
        var que2 = new Queue<int>();
        for (int i = 0; i < grid.Length; i++)
        {
            for (int k = 0; k < grid[i].Length; k++)
            {
                if (!visited[i][k] && grid[i][k] == 1)
                {
                    count++;
                    visited[i][k] = true;
                    if (i - 1 >= 0 && grid[i - 1][k] == 1 && !visited[i - 1][k])
                    {
                        que1.Enqueue(i - 1);
                        que2.Enqueue(k);
                    }

                    if (i + 1 < grid.Length && grid[i + 1][k] == 1 && !visited[i + 1][k])
                    {
                        que1.Enqueue(i + 1);
                        que2.Enqueue(k);
                    }

                    if (k - 1 >= 0 && grid[i][k - 1] == 1 && !visited[i][k - 1])
                    {
                        que1.Enqueue(i);
                        que2.Enqueue(k - 1);
                    }

                    if (k + 1 < grid[i].Length && grid[i][k + 1] == 1 && !visited[i][k + 1])
                    {
                        que1.Enqueue(i);
                        que2.Enqueue(k + 1);
                    }

                    while (que1.Count > 0)
                    {
                        var x = que1.Dequeue();
                        var y = que2.Dequeue();
                        if (!visited[x][y] && grid[x][y] == 1)
                        {
                            count++;
                            visited[x][y] = true;
                            if (x - 1 >= 0 && grid[x - 1][y] == 1 && !visited[x - 1][y])
                            {
                                que1.Enqueue(x - 1);
                                que2.Enqueue(y);
                            }

                            if (x + 1 < grid.Length && grid[x + 1][y] == 1 && !visited[x + 1][y])
                            {
                                que1.Enqueue(x + 1);
                                que2.Enqueue(y);
                            }

                            if (y - 1 >= 0 && grid[x][y - 1] == 1 && !visited[x][y - 1])
                            {
                                que1.Enqueue(x);
                                que2.Enqueue(y - 1);
                            }

                            if (y + 1 < grid[i].Length && grid[x][y + 1] == 1 && !visited[x][y + 1])
                            {
                                que1.Enqueue(x);
                                que2.Enqueue(y + 1);
                            }
                        }
                    }
                    res = Math.Max(res, count);
                    count = 0;
                }
            }
        }

        return res;
    }
}