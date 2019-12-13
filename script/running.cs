using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class running : MonoBehaviour
{
	public bool aktif;
	public float waktu;
	public string pesan;

    // Start is called before the first frame update
	void Start()
	{

	}

    // Update is called once per frame
	void Update()
	{
		waktu += Time.deltaTime;

		if(waktu > 3){
			aktif = true;
		}

		if(aktif == true){
			print(pesan);
		}
		// for(waktu = 0; waktu <= 90; ){
			// 	tutupKartuHitam();
			// 	waktu += Time.deltaTime;
			// }
			// int kecepatanX = 0, kecepatanY = 1, kecepatanZ = 0;
			// if(transform.eulerAngles.y == 180){

			// }else{
			// 	transform.Rotate(kecepatanX, kecepatanY, kecepatanZ);
			// }

	// void balikKartu(){
	// 	balik = !balik;
	// 	Vektor1 kartu = transform.localRotation;
	// 	kartu.y *= -1;
	// 	transform.localRotation = kartu;
	// }
		// transform.eulerAngles.x = 0;
	}
}
