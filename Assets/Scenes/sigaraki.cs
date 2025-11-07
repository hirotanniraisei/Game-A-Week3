using UnityEngine;

public class sigaraki : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        // "Ball" というタグを持つオブジェクトに当たったらボールを削除
        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(collision.gameObject); // ボールを消す
        }
    }
}