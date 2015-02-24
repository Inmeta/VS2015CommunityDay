using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp.Tests
{
	[TestFixture]
	public class _1_AutoPropertiesTest
	{
		[Test]
		public void CheckNewClass()
		{
			var nc = new NewClass(42);
			var s = nc.Information;
			Assert.That(s.Contains("SomeDate"),Is.Not.True);
			Assert.That(s.Contains("5"),Is.True);
			

		}
	}
}
