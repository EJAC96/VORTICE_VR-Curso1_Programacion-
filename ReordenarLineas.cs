using UnityEngine;

public class ReordenarLineas : MonoBehaviour
{
	// Objetivo: Reordenar lineas de codigo lo mas rapido posible
	// Atajo: Alt + Up/Down

	//--------------------------------------------------

	// Ejemplo 1/2:

	Transform spawn_02;
	Transform spawn_04;
	Transform spawn_05;
	Transform spawn_03;
	Transform spawn_01;

	//--------------------------------------------------

	// Ejemplo 2/2:

	Rigidbody rb;
	BoxCollider bc;
	Animator anim;

	private void Awake ()
	{

	}

	private void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		bc = GetComponent<BoxCollider> ();
		anim = GetComponent<Animator> ();
	}

	//--------------------------------------------------

}