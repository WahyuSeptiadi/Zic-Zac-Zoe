using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class tutupCard : MonoBehaviour
{
	// Text bukaKartu;
	public bool balik;
	public float waktu;
	public int ganti;

    // Start is called before the first frame update
	void Start()
	{
		// bukaKartu = GameObject.Find("textTutupKartu").GetComponent<Text>();

	}

    // Update is called once per frame
	void Update()
	{		
		if(Input.GetKey(KeyCode.Mouse0) && balik == false){			
			tutupKartu();
			balik = true;			
		}		
		else if(Input.GetKey(KeyCode.Mouse0) && balik == true){			
			bukaKartu();
			balik = false;
		}
	}

	public void tutupKartu(){
		int kecepatanX = 0, kecepatanY = 1, kecepatanZ = 0;
		for(int i = 0; i <= 90; i++){
			if(transform.eulerAngles.y == 90){

			}else{
				transform.Rotate(kecepatanX, kecepatanY, kecepatanZ);				
			}
			// waktu += Time.deltaTime;

		}
	}

	public void bukaKartu(){
		transform.localEulerAngles = new Vector3(0,0,0);
	}
}
