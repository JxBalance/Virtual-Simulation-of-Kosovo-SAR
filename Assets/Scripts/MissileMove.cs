using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMove : MonoBehaviour {

    private GameObject F117;
    private GameObject Vehicle;
    private Transform F117_Transform;
    private Transform Vehicle_Transform;
    private Transform m_Transform;
    private float m_speed=0.3f;
    public bool Attack = false;
    private float acceleration=0f;
    private float num = 0f;
    public GameObject Fire;
    public GameObject FireParticle;
    public GameObject Smoke;
    public GameObject ParticleSystem;

    // Use this for initialization
    void Start () {
        F117 = GameObject.Find("F117");
        Vehicle = GameObject.Find("Vehicle");
        F117_Transform = F117.GetComponent<Transform>();
        Vehicle_Transform = Vehicle.GetComponent<Transform>();
        m_Transform = gameObject.GetComponent<Transform>();
        m_Transform.position = Vehicle_Transform.position;
        Invoke("StartFiring", 3f);
    }
	
	// Update is called once per frame
	void Update () {
        num += 0.02f;
        if (num>=3f)
        {
            MissileMoveNow();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="F117")
        {
            Attack = true;
            //GameObject.Destroy(gameObject);
            F117.GetComponent<Rigidbody>().velocity = new Vector3(0f, -acceleration, -5f);
            Destroy(gameObject.GetComponent<MeshRenderer>());
            Destroy(gameObject.GetComponent<SphereCollider>());
            StartCoroutine(FlighterGo(2f));
        }
    }

    IEnumerator FlighterGo(float waittime)
    {
        yield return new WaitForSeconds(waittime);
        F117.GetComponent<F117Move>().FlighterSeperation();
    }

    private void MissileMoveNow()
    {
        m_speed += 0.05f;
        //m_Transform.position = new Vector3(Mathf.Lerp(m_Transform.position.x, F117_Transform.position.x, m_speed * Time.deltaTime), Mathf.Lerp(m_Transform.position.y, F117_Transform.position.y, m_speed * Time.deltaTime) ,Mathf.Lerp(m_Transform.position.z, F117_Transform.position.z, m_speed * Time.deltaTime));
        m_Transform.position = m_Transform.position + (F117_Transform.position - m_Transform.position) * Time.deltaTime * m_speed;
        acceleration += 0.15f;
    }

    private void StartFiring()
    {
        Fire.GetComponent<ParticleSystem>().Play();
        FireParticle.GetComponent<ParticleSystem>().Play();
        Smoke.GetComponent<ParticleSystem>().Play();
        ParticleSystem.GetComponent<ParticleSystem>().Play();
    }
}
