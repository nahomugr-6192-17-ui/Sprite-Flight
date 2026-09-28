using UnityEngine;

public class rockMovement : MonoBehaviour
{
    public float rockForceMin = 50f;
    public float rockForceMax = 150f;
    public float rockMinSize = 0.6f;
    public float rockMaxSize = 2f;
    public float rockTorque = 10f;
    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float rockSize = Random.Range(rockMinSize, rockMaxSize);
        rb.transform.localScale = new Vector3 (rockSize, rockSize, 1f);
        float rockForce = Random.Range(rockForceMin, rockForceMax) / rockSize;
        rb.AddForce(Random.insideUnitCircle * rockForce, ForceMode2D.Impulse);
        float rockSpinSpeed = Random.Range(-rockTorque, rockTorque);
        rb.AddTorque(rockSpinSpeed, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        //rb.gravityScale = 0;        
    }
}
