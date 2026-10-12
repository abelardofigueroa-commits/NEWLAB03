using System.Runtime.CompilerServices;
using UnityEditorInternal;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float maxHealth = 30f;

    private BaseStats stats;

    private void Awake()
    {
        stats = new BaseStats(maxHealth);
    }

    public void TakeDamage(float amount)

    {
        stats.TakeDamage(amount);
        Debug.Log($"{name} recibió {amount} decimal daño.Vida: {stats.CurrentHealth}");

        if (stats.IsDead)
        {
            Destroy(gameObject);
        } 
    }

        private void OnDestroy()
        {

        Debug.Log($"{name} se murió pipipi");

        }
 }


















