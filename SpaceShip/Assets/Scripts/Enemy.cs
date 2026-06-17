using UnityEngine;

public class Enemy : MonoBehaviour
{
   [Min(1)]public float speed;
    public int damage = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, -speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Evento de colisão quando os dois que colidem são sólidos
    //(isTrigger desativado)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Aqui colocaremos depois o dano causado ao player
            collision.gameObject.GetComponent<Player>().TakeDamege(damage);
            Destroy(gameObject);//Destroi o inimigo quando colide com o player
        }
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }


}

