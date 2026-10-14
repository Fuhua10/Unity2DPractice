using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    [SerializeField] GameObject coinPerfab;

    

    private void OnFire()
    {
        GameObject bullet = Instantiate(coinPerfab,transform.position,transform.rotation);
    }
}
