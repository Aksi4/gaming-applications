using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  

public class Player : MonoBehaviour
{
    public Text winText;
    public Image winImage;  
    public int itemsToCollect = 5;
    public int itemsToDead = 1;
    public int itemsDead = 0;
    private int itemsCollected = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ItemDead"))
        {
            itemsDead++;
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Item"))
        {
            itemsCollected++;
            Destroy(other.gameObject);
        }

        if (itemsDead >= itemsToDead)
        {
            Debug.Log("DEAD!!!");
            winText.text = "DEAD!!!";
            winImage.color = new Color(winImage.color.r, winImage.color.g, winImage.color.b, 1);
        }

        if (other.gameObject.CompareTag("Exit") && itemsCollected >= itemsToCollect)
        {
            Debug.Log("WIN!!!");
            winText.text = "WIN!!!";
            winImage.color = new Color(winImage.color.r, winImage.color.g, winImage.color.b, 1);
        }
    }
}
