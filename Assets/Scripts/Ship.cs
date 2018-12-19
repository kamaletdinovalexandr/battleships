using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship {

	public Vector2Int Size { get; private set; }
	public Vector2Int Direction { get; private set; }
	public ShipStatus ShipStatus { get; set; }
	public List<Vector2Int> FilledCells { get; set; }
}
