using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestRefeactoring
{
	[TestClass]
	public class TestChangeMoney
	{
		[TestMethod]
		public void ChangeTenBathCoin()
		{
			var changeMoney = new TestChangeMoney();
			Assert.AreEqual(4,changeMoney.Ge);
		}
	}
}
