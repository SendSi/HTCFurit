using UnityEngine;
using System.Collections;

public class FruitSpawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartSpawnFruit ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void StartSpawnFruit(){
		StartCoroutine (SpawnFruit());
	}

	/// <summary>
	/// fruit prefabs
	/// </summary>
	public	GameObject[] FruitPrefabs;

	/// <summary>
	/// Spawns the fruit.
	/// </summary>
	/// <returns>The fruit.</returns>
	IEnumerator SpawnFruit(){
		while (true) {
			GameObject fruitGO=Instantiate(FruitPrefabs[Random.Range(0,FruitPrefabs.Length-1)]);
			Rigidbody rigidbody = fruitGO.GetComponent<Rigidbody> ();
			rigidbody.velocity = new Vector3 (0,5f,0);
			rigidbody.angularVelocity = new Vector3 (Random.Range (-5f, 5f), 0f, Random.Range (-5f, 5f));
			rigidbody.useGravity = true;
			Vector3 position = transform.position + transform.right * Random.Range (-1.0f,1.0f);
			fruitGO.transform.position = position;
			yield return new WaitForSeconds(3.0f);
		}
	}



}
