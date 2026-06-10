using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Adiciona a velocidade inicial
        GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnBecameInvisible()//Aciona quando o objeto com arte sai da câmera
    {
        Destroy(gameObject);
    }
    //Evento acionado quando este objeto bate em outro. Esse ou o outro
    //deve ser isTrigger
    private void OnTriggerEnter2D(Collider2D collision)//Esse collision é o objeto que bateu
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);//Esse destroi o inimigo
            Destroy(gameObject);//Esse destroi a própria bala
        }
        
    }
}
