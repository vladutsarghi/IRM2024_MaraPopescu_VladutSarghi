using UnityEngine;

public class HoleTrigger : MonoBehaviour
{
    public Transform teleportTarget;
    public Transform teleportTarget2;
    public Transform player;
    public Transform bat;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Debug.Log("Mingea a intrat în gaura!");

            other.transform.position = teleportTarget.position;

            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }

            Debug.Log("Mingea a fost teleportat!");

            TeleportPlayerToBall(other.transform);
        }
    }

    private void TeleportPlayerToBall(Transform ball)
    {
        player.position = teleportTarget2.position;
        bat.position = teleportTarget2.position;
    }
}
