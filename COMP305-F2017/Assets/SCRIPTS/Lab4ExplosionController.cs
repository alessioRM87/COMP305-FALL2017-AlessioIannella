using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4ExplosionController : MonoBehaviour {

    public float explosionRadius = 100.0f;
    public float explosionForce = 2.0f;
    public float animationTime = 0.8f;

    private RaycastHit2D[] hits;

    // Use this for initialization
    void Start()
    {
        hits = Physics2D.CircleCastAll(this.transform.position, explosionRadius, Vector2.zero);

        foreach (RaycastHit2D h in hits)
        {
            if (h.transform.gameObject.tag == "Crate")
                h.rigidbody.AddForce((h.transform.position - this.transform.position) * explosionForce, ForceMode2D.Impulse);
        }

        Destroy(this.gameObject, animationTime);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
