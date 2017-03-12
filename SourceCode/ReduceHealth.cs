using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ReduceHealth : MonoBehaviour {

	public GameObject panel1;
	public GameObject panel2;
	public InputField myInput1;
	public int value1;

	public PlayerHealth other;
	// Use this for initialization
	void Start () {

	
	}

	public void TogglePanel1 ( bool newBool)
	{
		panel1.SetActive (newBool);


	}



	public void onOK_gettingTheValue(string newText)
	{

		//value1 = int.Parse(newText);
		value1 = int.Parse(newText);
		Debug.Log (value1);
	}

	public void onPushButton1()
	{
		other.decreasehealth (value1);
		Debug.Log (value1);

	}

}
