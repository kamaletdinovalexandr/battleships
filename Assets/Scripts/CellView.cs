using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellView : MonoBehaviour {

	[SerializeField] private Sprite _imageEmpty;
	[SerializeField] private Sprite _imageFilled;
	[SerializeField] private Sprite _imageDestroyed;
	[SerializeField] private Sprite _imageMissed;

	private SpriteRenderer _sr;

	private void Start() {
		_sr = GetComponent<SpriteRenderer>();
	}

	public void SetEmpty() {
		_sr.sprite = _imageEmpty;
	}

	public void SetFilled() {
		_sr.sprite = _imageFilled;
	}

	public void SetDestroyed() {
		_sr.sprite = _imageDestroyed;
	}

	public void SetMissed() {
		_sr.sprite = _imageMissed;
	}
	
}
