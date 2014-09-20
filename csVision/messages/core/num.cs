namespace csVision {

	public class num : iMech {

		protected float p_val = 0.0f;
		public float val {
			get { return p_val; }
			set { p_val = value; }
		}

		public iMech go {
			get { return this; }
		}

		public float asNum {
			get { return p_val; }
		}

		public string asStr {
			get { return p_val.ToString(); }
		}
	}

}
