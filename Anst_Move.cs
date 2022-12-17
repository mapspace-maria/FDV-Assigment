using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anst_Move : MonoBehaviour
{

    public float speed = 3f;

    // Update is called once per frame
    void Update()
    {

        var step =  speed * Time.deltaTime; 
        transform.Translate(Vector3.left * step);
    }
}
