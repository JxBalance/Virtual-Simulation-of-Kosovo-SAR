using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour {

    private RaycastHit mHit;
    private Ray mRay;
    public GameObject F117;
    public GameObject KC135;
    public GameObject Vehicle;
    public GameObject Satellite;

    // Use this for initialization
    void Start () {
        F117.SetActive(true);
        KC135.SetActive(false);
        Vehicle.SetActive(false);
        Satellite.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        mRay = Camera.main.ScreenPointToRay(Input.mousePosition); 
        if (Physics.Raycast(mRay, out mHit))
        {
            if (mHit.collider.gameObject.tag == "F117" && Input.GetMouseButtonDown(0))
            {
                F117.SetActive(true);
                KC135.SetActive(false);
                Vehicle.SetActive(false);
                Satellite.SetActive(false);
            }
            if (mHit.collider.gameObject.tag == "KC135" && Input.GetMouseButtonDown(0))
            {
                F117.SetActive(false);
                KC135.SetActive(true);
                Vehicle.SetActive(false);
                Satellite.SetActive(false);
            }
            if (mHit.collider.gameObject.tag == "EnemyVehicles" && Input.GetMouseButtonDown(0))
            {
                F117.SetActive(false);
                KC135.SetActive(false);
                Vehicle.SetActive(true);
                Satellite.SetActive(false);
            }
            if (mHit.collider.gameObject.tag == "Satellite" && Input.GetMouseButtonDown(0))
            {
                F117.SetActive(false);
                KC135.SetActive(false);
                Vehicle.SetActive(false);
                Satellite.SetActive(true);
            }
        }
        
	}
}
