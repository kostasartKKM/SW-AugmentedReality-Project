using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ReduceHealth2 : MonoBehaviour {


	public GameObject panel2;
	public InputField myInput2;
	public int value2;

	public Player2Health other2;
	// Use this for initialization
	void Start () {
	
	}


	public void TogglePanel2 ( bool newBool)
	{
		panel2.SetActive (newBool);


	}

	public void onOK_gettingTheValue(string newText)
	{

		//value1 = int.Parse(newText);
		value2 = int.Parse(newText);
		Debug.Log (value2);
	}

	public void onPushButton2()
	{
		other2.decreasehealth (value2);
		Debug.Log (value2);

	}

}
