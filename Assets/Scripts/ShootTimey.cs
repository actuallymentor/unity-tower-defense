using UnityEngine;

public class ShootTimey : MonoBehaviour {

// The Tower that should be built
    public GameObject _timeyWimey;
    public variableControl _varCont;

    void Start() {
    	GameObject theGround = GameObject.Find("Ground");
		_varCont = theGround.GetComponent<variableControl>();
    	InvokeRepeating("ShootTimeyWimey", _varCont.WT_FireRate, _varCont.WT_FireRate);
    }

    void ShootTimeyWimey() {
        // Build Tower above Buildplace
        GameObject twInstance = Instantiate(_timeyWimey);
        twInstance.transform.position = transform.position + new Vector3(0.5f,0.2f,1);
        // twInstance.transform.position = transform.position + Vector3.forward;
    }

}