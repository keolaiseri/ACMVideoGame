using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{

    private int controllers = 0;
    private int pencils = 0;
    private int cameras = 0;
    private int keyboards = 0;

    private int collectibles = 0;

    [SerializeField] private Text collectiblesText;
    [SerializeField] private Text camerasText;
    [SerializeField] private Text pencilsText;
    [SerializeField] private Text controllersText;
    [SerializeField] private Text keyboardsText;

    [SerializeField] private AudioSource collectionSoundEffect;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Controller"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            controllers++;
            collectibles++;
            collectiblesText.text = "Collectibles: " + collectibles;
            controllersText.text = "Controllers: " + controllers;
        }

        if(collision.gameObject.CompareTag("Pencil"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            pencils++;
            collectibles++;
            collectiblesText.text = "Collectibles: " + collectibles;
            pencilsText.text = "Pencils: " + pencils;


        }

        if (collision.gameObject.CompareTag("Camera"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            cameras++;
            collectibles++;
            collectiblesText.text = "Collectibles: " + collectibles;
            camerasText.text = "Cameras: " + cameras;


        }

        if (collision.gameObject.CompareTag("Keyboard"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            keyboards++;
            collectibles++;
            collectiblesText.text = "Collectibles: " + collectibles;
            keyboardsText.text = "Keyboards: " + keyboards;


        }
    }

}
