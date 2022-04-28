using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;

    public float speed = 70f;

    public void Seek(Transform _target)
    {
        target = _target;

    }
    void Start()
    {
        
    }


    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;

        }

        // KUR?UNUN YÖNÜ VE HAREKET?
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

    }
}
