using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class barscript : MonoBehaviour {

	public PlayerHealth referencePlayerHealth;

	public int theHealth;

	public Text valueText;
	// Use this for initialization
	void Start () {

		referencePlayerHealth.calc_Health = referencePlayerHealth.max_Health;
		//referencePlayerHealth.cur_Health = theHealth;
		theHealth = referencePlayerHealth.max_Health;
		//string[] tmp = valueText.text.Split (':');
		//valueText.text = tmp [0] + ": " + theHealth;

	}
	
	// Update is called once per frame
	void Update () {
	
		theHealth = referencePlayerHealth.calc_Health;

		string[] tmp = valueText.text.Split (':');
		valueText.text = tmp [0] + ": " + theHealth;

	}
}
