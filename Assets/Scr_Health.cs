using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Scr_Health : MonoBehaviour {

    public float m_MaxHealth;
    private float m_CurrentHealth;

    private Rigidbody m_Body;

    private void Start()
    {
        m_Body = GetComponent<Rigidbody>();
        m_CurrentHealth = m_MaxHealth;
        UpdateHealthbar();
    }
    
    private void UpdateHealthbar()
    {
        float ratio = m_CurrentHealth / m_MaxHealth;
    }
    private void TakeDamage(float damage, Vector2 direction)
    {
        m_CurrentHealth -= damage;

        if(m_CurrentHealth < 0)
        {
            m_CurrentHealth = 0;
        }
        UpdateHealthbar();

        m_Body.velocity =(new Vector3(direction.x, direction.y,0f));
    }
    private void HealDamage(float heal)
    {
        m_CurrentHealth += heal;

        if(m_CurrentHealth > m_MaxHealth)
        {
            m_CurrentHealth = m_MaxHealth;
        }
        UpdateHealthbar();
    }

}
