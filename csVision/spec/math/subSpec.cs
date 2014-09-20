using NUnit.Framework;
using System;

namespace csVision {
	[TestFixture ()] public class subSpec {
		[Test ()] public void sub () {
			iMech mech = new sub {
				left = new num { val = 4 },
				right = new num { val = 8 }
			};

			Assert.AreEqual(4, (mech as sub).left.asNum);
			Assert.AreEqual(8, (mech as sub).right.asNum);
			Assert.AreEqual(-4, ((mech.go) as num).val ); // Note: C# and Javascript behavior different due to strong typing of C#
			Assert.AreEqual(-4, mech.asNum );
			Assert.AreEqual("(4 - 8)", mech.asStr);

			iMech mech2 = new sub {
				left = new num {val = 3},
				right = new num {val = -1}
			};
			Assert.AreEqual(3, (mech2 as sub).left.asNum);
			Assert.AreEqual(-1, (mech2 as sub).right.asNum);
			Assert.AreEqual(4, ((mech2.go) as num).val ); // Note: C# and Javascript behavior different due to strong typing of C#
			Assert.AreEqual(4, mech2.asNum );
			Assert.AreEqual("(3 - -1)", mech2.asStr);

			iMech mech3 = new sub {
				left = new sub {
					left = new num {val = 3},
					right = new num {val = -1},
				},
				right = new num {val = -1},
			};
			Assert.AreEqual(4, (mech3 as sub).left.asNum);
			Assert.AreEqual(-1, (mech3 as sub).right.asNum);
			Assert.AreEqual(5, ((mech3.go) as num).val ); // Note: C# and Javascript behavior different due to strong typing of C#
			Assert.AreEqual(5, mech3.asNum );
			Assert.AreEqual("((3 - -1) - -1)", mech3.asStr);

		}

	}
}
