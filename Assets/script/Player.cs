
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100f;

    private BaseStats stats;
    private WeaponData weapon;
    private float attackTimer;

    private void Awake()
    {
        stats = new BaseStats(maxHealth);
       
        SetWeapon(new WeaponData(10f, 3f, 1f));
    }

   
    public void SetWeapon(WeaponData weaponData)
    {
        weapon = weaponData;
        attackTimer = 0f;
    }

    public void TakeDamage(float amount)
    {
        stats.TakeDamage(amount);
    }

    private void Update()
    {
      
        attackTimer += Time.deltaTime;

        if (attackTimer >= weapon.AttackInterval)
        {
            Attack();
            attackTimer = 0f;
        }
    }

    private void Attack()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject enemyObject in enemies)
        {
            float distance = Vector2.Distance(transform.position, enemyObject.transform.position);

            if (distance <= weapon.Range)
            {
                Enemy enemy = enemyObject.GetComponent<Enemy>();
                if (enemy != null)
                {
                    enemy.TakeDamage(weapon.Damage);
                }
            }
        }
    }
}