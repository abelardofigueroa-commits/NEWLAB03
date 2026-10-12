public class WeaponData
{
    public float Damage { get; private set; }
    public float Range { get; private set; }
    public float AttackInterval { get; private set; } // segundos entre ataques

    public WeaponData(float damage, float range, float attackInterval)
    {
        Damage = damage;
        Range = range;
        AttackInterval = attackInterval;
    }
}
