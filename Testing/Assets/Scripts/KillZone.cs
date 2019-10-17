using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider lava)
    {
        Destroy(lava.gameObject);
    }
}
