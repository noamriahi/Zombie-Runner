using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;
    bool isDead =false;
    public bool IsDead()
    {
        return isDead;
    }
    //crate a public method which reduce hitpoins by the amount od damage
    public void TakeDamage(float damage)
    {
        BroadcastMessage("OnDamageTaken");
        hitPoints -= damage;
        if(hitPoints <= 0)
        {
                Die();
        }
    }
    private void Die()
    {
        if(isDead) return;
            GetComponent<Animator>().SetTrigger("die");
            isDead=true;
        StartCoroutine("dissapear");
    }
    IEnumerator dissapear()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}