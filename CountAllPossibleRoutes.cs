namespace CountAllPossibleRoutes
{
	internal class CountAllPossibleRoutes
	{
		private const int modulo = 1000000007;

		private int DFS(int[] locations, int[][] dp, int location, int finish, int fuel)
		{
			if (fuel < 0)
			{
				return 0;
			}
			if (dp[location][fuel] != -1)
			{
				return dp[location][fuel];
			}
			int routeCount = location == finish ? 1 : 0;
			for (int nextCity = 0; nextCity < locations.Length; ++nextCity)
			{
				if (nextCity != location)
				{
					routeCount = (routeCount + DFS(locations, dp, nextCity, finish, fuel - Math.Abs(locations[location] - locations[nextCity]))) % modulo;
				}
			}
			dp[location][fuel] = routeCount;
			return routeCount;
		}
		public int CountRoutes(int[] locations, int start, int finish, int fuel)
		{
			int n = locations.Length;
			int[][] dp = new int[n][];
			for (int i = 0; i < n; ++i)
			{
				dp[i] = new int[fuel + 1];
				Array.Fill(dp[i], -1);
			}
			return DFS(locations, dp, start, finish, fuel);
		}
	}
}
