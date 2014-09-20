using NUnit.Framework;
using System;

namespace csVision {
	[TestFixture ()] public class writeToConSpec {
		[Test ()] public void writeToCon () {
			iMech mech = new writeToCon {
				text = new add {
				  left = new num { val = 4 },
				  right = new num { val = 8 }
				},
			};

			Assert.AreEqual(12, ((mech.go) as num).val ); // Note: C# and Javascript behavior different due to strong typing of C#
			Assert.AreEqual(12, mech.asNum );
			Assert.AreEqual("(4 + 8)", mech.asStr);

		}

	}
}