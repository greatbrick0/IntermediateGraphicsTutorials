using UnityEngine;

public class FallBehaviour : MonoBehaviour
{
    Rigidbody rb;
    Vector3 pos;
    Vector3 rot;

    private void Start()
    {
        pos = transform.position;
        rot = transform.eulerAngles;
        rb = gameObject.AddComponent<Rigidbody>();
        rb.useGravity = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) Fall();
        if (Input.GetKeyDown(KeyCode.R)) Reset();
    }

    public void Fall()
    {
        rb.useGravity = true;
    }

    public void Reset()
    {
        transform.position = pos;
        transform.eulerAngles = rot;
    }
}
