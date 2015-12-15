using UnityEngine;

public class ShootTimey : MonoBehaviour {

// The Tower that should be built
    public GameObject _timeyWimey;
    public variableControl _varCont;
    public bool _shooting;
    public bool _shot = false;
    AudioSource _pewPew;
    public Collider _theDalek;

    void Start() {
        GameObject theGround = GameObject.Find("Ground");
        _varCont = theGround.GetComponent<variableControl>();
        _pewPew = GetComponent<AudioSource>();
        _shooting = false;
    }
    void Update() {
        if (!_theDalek && _shot) {
            CancelInvoke("ShootTimeyWimey");
            _shot = false;
        }
    }

    void CancelShooting() {
        CancelInvoke("ShootTimeyWimey");
    }

    void ShootTimeyWimey() {
        // Build bullet above Buildplace
        if (_shooting) {
            //Debug.Log("Shot while " + _shooting);
            GameObject twInstance = Instantiate(_timeyWimey);
            twInstance.transform.position = transform.position + new Vector3(0f,0f,1);
            _pewPew.Play();
            _shot = true;
        }
    }

    void OnTriggerEnter(Collider enemy) { // Activate shooting at contact
        if (enemy.gameObject.name == "ActualDalek(Clone)") {
            Debug.Log("Cannon: TARGET DETECTED");
            _theDalek = enemy;
            Debug.Log("The Dalek is " + _theDalek);
            if (!_shooting) {
                InvokeRepeating("ShootTimeyWimey", _varCont.WT_FireRate, _varCont.WT_FireRate);
            }
            _shooting = true;
        }
    }


    void OnTriggerExit(Collider enemy) { // Deactivate shooting at contact loss
        if (enemy.gameObject.name == "ActualDalek(Clone)") {
            CancelInvoke("ShootTimeyWimey");
            _shooting = false;
            Debug.Log("Cannon: TARGET DEAD and NAME is " + enemy.gameObject.name);

        }
    }

}