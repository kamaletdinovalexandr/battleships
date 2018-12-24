using System.Collections;
using System.Collections.Generic;
using Enums;
using UnityEngine;

public class Ship {

	public int Size { get; private set; }
	public ShipDirection Direction { get; set; }
	public List<Vector2Int> FilledCells { get; set; }

	public Ship(int size) {
		Size = size;
		FilledCells = new List<Vector2Int>();	
	}

	public bool IsPlaced() {
		return FilledCells.Count > 0;
	}
}
