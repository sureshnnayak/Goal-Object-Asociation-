using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KateScript : MonoBehaviour
{
    Vector3 target;
    float speed = 1.1f;
    // Start is called before the first frame update
    void Start()
    {

        SetNeewTarget(new Vector3(
            transform.position.x + 10,
            transform.position.y,
            transform.position.z + 10
            )
        
        );

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
    }
    void SetNeewTarget(Vector3 newTarget)
    {
        target = newTarget;
        transform.LookAt(target);
    }
}

