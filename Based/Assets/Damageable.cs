using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    public float MaxHealth;
    private float _currentHealth;
    private void OnEnable() => _currentHealth = MaxHealth;
    public void Damage(float damage)
    {
        if(_currentHealth<=0)
        {
            return;
        }
        _currentHealth -= damage;
        if (_currentHealth <= 0)
        {
          StartCoroutine(Die());
        }
    }
    private IEnumerator Die()
    {
        yield return null;
        Destroy(gameObject);
    }
}
