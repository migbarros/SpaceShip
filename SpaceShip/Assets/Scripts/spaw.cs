using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class spaw : MonoBehaviour
{
    public GameObject prefab;
    [Min(0.5f)]public float spawFrequency;
    private float _timer;
    public Transform left;
    public Transform right;

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= spawFrequency)
        { 
         GameObject enemy = Instantiate(prefab, transform);
            float newX = Random.Range(left.position.x, right.position.x);
            enemy.transform.position = new Vector2 (newX, transform.position.y);
            _timer = 0;
        
        }
     }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
