using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabelLookAt : MonoBehaviour {

    public GameObject Camera;
    private Transform m_Transform;

	// Use this for initialization
	void Start () {
        m_Transform = gameObject.GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        m_Transform.LookAt(Camera.GetComponent<Transform>().position);
    }
}
