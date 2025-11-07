using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;           // �������x
    public float acceleration = 0.2f;  // �Փ˂��Ƃɑ�����X�s�[�h��
    private Vector2 direction;         // ���݂̐i�s����
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // �����_���ȕ��������߂�i360�x�̒�����j
        float angle = Random.Range(0f, 360f);
        direction = new Vector2(Mathf.Cos(angle * Mathf.Deg2Rad), Mathf.Sin(angle * Mathf.Deg2Rad)).normalized;

        // �������x��ݒ�
        rb.linearVelocity = direction * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // �Փ˂����ʂ̖@�����甽�˕������v�Z
        Vector2 normal = collision.contacts[0].normal;
        direction = Vector2.Reflect(direction, normal);

        // ���x�������グ��i�ő�l��ݒ肵�Ă�OK�j
        speed += acceleration;

        // �V�������x�ōĐݒ�
        rb.linearVelocity = direction * speed;
    }
}