using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float speed;
    public delegate void Parallax(Vector3 parallax);
    public event Parallax OnMovement;

    
    // Update is called once per frame
    void Update()
   {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(horizontalInput, verticalInput, 0) * Time.deltaTime * speed;
    
        if (OnMovement != null ) OnMovement(new Vector3(horizontalInput, verticalInput, 0));
    

    }

    }
