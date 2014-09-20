namespace csVision {

	public class writeToCon : iMech {

		protected iMech p_text = null;
		public iMech text {
			get { return p_text; }
			set { p_text = value; }
		}

		public iMech go {
			get {
				iMech res = text.go;
				System.Console.WriteLine (res.asStr);
				return res;
			}
		}

		public float asNum {
			get {
				float res = text.go.asNum;
				System.Console.WriteLine (res.ToString());
				return res;
			}
		}

		public string asStr {
			get {
				string res = text.asStr;
				System.Console.WriteLine (res);
				return res;
			}
		}
	}

}
