using UnityEngine;

public class ShootTimey : MonoBehaviour {

// The Tower that should be built
    public GameObject _timeyWimey;
    public variableControl _varCont;
    public bool _shooting;
    AudioSource _pewPew;

    void Start() {
        GameObject theGround = GameObject.Find("Ground");
        _varCont = theGround.GetComponent<variableControl>();
        _pewPew = GetComponent<AudioSource>();
        _shooting = false;
    }

    void ShootTimeyWimey() {
        // Build bullet above Buildplace
        if (_shooting) {
            //Debug.Log("Shot while " + _shooting);
            GameObject twInstance = Instantiate(_timeyWimey);
            twInstance.transform.position = transform.position + new Vector3(0f,0f,1);
            _pewPew.Play();
        }
    }

    void OnTriggerEnter(Collider enemy) { // Activate shooting at contact
        if (enemy.gameObject.name == "ActualDalek(Clone)") {
            Debug.Log("Cannon: TARGET DETECTED");
            if (!_shooting) {
                InvokeRepeating("ShootTimeyWimey", _varCont.WT_FireRate, _varCont.WT_FireRate);
            }
            _shooting = true;
        }
    }


    void OnTriggerExit(Collider enemy) { // Deactivate shooting at contact loss
        if (enemy.gameObject.name == "ActualDalek(Clone)") {
            Debug.Log("Cannon: TARGET DEAD");
            CancelInvoke("ShootTimeyWimey");
            _shooting = false;
        }
    }

}