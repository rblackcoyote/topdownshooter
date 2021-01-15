using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JerkyHealthController : MonoBehaviour
{

    public int maxHealth;
    public int currentHealth;

    public float flashLength;
    private float flashCounter;

    private Renderer rend;
    public JerkyHealthBarScript jerkyHealthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }

        if (flashCounter > 0)
        {
            flashCounter -= Time.deltaTime;
            if (flashCounter <= 0)
            {
                //rend.material.SetColor("_Color", storedColor);
            }
        }
    }

    public void HurtJerky(int damageAmount)
    {
        currentHealth -= damageAmount;
        flashCounter = flashLength;
        //rend.material.SetColor("_Color", Color.red);
        jerkyHealthBar.SetHealth(currentHealth);
    }
}