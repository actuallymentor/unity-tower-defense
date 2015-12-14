using UnityEngine;

public class ShootTimey : MonoBehaviour {

// The Tower that should be built
    public GameObject _timeyWimey;
    public variableControl _varCont;
    public bool _shooting = false;
    

    void Start() {
        GameObject theGround = GameObject.Find("Ground");
        _varCont = theGround.GetComponent<variableControl>();
        InvokeRepeating("ShootTimeyWimey", _varCont.WT_FireRate, _varCont.WT_FireRate);
    }

    void ShootTimeyWimey() {
        // Build bullet above Buildplace
        if (_shooting) {
            GameObject twInstance = Instantiate(_timeyWimey);
            twInstance.transform.position = transform.position + new Vector3(0f,0f,1);
        }
    }

    void OnTriggerEnter(Collider enemy) { // Activate shooting at contact
        if (enemy.gameObject.name == "ActualDalek(Clone)") {
            _shooting = true;
        }
    }


    void OnTriggerExit(Collider enemy) { // Deactivate shooting at contact loss
        if (enemy.gameObject.name == "ActualDalek(Clone)") {
            _shooting = false;
        }
    }

}