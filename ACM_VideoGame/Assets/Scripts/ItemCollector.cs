using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{

    private int controllers = 0;

    [SerializeField] private Text controllersText;

    [SerializeField] private AudioSource collectionSoundEffect;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Controller"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            controllers++;
            controllersText.text = "Controllers: " + controllers;
        }
    }

}
