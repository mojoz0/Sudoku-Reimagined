/* Ben Scott * bescott@andrew.cmu.edu * 2016-02-09 * Sudoku */

using UnityEngine;
using System.Collections.Generic;

public static class EnumUtil {
	public static IEnumerable<T> GetValues<T>() {
		return System.Enum.GetValues(typeof(T)) as IEnumerable<T>;
	}
}

public enum Tiles : int {
	Default=0,
	Raise=1,
	Lower=2,
	Spout=3
}
