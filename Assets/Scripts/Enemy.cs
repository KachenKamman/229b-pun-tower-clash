using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = 1.5f;
    private Rigidbody rb;
    private GameObject player;
    
    public float pushForce = 5f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }
    
    void Update()
    {
        Vector3 d = player.transform.position - transform.position;
        Vector3 dir = d.normalized;
        rb.AddForce(dir * speed);
    }
    
    void OnCollisionEnter(Collision PlayerCollision)
    {
        if (PlayerCollision.gameObject.CompareTag("Player"))
        {
            Rigidbody playerRigidbody = PlayerCollision.gameObject.GetComponent<Rigidbody>();
            if (playerRigidbody != null)
            {
                Vector3 pushDirection = PlayerCollision.transform.position - transform.position;
                playerRigidbody.AddForce(pushDirection.normalized * pushForce, ForceMode.Impulse);
            }
        }
    }
}
