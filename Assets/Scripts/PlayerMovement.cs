using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Range(0f, 10f)]
    [SerializeField] private float playerSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * playerSpeed;
        float verticalMovement = Input.GetAxis("Vertical") * playerSpeed;

        horizontalMovement *= Time.deltaTime;
        verticalMovement *= Time.deltaTime;

        transform.Translate(0,0, horizontalMovement);
        transform.Translate(-verticalMovement, 0, 0);
    }
}
