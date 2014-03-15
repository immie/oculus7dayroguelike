using System;


namespace MyNameSpace
{
	public class SpawnRoom : Room
	{
		public SpawnRoom (Random r_in) : base (3, 3, 10, 1, r_in) {
			this.level = 0;
		}

		protected override void build() {

			listOfRectangles.Add (new Rect (0, 0, 2, 2));

		}
	}
}

