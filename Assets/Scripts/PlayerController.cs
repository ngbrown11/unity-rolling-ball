using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;

    private Rigidbody rb;

    public ParticleSystem particles;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
        if (GameObject.FindGameObjectsWithTag("PickUp") == null) {
            Application.Quit();
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("PickUp")) {
            particles.transform.position = other.transform.position;
            particles.Simulate(0, false, true);
            other.gameObject.SetActive(false);
            
        }
    }

    /* Update is called once per frame
    void Update () {
        Vector3 current = transform.position;

        float h = Input.GetAxis("Horizontal") * 2;
        float v = Input.GetAxis("Vertical") * 2;
        transform.position = new Vector3(h, v, 0);

        float mh = Input.GetAxis("Mouse X") * 2;
        float mv = Input.GetAxis("Mouse Y") * 2;
        transform.position = new Vector3(mh, mv, 0);

        bool fire1 = Input.GetButton("Fire1");
        bool fire2 = Input.GetButton("Fire2");
        bool fire3 = Input.GetButton("Fire3");

        bool fire4 = Input.GetButton("left ctrl");
        bool fire5 = Input.GetButton("left alt");
        bool fire6 = Input.GetButton("space");

        if (fire1)
        {
            transform.position = new Vector3(current.x, current.y + 0.3f, current.z);

        }
        if (fire2)
        {
            transform.position = new Vector3(current.x + 0.3f, current.y, current.z);

        }
        if (fire3)
        {
            transform.position = new Vector3(current.x - 0.3f, current.y, current.z);

        }

    }*/
}
