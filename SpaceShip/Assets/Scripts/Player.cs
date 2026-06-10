using UnityEngine;

public class Player : MonoBehaviour
{
    public float _speed = 5f;
    private Vector2 _movement;
    private Rigidbody2D _rb;
    public GameObject bullet;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();//Referenciar a física para não ser nula
    }
    // Update is called once per frame
    void Update()
    {//Input são os valores de entrada, ou seja, os botões
        //A próxima linha pega os botões do teclado e armazena em um vetor de 2 dimensões
        _movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        //Aplica na velocidade do RigidBody o vetor de botão multiplicando pela velocidade
        _rb.linearVelocity = _movement * _speed;

        if (Input.GetButtonDown("Fire1"))//Aciona o tiro
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }

    }
}
