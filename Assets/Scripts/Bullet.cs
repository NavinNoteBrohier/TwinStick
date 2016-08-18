using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public int damage;
    public float speed;
    public float life;

    [HideInInspector]
    public string shooterTag;

	void Start () {
        damage = 10;
        speed = 0.4f;
        life = 3f;
	}
	
	void Update () {
        life -= Time.deltaTime;
        transform.position += transform.forward * speed;
	}

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag(shooterTag) && !other.CompareTag(transform.tag))
        {
            // TODO: Damage other object
            Destroy(gameObject);
        }
    }
}
