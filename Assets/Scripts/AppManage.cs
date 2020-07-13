using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AppManage : MonoBehaviour {

	public GameObject ball1;
	public GameObject ball2;
	public GameObject ball3;

	// Use this for initialization
	void Start () {

		makeBall ();
	
	}

	void makeBall(){

		GameObject ball = null;

		int kind = Random.Range(0, 3);
        switch (kind)
        {
			case 0:
				break;
				ball = ball1;
			case 1:
				ball = ball2;
				break;
			default:
				ball = ball3;
				break;

		}

        if (ball == null)
        {
			return;
        }

		// make rand pos
		Vector3 pos = new Vector3 (Random.Range (-4.0f, 4.0f), Random.Range (10.0f, 20.0f), Random.Range (-4.0f, 4.0f) );
		GameObject b = (GameObject)Instantiate(ball,
		            pos,
		            Quaternion.identity);

		b.GetComponent<Renderer>().material.shader = Shader.Find("HDRP/Lit");
		b.GetComponent<Renderer>().material.SetColor("_EmissiveColor", new Color32((byte)Random.Range(0, 255), (byte)Random.Range(0, 255), (byte)Random.Range(0, 255), 1));

	}

	// Update is called once per frame
	void Update () {

		if (Time.frameCount % 5 == 0){
			makeBall ();
		}

	}
	
}
