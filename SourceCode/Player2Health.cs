using UnityEngine;
using System.Collections;

public class Player2Health : MonoBehaviour {

	public int max_Health = 10;
	//public int max_Health = 100;
	public int cur_Health = 0;
	//public int cur_Health = 0;
	public GameObject healthBar;
	public GameObject playerObject;
	public int myvalue,calc_Health;
	// Use this for initialization
	void Start () {
	

		cur_Health = max_Health;
		//InvokeRepeating("decreasehealth",1f,1f);

	}
	
	// Update is called once per frame
	void Update () {


	
	}


	public void decreasehealth(int theValue)
	{

		//myvalue = theValue;
		//cur_Health -= 2f;
		//float calc_Health = cur_Health / max_Health;
		calc_Health = cur_Health - theValue;
		cur_Health = calc_Health;

		Debug.Log (cur_Health);
		//SetHealthBar (calc_Health);
		SetHealthBar (calc_Health);
		if (cur_Health <= 0) {

			DestroyObject (playerObject);

			//CancelInvoke ();
		}

	}

	public void SetHealthBar(int myHealth)
	{

		healthBar.transform.localScale = new Vector3 (myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
	}
}
