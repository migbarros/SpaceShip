using UnityEngine;

public class spaw : MonoBehaviour
{
    public GameObject prefab;
    [Min(0.5f)]public float spawFrequency;
    private float _timer;
  
    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= spawFrequency)
        { 
         Instantiate(prefab, transform.position, transform.rotation);
            _timer = 0;
        
        }
    }
}
