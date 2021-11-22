using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDamage : MonoBehaviour
{
    [SerializeField] Canvas canvas;
    void Start()
    {
        canvas.enabled = false;
    }
    public void GetDamage()
    {
        StartCoroutine(DamageCoroutine());
    }
    IEnumerator DamageCoroutine()
    {
        canvas.enabled = true;
        yield return new WaitForSeconds(.2f);
        canvas.enabled = false;
    }

}
