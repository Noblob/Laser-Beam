
using UnityEngine;

public class ShootLaser : MonoBehaviour
{
    public float damage = 10f;
    public float range = 70f;

    public Camera fpsCam;

    void Update() {
        Shoot();
    }

    void Shoot ()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}


