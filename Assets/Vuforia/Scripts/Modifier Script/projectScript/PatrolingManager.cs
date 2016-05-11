using UnityEngine;
using System.Collections;

public class PatrolingManager : MonoBehaviour {


	NavMeshAgent agent;
	//public GameObject[] waypointsKupu;
	public GameObject[] waypointsKatak;
	//private int IndexKupu = 0;
	private int IndexKatak = 0;
	private float moveSpeed = 10f;


	// Use this for initialization
	void Start () {
		//CF = FindObjectOfType<ChasingFood> ();
		agent = GetComponent<NavMeshAgent> ();
		agent.updatePosition = true;
		agent.updateRotation = false;
		agent.speed = moveSpeed;


	}

	void Update(){
		/*if (this.tag == "Kupu") {
			if (Vector3.Distance (this.transform.position, waypointsKupu [IndexKupu].transform.position) >= 0.5) {
				agent.SetDestination (waypointsKupu [IndexKupu].transform.position);
			} else if (Vector3.Distance (this.transform.position, waypointsKupu [IndexKupu].transform.position) <= 0.5) {
				IndexKupu += 1;
				if (IndexKupu == waypointsKupu.Length) {
					IndexKupu = 0;
				}
			}
		}*/

		if (this.tag == "Katak") {
			if (Vector3.Distance (this.transform.position, waypointsKatak [IndexKatak].transform.position) >= 2) {
				agent.SetDestination (waypointsKatak [IndexKatak].transform.position);
			} else if (Vector3.Distance (this.transform.position, waypointsKatak [IndexKatak].transform.position) < 2) {
				IndexKatak += 1;
				if (IndexKatak == waypointsKatak.Length) {
					IndexKatak = 0;
				}
			}
		}
	}

	

}
