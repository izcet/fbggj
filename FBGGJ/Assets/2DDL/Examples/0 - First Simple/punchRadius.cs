using UnityEngine;
using System.Collections;

public class punchRadius : MonoBehaviour {

	// Use this for initialization
	[Header ("Random variation on each frame")]
	public float mag = 0.5f;

	[Header ("Delay flicker")]
	public float delay = 0.081f;

	[Header ("Bright intensity")]
	public byte bright = 255;

	private float lastOffset;
	private Vector2 _initUVScale;
	private DynamicLight2D.DynamicLight dl;

	void Start () {
		dl = GetComponent<DynamicLight2D.DynamicLight>();
		//lastOffset = dl.LightRadius;
		_initUVScale = dl.uv_Scale;

		StartCoroutine(updateLoop());

	}

	IEnumerator updateLoop(){

		while(true){
			yield return new WaitForSeconds(delay);
			dl.LightColor = new Color32(dl.LightColor.r, dl.LightColor.g, dl.LightColor.b, bright);
			float rnd = Random.Range(-0.1f,0.1f) * mag;
			yield return null;
			yield return new WaitForEndOfFrame();
			dl.uv_Scale = new Vector2(_initUVScale.x + rnd ,_initUVScale.y + rnd );

		}
	}

}
