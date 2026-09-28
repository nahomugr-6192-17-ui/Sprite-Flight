using UnityEngine;

public class rockMovement : MonoBehaviour
{
    public float rockSpeed = 2f;
    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.linearVelocity = Random.onUnitSphere * rockSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
