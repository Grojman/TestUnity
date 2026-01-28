using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 0;

    Vector2 movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        transform.Translate(movement * Time.deltaTime * speed);
        
    }
}
