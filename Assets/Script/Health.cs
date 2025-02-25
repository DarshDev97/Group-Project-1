using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
    public GameObject gameOverUI;
    private int currentHealth; 
    public int maxHealth = 3; 
    public Text healthText;
    void Start()
    {
        currentHealth = maxHealth; 
        healthText.text = currentHealth.ToString();
    }

    private void OnTriggerEnter2D(Collider2D damage)
    {
        if (damage.gameObject.CompareTag("Enemy")) 
        {
            //Debug.Log(damage.gameObject.tag + "Damage");
            TakeDamage(1); 
        }
    }
    void Update()
    {
        
    }
    private void TakeDamage(int damage)
    {
        currentHealth -= damage; 

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Die(); 
        }

        healthText.text = currentHealth.ToString();
    }


    private void Die()
    {
        Debug.Log("Player Died!");
        gameOverUI.SetActive(true);
        Destroy(gameObject); 
    }
}
