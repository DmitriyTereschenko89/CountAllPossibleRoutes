using NUnit.Framework;

namespace CountAllPossibleRoutes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			CountAllPossibleRoutes countAllPossibleRoutes = new();
			Assert.AreEqual(4, countAllPossibleRoutes.CountRoutes(new int[] { 2, 3, 6, 8, 4 }, 1, 3, 5));
			Assert.AreEqual(5, countAllPossibleRoutes.CountRoutes(new int[] { 4, 3, 1 }, 1, 0, 6));
			Assert.AreEqual(0, countAllPossibleRoutes.CountRoutes(new int[] { 5, 2, 1 }, 0, 2, 3));
		}
	}
}