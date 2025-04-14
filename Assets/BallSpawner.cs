using System.Collections;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public Sprite[] ballSprites;

    void Start()
    {
        StartCoroutine(SpawnBalls());
    }

    IEnumerator SpawnBalls()
    {
        while (true)
        {
            GameObject ball = Instantiate(ballPrefab, new Vector3(Random.Range(-7f, 7f), -4f, 0), Quaternion.identity);
            ball.GetComponent<BallController>().sprites = ballSprites;
            yield return new WaitForSeconds(2f);
        }
    }
}
