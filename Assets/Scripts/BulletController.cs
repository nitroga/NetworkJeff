using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

  [SerializeField]
  float initialVelocity = 6;

  [SerializeField]
  float lifeTime = 4;

	void Start ()
  {
    Rigidbody rigidbody = GetComponent<Rigidbody>();
    rigidbody.velocity = transform.forward * initialVelocity;

    Destroy(this.gameObject, lifeTime);
	}
  
  void OnCollisionEnter(Collision other) {
    Destroy(this.gameObject);

  }
}
