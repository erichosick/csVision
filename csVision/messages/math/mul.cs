namespace csVision {

	public class mul : iMech {

		protected iMech p_left = null;
		public iMech left {
			get { return p_left; }
			set { p_left = value; }
		}

		protected iMech p_right = null;
		public iMech right {
			get { return p_right; }
			set { p_right = value; }
		}

		public iMech go {
			get { return new num { val = asNum }; }
		}

		public float asNum {
			get { return p_left.go.asNum * p_right.go.asNum; }
		}

		public string asStr {
			get { return string.Format ("({0} * {1})", p_left.asStr, p_right.asStr); }
		}
	}

}
