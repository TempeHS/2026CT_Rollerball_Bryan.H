using UnityEngine;

public class VerticalPlatform : MonoBehaviour
{
    public float amplitude = 2f;   
    public float speed = 2f;       

    private Vector3 startPos;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
        startPos = transform.position;
    }

    void FixedUpdate()
    {
        float offset = Mathf.Sin(Time.time * speed) * amplitude;
        Vector3 newPos = startPos + new Vector3(0, offset, 0);

        rb.MovePosition(newPos);
    }
}