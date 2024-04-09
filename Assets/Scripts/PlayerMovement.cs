using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Range(0f, 10f)]
    [SerializeField] private float playerSpeed;

    private void Update()
    {
        float horizontalMovement = Input.GetAxis("Vertical") * playerSpeed;
        float verticalMovement = Input.GetAxis("Horizontal") * playerSpeed;

        horizontalMovement *= Time.deltaTime;
        verticalMovement *= Time.deltaTime;

        transform.Translate(0,0, horizontalMovement);
        transform.Translate(verticalMovement, 0, 0);

    }
    
}
