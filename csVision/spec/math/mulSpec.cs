using NUnit.Framework;
using System;

namespace csVision {
	[TestFixture ()] public class mulSpec {
		[Test ()] public void mul () {
			iMech mech = new mul {
				left = new num { val = 2 },
				right = new num { val = 7 }
			};

			Assert.AreEqual(2, (mech as mul).left.asNum);
			Assert.AreEqual(7, (mech as mul).right.asNum);
			Assert.AreEqual(14, ((mech.go) as num).val ); // Note: C# and Javascript behavior different due to strong typing of C#
			Assert.AreEqual(14, mech.asNum );
			Assert.AreEqual("(2 * 7)", mech.asStr);

			iMech mech2 = new mul {
				left = new num {val = 4},
				right = new num {val = -2}
			};
			Assert.AreEqual(4, (mech2 as mul).left.asNum);
			Assert.AreEqual(-2, (mech2 as mul).right.asNum);
			Assert.AreEqual(-8, ((mech2.go) as num).val ); // Note: C# and Javascript behavior different due to strong typing of C#
			Assert.AreEqual(-8, mech2.asNum );
			Assert.AreEqual("(4 * -2)", mech2.asStr);


		}

	}
}
