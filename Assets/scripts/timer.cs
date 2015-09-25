using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour 
{

	float seconds = 0;
	float miliseconds = 0;	
	void Update()
	{		
		if(miliseconds >= 10)
		{			
			miliseconds = 0;
		}
		seconds += Time.deltaTime;
		miliseconds += Time.deltaTime * 10;
		guiText.text = "TOTAL :"+string.Format("{0}:{1}",  (int)seconds, (int)miliseconds);
	}
} 
