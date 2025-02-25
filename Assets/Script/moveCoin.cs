using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.UI;
public class moveCoin : MonoBehaviour
{
    bool coinMove;
    public float speed = 5f;
    GameObject target;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("CoinMove");
    }

    private void OnTriggerEnter2D(Collider2D collect)
    {
        if (collect.gameObject.CompareTag("Hero"))
        {
            gameObject.GetComponent<Collider2D>().enabled = false;
            coinMove = true;
            Destroy(gameObject, 2f);
        }
    }

    void Update()
    {
        if (coinMove)
        {
            transform.position = Vector3.Lerp(transform.position, target.transform.position, speed * Time.deltaTime);
        }
    }
}
