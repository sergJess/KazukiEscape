using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15f; // ������������ ��������
    public float acceleration = 5f; // ��������� �������
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // ��������� ������� ������� ��� AD
        float moveInput = Input.GetAxis("Horizontal");

        // ������� ������ ��������
        Vector3 targetVelocity = new Vector3(moveInput * speed, rb.linearVelocity.y, 0);

        // ������ ������ ������� �������� �� �������
        rb.linearVelocity = Vector3.Lerp(rb.linearVelocity, targetVelocity, acceleration * Time.fixedDeltaTime);
    }
}
