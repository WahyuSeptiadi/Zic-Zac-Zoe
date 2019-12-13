using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class tutupBlackCard : MonoBehaviour
{
	Text tutupKartu;
	public bool balik;
	public float waktu;

    // Start is called before the first frame update
	void Start()
	{
		tutupKartu = GameObject.Find("textTutupKartu").GetComponent<Text>();

	}

    // Update is called once per frame
	void Update()
	{
		if(Input.GetKey(KeyCode.Mouse0) && balik == false){			
			tutupKartuHitam();
			tutupKartu.text = "Flip Kartu";			
		}		
		else if(Input.GetKey(KeyCode.Mouse0) && balik == true){
			tutupKartu.text = "Tutup Kartu";
		}
	}

	public void tutupKartuHitam(){
		int kecepatanX = 0, kecepatanY = 1, kecepatanZ = 0;
		for(int i = 0; i <= 180; i++){
			if(transform.eulerAngles.y == 180){

			}else{
				transform.Rotate(kecepatanX, kecepatanY, kecepatanZ);
			}
			// waktu += Time.deltaTime;
		}
	}

	// public void bukaKartuHitam(){		
	// 	int kecepatanX = 0, kecepatanY = 1, kecepatanZ = 0;
	// 	for(waktu = 0; waktu <= 90; ){
	// 		if(transform.eulerAngles.y == 180){

	// 		}else{
	// 			transform.Rotate(kecepatanX, kecepatanY, kecepatanZ);
	// 		}
	// 		waktu += Time.deltaTime;
	// 	}
	// }
}
