using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed;
    public float JumpForce;
    private Rigidbody2D _rigidbody2D;
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }

    private void Movimiento()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        transform.Translate(Horizontal * Speed * Time.deltaTime, 0, 0);
        transform.Translate(-Vertical * Speed * Time.deltaTime, 0, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody2D.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
        }
    }

}
