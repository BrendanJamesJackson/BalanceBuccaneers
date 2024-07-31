using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompassPointer : MonoBehaviour
{

    public GameObject _activePlayer;
    public GameObject _opponentPlayer;
    public GameObject _pointArm;

    private Vector3 _pointDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _pointDirection = (_opponentPlayer.transform.position - _activePlayer.transform.position).normalized;

        float angle = Mathf.Atan2(_pointDirection.y, _pointDirection.x) * Mathf.Rad2Deg;
        _pointArm.transform.rotation = Quaternion.Euler(0,0,angle-90);
    }
}
