using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    public float movingForce = 1.5f;
    public float maxMovingForce = 5f;
    public Rigidbody2D rb;
    public GameObject firePoint;

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.isPressed)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.value);
            Vector2 direction = mousePos - (Vector2)transform.position;
            transform.up = direction;
            rb.AddForce(direction.normalized * movingForce);
            if (rb.linearVelocity.magnitude > maxMovingForce)
            {
                rb.linearVelocity = rb.linearVelocity.normalized * maxMovingForce;
            }
            firePoint.SetActive(true);
        }
        if (Mouse.current.leftButton.isPressed == false)
        {
            firePoint.SetActive(false);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
