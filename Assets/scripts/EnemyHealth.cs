using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public Slider healthSlider;
    public int maxHealth = 2;
    private int currentHealth;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        healthSlider.maxValue = maxHealth;
        healthSlider.value = healthSlider.maxValue;
        healthSlider.fillRect.gameObject.SetActive(true);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void decrementHealth(int amount)
    {
        healthSlider.value -= amount;
        if (healthSlider.value <= 0)
        {
            gameManager.AddScore(maxHealth);
            Destroy(gameObject, 0.1f);

        }

    }
}
