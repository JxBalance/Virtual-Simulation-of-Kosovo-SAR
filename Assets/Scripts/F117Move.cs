using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F117Move : MonoBehaviour {

    public GameObject Zelko;
    private Rigidbody m_Rigidbody;
    private Transform m_Transform;
    private MissileMove missileMove;
    public bool flighterLeave = false;
    private GameObject SpriteRecord1;
    private GameObject SpriteRecord2;

    // Use this for initialization
    void Start () {
        m_Rigidbody = gameObject.GetComponent<Rigidbody>();
        m_Transform = gameObject.GetComponent<Transform>();
        m_Transform.position = new Vector3(238f, 145f, 458f);
        missileMove = GameObject.Find("Missile").GetComponent<MissileMove>();
        SpriteRecord1 = GameObject.Find("SpriteRecord");
        SpriteRecord2 = GameObject.Find("SpriteHead");
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (missileMove .Attack ==false)
        {
            m_Rigidbody.velocity = new Vector3(0f, 0f, -15f);
        }
	}

    public void FlighterSeperation()
    {
        GameObject.Instantiate(Zelko, m_Transform.position + new Vector3(0f, 1f, -1f), m_Transform.rotation);
        flighterLeave = true;
        SpriteRecord1.GetComponent<LabelText>().Label_1 = "Action Progress\n" +
            "[3:40AM] KC-135 witnessed F-117A's being shot down.\n" +
            "[3:43AM] KC-135 detected Zelko's distress signal.\n";
        SpriteRecord2.GetComponent<LabelText2>().Label_2 = "HeadQuarters\n[3:44AM] KC-135 reported the message to SAR Center\n";
    }
}
