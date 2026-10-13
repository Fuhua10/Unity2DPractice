using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollector : MonoBehaviour
{
    private int coinCounts = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            if(collision.tag == "Coin")
            {
                coinCounts++;
                //collision.gameObject.SetActive(false);
                Destroy(collision.gameObject);
                Debug.Log($"当前金币数量：{coinCounts}");
            }
        }
    }
}
