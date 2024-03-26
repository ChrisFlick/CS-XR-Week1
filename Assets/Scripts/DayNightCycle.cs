using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour {

    private bool _isDay;
    private bool _isTransitionActive;

    [SerializeField] private float _cycleSpeed = 1;
    [SerializeField] private float _speedDuringTransition = 50;

    private void Start() {
        SetIsDay();
    }

    private void Update() {
        float cycleSpeed = _cycleSpeed;
        if (_isTransitionActive) cycleSpeed = _speedDuringTransition;


        transform.Rotate(Vector3.right, Time.deltaTime * cycleSpeed);
        
        bool isDayCurrent = _isDay;

        SetIsDay();

        if (isDayCurrent != _isDay) {
            _isTransitionActive = false;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            _isTransitionActive = true;
        }
    }

    private void SetIsDay() {
        float yRotation = transform.localEulerAngles.y;
        _isDay = yRotation > -100f && yRotation < 99f; // If the x rotation is between -100 and 99 _isDay = true.
    }
}
