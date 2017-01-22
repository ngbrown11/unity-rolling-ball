using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour {

    public float force;
    public float radius;
    public GameObject explosion;
    public ParticleSystem particles;


	void OnCollision () {
        particles.transform.position = this.transform.position;
        Destroy(this.gameObject);
        particles.Play();
	}
}
