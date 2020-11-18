using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed = 2f;
    public float JumpForce = 3f;
    private Rigidbody2D _rigidbody2D;
    private Animator anim;
    private bool grounded;
    private bool walking;
    private bool attack;
    public GameObject panelGameOver;
    

    void Start()
    {
        Time.timeScale = 1;
        _rigidbody2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Movimiento();
        anim.SetBool("Walking", walking);
        anim.SetBool("Grounded", grounded);
    }

    private void Movimiento()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        if (Horizontal != 0)
        {
            walking = true;
            transform.Translate(Horizontal * Speed * Time.deltaTime, 0, 0);
            if (Horizontal < 0)
            {
                transform.localScale = new Vector3(-0.42586f, 0.42586f, 0.42586f);
            }
            else if(Horizontal > 0)
            {
                transform.localScale = new Vector3(0.42586f, 0.42586f, 0.42586f);
            }
        }
        else
        {
            walking = false;
        }

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody2D.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            walking = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Fuego"))
        {
            panelGameOver.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Piso") grounded = true;
        if (collision.gameObject.tag == "PisoMiel") grounded = true;

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Piso") grounded = false;
        if (collision.gameObject.tag == "PisoMiel") grounded = false;
    }                                                                                   

    private void OnBecameInvisible()
    {
        transform.position= new Vector3(-23.011f, 9.73f, 0f);
    }

}
