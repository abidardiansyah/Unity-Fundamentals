using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
	public Vector3 kekanan;
	public Vector3 kekiri;
	public Vector3 keatas;
	public Vector3 kebawah;
	public Vector3 maju;
	public Vector3 mundur;
	public float speed=3,speedrotasi=3;
    // Start is called before the first frame update
    void Start()
    {
        kekanan = new Vector3(1,0,0);
	kekiri = new Vector3(-1,0,0);
	keatas = new Vector3(0,1,0);
	kebawah = new Vector3(0,-1,0);
	maju = new Vector3(0,0,1); 
	mundur = new Vector3(0,0,-1); 
    }

    // Update is called once per frame
    void Update()
    {
	if(Input.GetKey("right"))
			transform.position = transform.position + (kekanan * speed * Time.deltaTime);
	else if(Input.GetKey("left"))
			transform.position = transform.position + (kekiri * speed * Time.deltaTime);
	else if(Input.GetKey("up"))
			transform.position = transform.position + (keatas * speed * Time.deltaTime);
	else if(Input.GetKey("down"))
			transform.position = transform.position + (kebawah * speed * Time.deltaTime);
	else if(Input.GetKey(KeyCode.A))
			transform.rotation = transform.rotation*Quaternion.Euler(mundur*speedrotasi*Time.deltaTime);
	else if(Input.GetKey(KeyCode.D))
			transform.rotation = transform.rotation*Quaternion.Euler(maju*speedrotasi*Time.deltaTime);
	else if(Input.GetKey(KeyCode.W))
			transform.position = transform.position + (maju * speed * Time.deltaTime);
	else if(Input.GetKey(KeyCode.S))
			transform.position = transform.position + (mundur * speed * Time.deltaTime);
	if(Input.GetMouseButton(0)){
		if(Input.GetKey(KeyCode.J))
			transform.rotation = transform.rotation*Quaternion.Euler(mundur*speedrotasi*Time.deltaTime);
		if(Input.GetKey(KeyCode.G))
			transform.rotation = transform.rotation*Quaternion.Euler(maju*speedrotasi*Time.deltaTime);
		if(Input.GetKey(KeyCode.Y))
			transform.rotation = transform.rotation*Quaternion.Euler(kekanan*speedrotasi*Time.deltaTime);
		if(Input.GetKey(KeyCode.H))
			transform.rotation = transform.rotation*Quaternion.Euler(kekiri*speedrotasi*Time.deltaTime);
		if(Input.GetKey(KeyCode.T))
			transform.rotation = transform.rotation*Quaternion.Euler(keatas*speedrotasi*Time.deltaTime);
		if(Input.GetKey(KeyCode.U))
			transform.rotation = transform.rotation*Quaternion.Euler(kebawah*speedrotasi*Time.deltaTime);
		}
	else{

	}
    }

}
