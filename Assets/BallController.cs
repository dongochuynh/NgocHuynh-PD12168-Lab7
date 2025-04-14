using UnityEngine;

public class BallController : MonoBehaviour
{
    public Sprite[] sprites;

    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.sprite = sprites[Random.Range(0, sprites.Length)];
    }

    void Update()
    {
        // Kiểm tra nếu crosshair gần và bấm Space thì phá bóng
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject crosshair = GameObject.Find("Crosshair");
            if (crosshair != null && Vector2.Distance(transform.position, crosshair.transform.position) < 0.6f)
            {
                Destroy(gameObject); // Bắn nổ
            }
        }
    }
}
