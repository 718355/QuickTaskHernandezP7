using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D;
using UnityEditorInternal;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float leftBoundary = -10f;
    private float speed = 5.0f;
    public float rightBoundary = 15f;
    public float topBoundary = 10f;
    public float bottomBoundary = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, verticalInput);
        transform.Translate(direction * speed * Time.deltaTime);

        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, leftBoundary, rightBoundary);
        position.y = Mathf.Clamp(position.y, bottomBoundary, topBoundary);
        transform.position = position;
    }
}
