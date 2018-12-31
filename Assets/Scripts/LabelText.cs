using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabelText : MonoBehaviour {
    
    private UILabel Label1;
    public string Label_1;

    // Use this for initialization
    void Start () {
        Label1 = GameObject.Find("Label1").GetComponent<UILabel>();
        Label_1 = "Action Progress\n[3:30AM] F-117A was cruising.\n";
    }
	
	// Update is called once per frame
	void Update () {
        Label1.text = Label_1;
	}
}
