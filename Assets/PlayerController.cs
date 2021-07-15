using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Image healthBar;
    [SerializeField] private Image manaWheel;

    private float maxHealth = 250f;
    private float currentHealth;

    private float maxMana = 100f;
    private float currentMana;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        currentMana = maxMana;
        UpdateHealthBar();
        UpdateManaWheel();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentHealth -= 15f;
            UpdateHealthBar();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            currentMana -= 5f;
            UpdateManaWheel();
        }
    }

    private void UpdateHealthBar()
    {
        healthBar.fillAmount = currentHealth / maxHealth;
    }

    private void UpdateManaWheel()
    {
        manaWheel.fillAmount = currentMana / maxMana;
    }
}
