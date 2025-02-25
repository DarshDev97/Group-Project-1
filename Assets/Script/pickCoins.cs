using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.UI;
public class pickCoins : MonoBehaviour
{
    private int currentCoin = 0;
    private int totalCoins = 4;
    public GameObject gameWinUI;
    public Text coinText;
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collect)
    {
        if (collect.gameObject.CompareTag("Coin"))
        {
           
          //  Debug.Log(collect.gameObject.tag + "Collected");
            IncreaseScore();
        }
    }
    void Update()
    {
    }

    private void IncreaseScore()
    {
        currentCoin++;

        coinText.text = currentCoin.ToString();

        if (currentCoin >= totalCoins) 
        {
            gameWinUI.SetActive(true);
        }
    }

}
