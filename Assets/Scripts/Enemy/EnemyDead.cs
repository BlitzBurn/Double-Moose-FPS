using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDead : MonoBehaviour
{

    public GameObject AmmoPack;
    public GameObject slainEnemy;

    public void DropAmmoPack()
    {
       GameObject instantiatedAmmoBox =  Instantiate(AmmoPack, slainEnemy.transform.position, AmmoPack.transform.rotation);
    }
}
