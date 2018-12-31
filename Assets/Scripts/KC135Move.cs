using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KC135Move : MonoBehaviour {

    private LineRenderer m_LineRenderer;
    private LineRenderer m_LineRenderer2;
    private MissileMove missileMove;
    private F117Move f117Move;

    // Use this for initialization
    void Start () {
        m_LineRenderer = GameObject.Find("RayInformation").GetComponent<LineRenderer>();
        m_LineRenderer2 = GameObject.Find("RayInformation2").GetComponent<LineRenderer>();
        missileMove = GameObject.Find("Missile").GetComponent<MissileMove>();
        f117Move = GameObject.Find("F117").GetComponent<F117Move>();
    }
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(-3f, 0f, 3f);
        if (missileMove.Attack == true)
        {
            m_LineRenderer.SetPosition(0, gameObject.GetComponent<Transform>().position);
            m_LineRenderer.SetPosition(1, GameObject.Find("F117").GetComponent<Transform>().position);
        }

        if (f117Move.flighterLeave ==true)
        {
            m_LineRenderer2.SetPosition(0, gameObject.GetComponent<Transform>().position);
            m_LineRenderer2.SetPosition(1, GameObject.Find("Zelko(Clone)").GetComponent<Transform>().position);
        }
        
    }
}
