using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour {

    public GameObject Light;
    public GameObject Spark;
    public GameObject Smoke;
    public GameObject Smoking;
    public GameObject Firing;
    private GameObject SpriteRecord1;
    private GameObject SpriteRecord2;
    private Rigidbody m_Rigidbody;
    private Rigidbody n_Rigidbody;
    private GameObject Missile;

    // Use this for initialization
    void Start () {
        SpriteRecord1 = GameObject.Find("SpriteRecord");
        SpriteRecord2 = GameObject.Find("SpriteHead");
        m_Rigidbody = GameObject.Find("F117").GetComponent<Rigidbody>();
        n_Rigidbody = GameObject.Find("Missile").GetComponent<Rigidbody>();
        Missile = GameObject.Find("Missile");
    }
	
	// Update is called once per frame
	void Update () {

	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Ground")
        {
            Light.GetComponent<ParticleSystem>().Play();
            Spark.GetComponent<ParticleSystem>().Play();
            Smoke.GetComponent<ParticleSystem>().Play();
            Smoke.GetComponent<ParticleSystem>().Play();
            Firing.GetComponent<ParticleSystem>().Play();
            m_Rigidbody.velocity = new Vector3(0f, 0f, 0f);

            if (null!=Missile )
            {
                n_Rigidbody.velocity = new Vector3(0f, 0f, 0f);
            }
            
            SpriteRecord1.GetComponent<LabelText>().Label_1 = "Action Progress\n" +
                "[3:43AM] KC-135 detected Zelko's distress signal.\n" +
                "[3:50AM] F-117A crashed.";
            GameObject.Destroy(Missile);
            StartCoroutine(ReportToCAOC(1f));
        }

        if (other.tag == "Missile")
        {
            Light.GetComponent<ParticleSystem>().Play();
            Spark.GetComponent<ParticleSystem>().Play();
            Smoke.GetComponent<ParticleSystem>().Play();
            SpriteRecord1.GetComponent<LabelText>().Label_1 += "[3:40AM] KC-135 witnessed F-117A's being shot down.\n";
        }
    }

    IEnumerator ReportToCAOC(float waittime)
    {
        yield return new WaitForSeconds(waittime);
        SpriteRecord2.GetComponent<LabelText2>().Label_2 = "HeadQuarters\n" +
            "[3:44AM] KC-135 reported the message to SAR Center\n" +
            "[3:55AM] SAR Center reported the message to CAOC\n";
        
    }
}
