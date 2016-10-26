using UnityEngine;
using System.Collections;


public class InputController : MonoBehaviour {

    private SpriteRenderer sr;
    [HideInInspector]
    public bool Status { get; set; }
	// Use this for initialization
	void Start () {
        sr = GetComponent<SpriteRenderer>();
        Status = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        
        if (Status)
        {
            sr.color = new Color(255, 255, 255);
            Status = false;
        }
        else
        {
            sr.color = new Color(255, 0, 0);
            Status = true;
        }
    }
}
