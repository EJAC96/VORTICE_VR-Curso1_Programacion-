using UnityEngine;

public class ComentarCodigo : MonoBehaviour
{
	// Objetivo: Comentar lineas de codigo lo mas rapido posible
	// Atajo 1: Ctrl + /  
	// Atajo 2: Ctrl + Alt + /

	//--------------------------------------------------

	// Ejemplo 1/2:

	float speedTest;
	float speed;
	float speedNew;

	//--------------------------------------------------

	// Ejemplo 2/2:

	public void Reload (int _maxSpeed)
	{

		speedTest = 30;
		speedNew = 145;
		speed = 301;
		speedNew = 5;
		speedTest = 4776;
		speed = 9;

		speed = _maxSpeed;
	}

	//--------------------------------------------------

}