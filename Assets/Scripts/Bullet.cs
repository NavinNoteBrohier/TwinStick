using UnityEngine;

public class Bullet : MonoBehaviour
{
    enum bulletType
    {
        normal = 1,
        lazer,
        rocket
    }

    public int damage;
    public float speed;
    public float life;

    bulletType type;

    [HideInInspector]
    public string shooterTag;

    void Awake()
    {
        type = bulletType.normal;
        damage = 5;
        speed = 0.4f;
        life = 3f;
    }

    public void initialize(int a_type)
    {
        type = (bulletType)a_type;

        if (type == bulletType.normal)
        {
            damage = 5;
            speed = 0.5f;
            life = 3f;
        }
        else if (type == bulletType.lazer)
        {
            damage = 1;
            speed = 0;
            life = 3f;
        }
        else if (type == bulletType.rocket)
        {
            damage = 20;
            speed = 0.2f;
            life = 3f;
        }
    }
	
	void Update()
    {
        if (type == bulletType.normal)
        {
            life -= Time.deltaTime;
            transform.position += transform.forward * speed;
        }
        else if (type == bulletType.lazer)
        {

        }
        else if (type == bulletType.rocket)
        {
            life -= Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (type == bulletType.normal || type == bulletType.rocket)
        {
            if (!other.CompareTag(shooterTag) && !other.CompareTag(transform.tag))
            {
                // TODO: Damage other object
                Destroy(gameObject);
            }
        }
    }
}
