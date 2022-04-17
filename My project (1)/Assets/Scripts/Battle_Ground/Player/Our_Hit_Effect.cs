using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Our_Hit_Effect : MonoBehaviour
{
    public GameObject Hit_Effect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Enemy") ||
            other.gameObject.layer == LayerMask.NameToLayer("Dragon") ||
            other.gameObject.layer == LayerMask.NameToLayer("Item") ||
            other.gameObject.layer == LayerMask.NameToLayer("Monster"))
        { GameObject go_hit_effect = Instantiate(Hit_Effect, transform.position, Quaternion.identity);
            Destroy(go_hit_effect, 1f);
        } 
    }
}
