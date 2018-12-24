using System;
using UnityEngine;
using Enums;
using Random = UnityEngine.Random;

public static class RandomProvider {
	
	public static Vector2Int GetRandomPosition(int max) {
		return new Vector2Int(Random.Range(0, max), Random.Range(0, max));
	}

	public static ShipDirection GetRandomDirection() {
		return (ShipDirection)Random.Range(0, Enum.GetValues(typeof(ShipDirection)).Length);
	}
}

