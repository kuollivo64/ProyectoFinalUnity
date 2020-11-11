using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pies : MonoBehaviour
{

    public static bool estaPisando;
    public GameObject gameOver;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        estaPisando = true;
        if (collision.CompareTag("Hoyo"))
        {
            Time.timeScale = 0;
            gameOver.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        estaPisando = false;
    }

}
