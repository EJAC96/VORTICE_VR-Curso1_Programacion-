using UnityEngine;

public class IrADefinicion : MonoBehaviour
{
	// Objetivo: Encontrar una variable o funcion rapidamente
	// Atajo: F12

	//--------------------------------------------------

	// Ejemplo 1/3:

	int coins;
	int coinsTotal;

	public void AddCoins ()
	{
		coins++;
		coinsTotal = coins;
	}

	public void RemoveCoins ()
	{
		coins--;
		coinsTotal = coins;
	}

	public void ResetCoins ()
	{
		coins = 0;
		coinsTotal = coins;
	}

	//--------------------------------------------------

	// Ejemplo 2/3:

	Test test_Damage;

	public void Damage (float _amount)
	{
		test_Damage.damage = _amount;
	}

	//--------------------------------------------------

	// Ejemplo 3/3:

	Test test_ChangeWeapon;
	int idWeapon;

	public void SelectWeapon ()
	{
		test_ChangeWeapon.ChangeWeapon(idWeapon);
	}

	//--------------------------------------------------

}