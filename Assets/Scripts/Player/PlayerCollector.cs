using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollector : MonoBehaviour
{
    private int coinCounts = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            if(collision.CompareTag("Coin"))
            {
                coinCounts++;
                //collision.gameObject.SetActive(false);
                Destroy(collision.gameObject);
                Debug.Log($"当前金币数量：{coinCounts}");
            }
        }
    }
}
