using UnityEngine;
using System.Collections;

public class gameControl : MonoBehaviour
{
	private bool[] checker = new bool[20];
	private int[] UnicNumArray = new int[20];
		
	private Vector3[] pos = new Vector3[20]{
		new Vector3 (-5.8f, 8.0f, 0.0f),
		new Vector3 (5.8f, 8.0f, 0.0f),
		new Vector3 (-2.0f, 4.0f, 0.0f),
		new Vector3 (5.8f, 4.0f, 0.0f),
		new Vector3 (-2.0f, 0.0f, 0.0f),
		new Vector3 (5.8f, 0.0f, 0.0f),
		new Vector3 (2.0f, 0.0f, 0.0f),
		new Vector3 (-5.8f, 0.0f, 0.0f),
		new Vector3 (5.8f, -4.0f, 0.0f),
		new Vector3 (5.8f, -8.0f, 0.0f),
		new Vector3 (-5.8f, -4.0f, 0.0f),
		new Vector3 (2.0f, -4.0f, 0.0f),
		new Vector3 (2.0f, 4.0f, 0.0f),
		new Vector3 (2.0f, 8.0f, 0.0f),
		new Vector3 (-5.8f, -8.0f, 0.0f),
		new Vector3 (2.0f, -8.0f, 0.0f),
		new Vector3 (-2.0f, 8.0f, 0.0f),
		new Vector3 (-2.0f, -4.0f, 0.0f),
		new Vector3 (-2.0f, -8.0f, 0.0f),
		new Vector3 (-5.8f, 4.0f, 0.0f)
	};
	
	
	// Use this for initialization
	void Start ()
	{
		InvokeRepeating("GenerateNumbers", 2.0f, 3.0f);
		InvokeRepeating("CallImage", 2.0f, 3.5f);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown (0))
		{
			Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 touchPos = new Vector2(wp.x, wp.y);
			
			if (collider2D == Physics2D.OverlapPoint(touchPos))
			{

			}
		}
		
	}
	
	void RemoveImage()
	{

		
	}

	void ResetChecker()
	{
		for(int i = 0; i < 20; i++)	
		checker[i] = false;
	}
		
	void GenerateNumbers()
	{			
		ResetChecker ();			
		for (int i = 0; i < 20; i++)
		{
			int rand ;
			while(true)
			{
				rand = Random.Range(0, 20);					
				if(!checker[rand])
				{
					checker[rand] = true;
					UnicNumArray[i] = rand;
					break;
				}						
			}					
		}
	}


	
	void CallImage()
	{
		int one1 = UnicNumArray [0],one2 = UnicNumArray [1], one3 = UnicNumArray [2],
		one4 = UnicNumArray [3], one5 = UnicNumArray [4], one6 = UnicNumArray [5],
		 one7 = UnicNumArray [6],one8 = UnicNumArray [7], one9 = UnicNumArray [8],
		 one10 = UnicNumArray [9], one11 = UnicNumArray [10],one12 = UnicNumArray [11],
		 one13 = UnicNumArray [12],one14 = UnicNumArray [13], one15 = UnicNumArray [14],
		 one16 = UnicNumArray [15], one17 = UnicNumArray [16], one18 = UnicNumArray [17],
		 one19 = UnicNumArray [18], one20 = UnicNumArray [19];


		GameObject.Find ("0").transform.position = pos[one20];
		GameObject.Find ("1").transform.position = pos[one1];
		GameObject.Find ("2").transform.position = pos[one2];
		GameObject.Find ("3").transform.position = pos[one3];
		GameObject.Find ("4").transform.position = pos[one4];
		GameObject.Find ("5").transform.position = pos[one5];
		GameObject.Find ("6").transform.position = pos[one6];
		GameObject.Find ("7").transform.position = pos[one7];
		GameObject.Find ("8").transform.position = pos[one8];
		GameObject.Find ("9").transform.position = pos[one9];
		GameObject.Find ("10").transform.position = pos[one10];
		GameObject.Find ("11").transform.position = pos[one11];
		GameObject.Find ("12").transform.position = pos[one12];
		GameObject.Find ("13").transform.position = pos[one13];
		GameObject.Find ("14").transform.position = pos[one14];
		GameObject.Find ("15").transform.position = pos[one15];
		GameObject.Find ("16").transform.position = pos[one16];
		GameObject.Find ("17").transform.position = pos[one17];
		GameObject.Find ("18").transform.position = pos[one18];
		GameObject.Find ("19").transform.position = pos[one19];
	}



}
