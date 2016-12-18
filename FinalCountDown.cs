using UnityEngine;
using System.Collections;

public class FinalCountDown : MonoBehaviour {

	public int Left = 0;
	public int Top = 0;
	float timeLeft;
	public int round;


	void Start () {
		
		timeLeft = 30;
		round = 1;
		
	}

	void OnGUI()
	{
		GUI.Label(new Rect(Left, Top, 500, 500), "Round " + round + "\n" + timeLeft);
	}


	
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
	
	
		timeLeft -= Time.deltaTime;
		if ( timeLeft < 0 )
		{
			Application.LoadLevel ("MainLevel");
		}
	



	}
}
/*

public float minutesLeft;
public float secondsLeft;
public GUI text_Time;

void Start () 
{
	StartCoroutine(DecreaseTimer());
}

void Update () 
{
	if (secondsLeft == -1 && minutesLeft >= 1f)    // We correct numbers
	{
		secondsLeft = 59f;
		minutesLeft -- ;
	}
	// In order to display the "0" before the number, we check if secondsLeft < 10
	if (secondsLeft < 10f)
	{
		text_Time.text = minutesLeft.ToString() + " : " + "0" + secondsLeft.ToString();
	}
	// Otherwise we simply display it
	else text_Time.text = minutesLeft.ToString() + " : " + secondsLeft.ToString();
	
	if (secondsLeft <= 0f && minutesLeft <= 0f)
	{
		text_Time.text = "OVER !";
	}
}

IEnumerator DecreaseTimer()
{
	while (true)
	{
		yield return new WaitForSeconds(1f);
		secondsLeft--;
	}
}
}
*/
