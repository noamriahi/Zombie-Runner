using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] ProgressBar Pb;

    private void Start()
    {
        Pb.BarValue = health;
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
        Pb.BarValue = health;
        if (health <= 0)
        {
            GetComponent<DeathHandler>().HundleDeath();
        }
    }
}
