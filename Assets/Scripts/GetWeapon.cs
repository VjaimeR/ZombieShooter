using UnityEngine;

public class GetWeapon : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Weapon"))
       {
        other.gameObject.SetActive(false);
       }
    }
}
