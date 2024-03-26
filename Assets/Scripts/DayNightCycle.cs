using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour {

    private bool _isDay;
    private bool _isNightDayTransitionActive;

    [SerializeField] private float _cycleSpeed = 1;

    private void Start() {
        SetIsDay();
    }

    private void Update() {
        transform.Rotate(Vector3.right, Time.deltaTime * _cycleSpeed);

        SetIsDay();
    }

    private void SetIsDay() {
        float yRotation = transform.localEulerAngles.y;
        _isDay = yRotation > -100f && yRotation < 99f; // If the x rotation is between -100 and 99 _isDay = true.
    }
}
