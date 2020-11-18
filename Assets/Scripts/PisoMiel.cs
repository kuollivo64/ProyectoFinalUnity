using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PisoMiel : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Patrullaje")]
    public float Speed;
    public bool chocaOno;
    // Update is called once per frame
    void Update()
    {
        if (chocaOno)
        {
            transform.Translate(0,1 * Time.deltaTime * Speed,0);
        }
        else
        {
            transform.Translate(0, -1 * Time.deltaTime * Speed, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("cho"))
        {
            if (chocaOno)
            {
                chocaOno = false;
            }
            else
            {
                chocaOno = true;
            }
        }
    }
}
