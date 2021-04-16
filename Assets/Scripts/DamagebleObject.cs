using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagebleObject : MonoBehaviour
{
    [SerializeField] private float _hitPoints;
    
    private void TakeDamage(float damage)
    {
        _hitPoints -= damage;

        if (_hitPoints < 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
