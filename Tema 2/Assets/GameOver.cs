using UnityEngine;

public class PlaySoundOnCollision : MonoBehaviour
{
    private  AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            if (audioSource != null)
            {
                Debug.Log("de ce???");
                audioSource.Play();
            }
        }
    }
}
