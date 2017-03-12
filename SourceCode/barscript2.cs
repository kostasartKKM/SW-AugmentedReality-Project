using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class barscript2 : MonoBehaviour {

	public Player2Health referencePlayer2Health;

	public int theHealth2;

	public Text valueText;
	// Use this for initialization
	void Start () {

		referencePlayer2Health.calc_Health = referencePlayer2Health.max_Health;
		//referencePlayerHealth.cur_Health = theHealth;
		theHealth2 = referencePlayer2Health.max_Health;
		//string[] tmp = valueText.text.Split (':');
		//valueText.text = tmp [0] + ": " + theHealth;

	}
	
	// Update is called once per frame
	void Update () {
	
		theHealth2 = referencePlayer2Health.calc_Health;

		string[] tmp = valueText.text.Split (':');
		valueText.text = tmp [0] + ": " + theHealth2;

	}
}
