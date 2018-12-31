using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabelText2 : MonoBehaviour {

    private UILabel Label2;
    public string Label_2;

    // Use this for initialization
    void Start () {
        Label2 = GameObject.Find("Label2").GetComponent<UILabel>();
        Label_2 = "HeadQuarters\n";
    }
	
	// Update is called once per frame
	void Update () {
        Label2.text = Label_2;
    }
}
