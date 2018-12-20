using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomProvider {
	
	public static Vector2Int GetRandomPosition(int max) {
		return new Vector2Int(Random.Range(0, max), Random.Range(0, max));
	}

	public static Direction GetRandomDirection() {
		return (Direction)Random.Range(0, Enum.GetValues(typeof(Direction)).Length);
	}
}

