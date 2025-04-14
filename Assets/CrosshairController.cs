using UnityEngine;

public class CrosshairController : MonoBehaviour
{
    public float shootRadius = 0.5f;

    void Update()
    {
        // Di chuyển theo chuột
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;
        transform.position = mousePos;

        // Bắn khi click chuột trái
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Tìm tất cả bóng gần đó
        Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, shootRadius);
        foreach (Collider2D hit in hits)
        {
            if (hit.CompareTag("Ball"))
            {
                Destroy(hit.gameObject);
            }
        }
    }
}
