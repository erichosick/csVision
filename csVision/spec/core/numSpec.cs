using NUnit.Framework;
using System;

namespace csVision {
	[TestFixture ()] public class numSpec {
		[Test ()] public void num () {
			iMech msg = new num { val = 6 } ;

			Assert.AreEqual(6, (msg as num).val);
			Assert.AreEqual(msg, msg.go); // Note: C# and Javascript behavior different due to strong typing of C#
			Assert.AreEqual(6, msg.asNum );
			Assert.AreEqual("6", msg.asStr);

			iMech msg2 = new num { val = 8 } ;
			Assert.AreEqual(8, (msg2 as num).val);
			Assert.AreEqual(msg2, msg2.go);
			Assert.AreEqual(8, msg2.asNum );
			Assert.AreEqual("8", msg2.asStr);
		}

	}
}
