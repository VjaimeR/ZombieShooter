using UnityEngine;

public class Inpact : MonoBehaviour
{
    private AudioSource _audioInpact;

    private void Start()
    {_audioInpact = GetComponent<AudioSource>(); }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            _audioInpact.Play();
        }
    }
}
   
