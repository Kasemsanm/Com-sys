using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NUnitTest
{
	[TestClass]
	public class NUnitTests
	{
		[TestMethod]
		public void SumOfTwoNumbers()
		{
			Assert.AreEqual(10, 5 + 5);
		}

		[TestMethod]
		public void TestIsFalse()
		{
			Assert.IsFalse(false);
		}
	}
}
