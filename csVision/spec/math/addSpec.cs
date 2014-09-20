using NUnit.Framework;
using System;

namespace csVision {
	[TestFixture ()] public class addSpec {
		[Test ()] public void add () {
			iMech mech = new add {
				left = new num { val = 4 },
				right = new num { val = 8 }
			};

			Assert.AreEqual(4, (mech as add).left.asNum);
			Assert.AreEqual(8, (mech as add).right.asNum);
			Assert.AreEqual(12, ((mech.go) as num).val ); // Note: C# and Javascript behavior different due to strong typing of C#
			Assert.AreEqual(12, mech.asNum );
			Assert.AreEqual("(4 + 8)", mech.asStr);

			iMech mech2 = new add {
				left = new num {val = 3},
				right = new num {val = -1}
			};
			Assert.AreEqual(3, (mech2 as add).left.asNum);
			Assert.AreEqual(-1, (mech2 as add).right.asNum);
			Assert.AreEqual(2, ((mech2.go) as num).val ); // Note: C# and Javascript behavior different due to strong typing of C#
			Assert.AreEqual(2, mech2.asNum );
			Assert.AreEqual("(3 + -1)", mech2.asStr);

			iMech mech3 = new add {
				left = new add {
					left = new num {val = 3},
					right = new num {val = -1},
				},
				right = new num {val = -1},
			};
			Assert.AreEqual(2, (mech3 as add).left.asNum);
			Assert.AreEqual(-1, (mech3 as add).right.asNum);
			Assert.AreEqual(1, ((mech3.go) as num).val ); // Note: C# and Javascript behavior different due to strong typing of C#
			Assert.AreEqual(1, mech3.asNum );
			Assert.AreEqual("((3 + -1) + -1)", mech3.asStr);

		}

	}
}
