using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public int damage;
    public float speed;
    public float life;

    [HideInInspector]
    public string shooterTag;

	void Start () {
	
	}
	
	void Update () {
	
	}

    void OnCollisionEnter(Collider other)
    {
        if (!other.CompareTag(shooterTag))
        {
            // Damage hit object
            Destroy(gameObject);
        }
    }
}
