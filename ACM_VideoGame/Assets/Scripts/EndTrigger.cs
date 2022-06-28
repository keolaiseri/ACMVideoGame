using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;
    public GameObject player;
    public ItemCollector itemCollector;
       


    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.CompleteLevel();
        player.SetActive(false);
        itemCollector.majorityCollectibles();
        //player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        
    }

}
    