using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIItemPlacer : MonoBehaviour {
	public GameObject itemUI;
	public GameObject item3D;
	public string itemName;

	public bool itemEnabled;
	public UIItemPlacer nextItemToEnable;
	public bool isLast;

	private Text instructions;

	// Start is called before the first frame update
	void Start() {
		GameObject instructionObject = GameObject.Find("Instructions");
		if (instructionObject) {
			instructions = instructionObject.GetComponent<Text>();
		}
	}

	// Update is called once per frame
	void Update() {

	}

	public void Clicked() {
		if (itemEnabled) {
			itemUI.SetActive(false);
			item3D.SetActive(true);

			if (!isLast) {
				nextItemToEnable.itemEnabled = true;

				if (instructions) {
					instructions.text = "Click the " + nextItemToEnable.itemName + " to place it on the table";
				}
			} else {
				instructions.text = "Nice work! You win!";
			}

			Destroy(this.gameObject);
		} else {
			instructions.text = "Wrong! Try again!";
		}
	}
}
