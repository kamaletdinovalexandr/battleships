using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour {

	[SerializeField] private Sprite _imageEmpty;
	[SerializeField] private Sprite _imageFilled;
	[SerializeField] private Sprite _imageDestroyed;
	[SerializeField] private Sprite _imageSelected;

	private SpriteRenderer _sr;

	private void Start() {
		_sr = GetComponent<SpriteRenderer>();
	}

	public void ToggleSelection(bool selected) {
		_sr.sprite = selected ? _imageSelected : _imageEmpty;
	}
}
