using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed;
    Rigidbody m_Rigidbody;
    // Use this for initialization
    void Start () {
        m_Rigidbody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        m_Rigidbody.velocity = -transform.right * speed;
	}
}
