using NUnit.Framework;
using System;

namespace csVision {
	[TestFixture ()] public class divSpec {
		[Test ()] public void div () {
			iMech mech = new div {
				left = new num { val = 8 },
				right = new num { val = 2 }
			};

			Assert.AreEqual(8, (mech as div).left.asNum);
			Assert.AreEqual(2, (mech as div).right.asNum);
			Assert.AreEqual(4, ((mech.go) as num).val ); // Note: C# and Javascript behavior different due to strong typing of C#
			Assert.AreEqual(4, mech.asNum );
			Assert.AreEqual("(8 / 2)", mech.asStr);

			iMech mech2 = new div {
				left = new num {val = 6},
				right = new num {val = -2}
			};
			Assert.AreEqual(6, (mech2 as div).left.asNum);
			Assert.AreEqual(-2, (mech2 as div).right.asNum);
			Assert.AreEqual(-3, ((mech2.go) as num).val ); // Note: C# and Javascript behavior different due to strong typing of C#
			Assert.AreEqual(-3, mech2.asNum );
			Assert.AreEqual("(6 / -2)", mech2.asStr);

			iMech mech3 = new div {
				left = new num {val = 6},
				right = new num {val = 0}
			};
			Assert.AreEqual(6, (mech3 as div).left.asNum);
			Assert.AreEqual(0, (mech3 as div).right.asNum);
			Assert.AreEqual(float.PositiveInfinity, ((mech3.go) as num).val ); // Note: C# and Javascript behavior different due to strong typing of C#
			Assert.AreEqual(float.PositiveInfinity, mech3.asNum );
			Assert.AreEqual("(6 / 0)", mech3.asStr);

		}

	}
}
