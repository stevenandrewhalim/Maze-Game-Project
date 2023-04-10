using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IMoveable, IControllable
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField] private Vector3 direction;
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb2d;

    // Update is called once per frame
    void Update()
    {
        PositionUpdate();
        movement();    
    }

    public void movement()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
        //transform.position = new Vector2 (direction.x * speed, direction.y * speed);
    }

    public void PositionUpdate()
    {
        //transform.position += direction * Time.deltaTime * speed;
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(direction.x * speed, direction.y * speed);
    }
}
