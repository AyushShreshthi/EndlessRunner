using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToKill : MonoBehaviour
{
    [SerializeField] Gameevent _onDied;

    bool dead;

    private void OnMouseDown()
    {
        if (dead == false) Die();
    }
    void Die()
    {
        //GetComponent<Animator>().SetBool("Dead", true);
        _onDied?.Invoke();
        dead = true;
    }
}
