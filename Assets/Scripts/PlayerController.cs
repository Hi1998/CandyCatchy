using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isMove = true;

    [SerializeField]
    float MoveSpeed;

    [SerializeField]
    float MaxPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isMove)
        {
            Move();
        }
    }

    void Move()
    {
        float xInput = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * xInput * MoveSpeed * Time.deltaTime;

        // Restrict the Player Movement within the Boundaries.
        float xPos = Mathf.Clamp(transform.position.x, -MaxPos, MaxPos);
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z); 
    }
}
