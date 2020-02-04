using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnObject : MonoBehaviour
{
    public Vector3 position;
    public Vector3 rotation;
    public Vector3 scale;

    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 jiggle = new Vector3(
            position.x += speed, 
            position.y + Random.value, 
            position.z + Random.value   );
        this.transform.position = jiggle;
        this.transform.localEulerAngles = rotation;
        this.transform.localScale = scale;
    }
}

