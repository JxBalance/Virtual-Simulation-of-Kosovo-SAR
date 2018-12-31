using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    private Transform m_Transform;

    // Use this for initialization
    void Start () {
        m_Transform = gameObject.GetComponent<Transform>(); 
	}
	
	// Update is called once per frame
	void Update () {
        m_Transform.Rotate(Vector3.up * 2f, Space.Self);
	}
}
