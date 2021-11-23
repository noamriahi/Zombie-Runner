using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    DisplayDamage damagePlayer;
    [SerializeField] float damage = 40f;

    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
        damagePlayer = FindObjectOfType<DisplayDamage>();
    }

    public void AttachHitEvent()
    {
        if(target == null) return;
        target.TakeDamage(damage);
        damagePlayer.GetDamage();
    }
}
