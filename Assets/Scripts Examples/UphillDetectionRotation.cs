using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UphillDetectionRotation : MonoBehaviour
{
    //    [SerializeField] private CarController _carController;
    //    [SerializeField] private Transform _transformCar;

    //    [SerializeField] private float _carRotationX;
    //    [SerializeField] private float _uphillMotorTorque;
    //    [SerializeField] private float _deafualtMotorTorque;
    //    [SerializeField] private float _angleChanger;

    //    [SerializeField] private float _downhillForwardFrictionStifness;

    //    WheelFrictionCurve _defaultCurveForward;
    //    WheelFrictionCurve _defaultCurveSideways;
    //    private bool _downhillFriction;
    //    private bool _normalFriction;


    //    void Start()
    //    {
    //        RefOnStart();
    //        WheelFrictionOnStart();
    //    }

    //    void Update()
    //    {
    //        CarRotationXChecker();
    //    }

    //    private void RefOnStart()
    //    {
    //        _carController = GetComponent<CarController>();
    //        _transformCar = GetComponent<Transform>();
    //        _deafualtMotorTorque = _carController.MaxMotorTorque;
    //    }

    //    private void CarRotationXChecker()
    //    {
    //        _carRotationX = _transformCar.transform.localEulerAngles.x;
    //        {
    //            if (_carRotationX > 100)
    //            {
    //                _carRotationX = (360 - _carRotationX) * -1;
    //            }
    //        }


    //        if (_carRotationX < -_angleChanger && _carController._drivingForward == true)
    //        {
    //            //Driving Uphill forward
    //            _carController.MaxMotorTorque = _uphillMotorTorque;
    //            NormalFrictionBrake();
    //        }
    //        else if (_carRotationX > -_angleChanger && _carRotationX < _angleChanger && _carController._drivingForward == true)
    //        {
    //            //Driving Forward on flat Surface
    //            _carController.MaxMotorTorque = _deafualtMotorTorque;
    //            NormalFrictionBrake();
    //        }
    //        else if (_carRotationX < -_angleChanger && _carController._drivingForward == false)
    //        {
    //            //Driving Backward downhill
    //            _carController.MaxMotorTorque = _deafualtMotorTorque;
    //            DownhillFrictionBrake();
    //        }



    //        if (_carRotationX > _angleChanger && _carController._drivingForward == false)
    //        {
    //            //Driving Backward uphill
    //            _carController.MaxMotorTorque = _uphillMotorTorque;
    //            NormalFrictionBrake();
    //        }
    //        else if (_carRotationX < _angleChanger && _carRotationX > -_angleChanger && _carController._drivingForward == false)
    //        {
    //            //Driving Backward on flat Surface
    //            _carController.MaxMotorTorque = _deafualtMotorTorque;
    //            NormalFrictionBrake();
    //        }
    //        else if (_carRotationX > _angleChanger && _carController._drivingForward == true)
    //        {
    //            //Driving Forward downhill
    //            _carController.MaxMotorTorque = _deafualtMotorTorque;
    //            DownhillFrictionBrake();
    //        }
    //    }

    //    private void WheelFrictionOnStart()
    //    {
    //        _defaultCurveForward = new WheelFrictionCurve();
    //        _defaultCurveSideways = new WheelFrictionCurve();
    //        var otherWheel = GetComponentInChildren<WheelCollider>();
    //        _defaultCurveForward.extremumSlip = otherWheel.forwardFriction.extremumSlip;
    //        _defaultCurveForward.extremumValue = otherWheel.forwardFriction.extremumValue;
    //        _defaultCurveForward.asymptoteSlip = otherWheel.forwardFriction.asymptoteSlip;
    //        _defaultCurveForward.asymptoteValue = otherWheel.forwardFriction.asymptoteValue;
    //        _defaultCurveForward.stiffness = otherWheel.forwardFriction.stiffness;

    //        _defaultCurveSideways.extremumSlip = otherWheel.sidewaysFriction.extremumSlip;
    //        _defaultCurveSideways.extremumValue = otherWheel.sidewaysFriction.extremumValue;
    //        _defaultCurveSideways.asymptoteSlip = otherWheel.sidewaysFriction.asymptoteSlip;
    //        _defaultCurveSideways.asymptoteValue = otherWheel.sidewaysFriction.asymptoteValue;
    //        _defaultCurveSideways.stiffness = otherWheel.sidewaysFriction.stiffness;

    //        _normalFriction = true;
    //    }

    //    private void DownhillFrictionBrake()
    //    {
    //        if (_downhillFriction == true)
    //        {
    //            _downhillFriction = false;
    //            WheelCollider[] allWheels = this.GetComponentsInChildren<WheelCollider>();
    //            WheelFrictionCurve curve = new WheelFrictionCurve();
    //            WheelFrictionCurve curve2 = new WheelFrictionCurve();

    //            curve.extremumSlip = _defaultCurveForward.extremumSlip;
    //            curve.extremumValue = _defaultCurveForward.extremumValue;
    //            curve.asymptoteValue = _defaultCurveForward.asymptoteValue;
    //            curve.asymptoteSlip = _defaultCurveForward.asymptoteSlip;
    //            curve.stiffness = _downhillForwardFrictionStifness;

    //            curve2.extremumSlip = _defaultCurveSideways.extremumSlip;
    //            curve2.extremumValue = _defaultCurveSideways.extremumValue;
    //            curve2.asymptoteValue = _defaultCurveSideways.asymptoteValue;
    //            curve2.asymptoteSlip = _defaultCurveSideways.asymptoteSlip;
    //            curve2.stiffness = _defaultCurveSideways.stiffness;

    //            foreach (WheelCollider i in allWheels)
    //            {
    //                i.sidewaysFriction = curve2;
    //                i.forwardFriction = curve;
    //            }
    //            _normalFriction = true;
    //        }
    //    }

    //    private void NormalFrictionBrake()
    //    {
    //        if (_normalFriction == true)
    //        {
    //            _normalFriction = false;
    //            WheelCollider[] allWheels = this.GetComponentsInChildren<WheelCollider>();
    //            WheelFrictionCurve curve = new WheelFrictionCurve();
    //            WheelFrictionCurve curve2 = new WheelFrictionCurve();

    //            curve.extremumSlip = _defaultCurveForward.extremumSlip;
    //            curve.extremumValue = _defaultCurveForward.extremumValue;
    //            curve.asymptoteValue = _defaultCurveForward.asymptoteValue;
    //            curve.asymptoteSlip = _defaultCurveForward.asymptoteSlip;
    //            curve.stiffness = _defaultCurveForward.stiffness;

    //            curve2.extremumSlip = _defaultCurveSideways.extremumSlip;
    //            curve2.extremumValue = _defaultCurveSideways.extremumValue;
    //            curve2.asymptoteValue = _defaultCurveSideways.asymptoteValue;
    //            curve2.asymptoteSlip = _defaultCurveSideways.asymptoteSlip;
    //            curve2.stiffness = _defaultCurveSideways.stiffness;

    //            foreach (WheelCollider i in allWheels)
    //            {
    //                i.sidewaysFriction = curve2;
    //                i.forwardFriction = curve;
    //            }
    //            _downhillFriction = true;
    //        }
    //    }
}
