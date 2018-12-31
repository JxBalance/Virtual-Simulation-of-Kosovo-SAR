using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Satellite : MonoBehaviour {

    private LineRenderer m_LineRenderer3;
    private LineRenderer m_LineRenderer4;

    // Use this for initialization
    void Start () {
        m_LineRenderer3 = GameObject.Find("RayInformation3").GetComponent<LineRenderer>();
        m_LineRenderer4 = GameObject.Find("RayInformation4").GetComponent<LineRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        m_LineRenderer3.SetPosition(0, gameObject.GetComponent<Transform>().position);
        m_LineRenderer3.SetPosition(1, GameObject.Find("F117").GetComponent<Transform>().position);
        m_LineRenderer4.SetPosition(0, gameObject.GetComponent<Transform>().position);
        m_LineRenderer4.SetPosition(1, GameObject.Find("KC-135").GetComponent<Transform>().position);
    }
}
