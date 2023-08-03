using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarEngineSound : MonoBehaviour
{
    //[SerializeField] float _minSpeed;
    //[SerializeField] float _maxSpeed;
    //[SerializeField] float _minPitch;
    //[SerializeField] float _maxPitch;
    //[SerializeField] float _minVolume;
    //[SerializeField] float _volumeDivide;
    //private float _actualSpeed;
    //private float _carPitch;

    //private Rigidbody _rb;
    //private AudioSource _engineSound;
    //private CarController _carController;
    //public float CarPitchDivide;
    //private void Start()
    //{
    //    _rb = GetComponentInParent<Rigidbody>();
    //    _engineSound = GetComponentInChildren <AudioSource>();
    //    _carController = GetComponentInParent<CarController>();
    //    if(CarPitchDivide == 0)
    //    {
    //        CarPitchDivide = 5f;
    //    }
    //}

    //private void Update()
    //{
    //     EngineSound();
    //}

    //private void EngineSound()
    //{
    //    _actualSpeed = _rb.velocity.magnitude;
    //    _carPitch = _rb.velocity.magnitude / CarPitchDivide;

    //    if (_carController.Acceleration == 1 | _carController.Acceleration == -1)
    //    {
    //        if (_actualSpeed < _minSpeed)
    //        {
    //            if (_engineSound.pitch > _minPitch)
    //            {
    //                _engineSound.pitch -= 0.005f;
    //                if (_engineSound.volume >= _minVolume)
    //                {
    //                    _engineSound.volume -= 0.005f;
    //                }
    //            }
    //        }

    //        if (_actualSpeed > _minSpeed && _actualSpeed < _maxSpeed)
    //        {
    //            if (_engineSound.pitch <= _maxPitch) 
    //            {
    //                _engineSound.pitch = _minPitch + _carPitch;
    //                _engineSound.volume = (_minPitch + _carPitch) / _volumeDivide;
    //            }
    //        }
    //    }
    //    else
    //    {
    //        if (_engineSound.pitch > _minPitch)
    //        {
    //            _engineSound.pitch -= 0.01f;
    //            if (_engineSound.volume >= _minVolume)
    //            {
    //                _engineSound.volume -= 0.005f;
    //            }
               
    //        }
    //    }
    //}
}
