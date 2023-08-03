using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FrictionChanger : MonoBehaviour
{
    //[SerializeField] private float _forwardFrictionStifness;
    //[SerializeField] private float _sidewaysFrictionStifness;
    //[SerializeField] private float _sidewaysRearFrictionStifness;

    //WheelFrictionCurve _defaultCurveForwardFront;
    //WheelFrictionCurve _defaultCurveSidewaysFront;

    //WheelFrictionCurve _defaultCurveForwardRear;
    //WheelFrictionCurve _defaultCurveSidewaysRear;
    //private void OnTriggerEnter(Collider other)
    //{
    //    if(other.tag == "WheelMeshColliderFW")
    //    {
    //        _defaultCurveForwardFront = new WheelFrictionCurve();
    //        _defaultCurveSidewaysFront = new WheelFrictionCurve();
    //        var otherWheel = other.GetComponentInParent<WheelCollider>();
    //        _defaultCurveForwardFront.extremumSlip = otherWheel.forwardFriction.extremumSlip;
    //        _defaultCurveForwardFront.extremumValue = otherWheel.forwardFriction.extremumValue;
    //        _defaultCurveForwardFront.asymptoteSlip = otherWheel.forwardFriction.asymptoteSlip;
    //        _defaultCurveForwardFront.asymptoteValue = otherWheel.forwardFriction.asymptoteValue;
    //        _defaultCurveForwardFront.stiffness = otherWheel.forwardFriction.stiffness;

    //        _defaultCurveSidewaysFront.extremumSlip = otherWheel.sidewaysFriction.extremumSlip;
    //        _defaultCurveSidewaysFront.extremumValue = otherWheel.sidewaysFriction.extremumValue;
    //        _defaultCurveSidewaysFront.asymptoteSlip = otherWheel.sidewaysFriction.asymptoteSlip;
    //        _defaultCurveSidewaysFront.asymptoteValue = otherWheel.sidewaysFriction.asymptoteValue;
    //        _defaultCurveSidewaysFront.stiffness = otherWheel.sidewaysFriction.stiffness;
                
    //            WheelFrictionCurve curve = new WheelFrictionCurve();
    //            curve.extremumSlip = _defaultCurveForwardFront.extremumSlip;
    //            curve.extremumValue = _defaultCurveForwardFront.extremumValue;
    //            curve.asymptoteValue = _defaultCurveForwardFront.asymptoteValue;
    //            curve.asymptoteSlip = _defaultCurveForwardFront.asymptoteSlip;
    //            curve.stiffness = _forwardFrictionStifness;

    //            WheelFrictionCurve curve2 = new WheelFrictionCurve();
    //            curve2.extremumSlip = _defaultCurveSidewaysFront.extremumSlip;
    //            curve2.extremumValue = _defaultCurveSidewaysFront.extremumValue;
    //            curve2.asymptoteValue = _defaultCurveSidewaysFront.asymptoteValue;
    //            curve2.asymptoteSlip = _defaultCurveSidewaysFront.asymptoteSlip;
    //            curve2.stiffness = _sidewaysFrictionStifness;

    //        otherWheel.forwardFriction = curve;
    //        otherWheel.sidewaysFriction = curve2;

    //    }
    //    else if(other.tag == "WheelMeshColliderRW")
    //    {
    //        _defaultCurveForwardRear = new WheelFrictionCurve();
    //        _defaultCurveSidewaysRear = new WheelFrictionCurve();
    //        var otherWheel = other.GetComponentInParent<WheelCollider>();
    //        _defaultCurveForwardRear.extremumSlip = otherWheel.forwardFriction.extremumSlip;
    //        _defaultCurveForwardRear.extremumValue = otherWheel.forwardFriction.extremumValue;
    //        _defaultCurveForwardRear.asymptoteSlip = otherWheel.forwardFriction.asymptoteSlip;
    //        _defaultCurveForwardRear.asymptoteValue = otherWheel.forwardFriction.asymptoteValue;
    //        _defaultCurveForwardRear.stiffness = otherWheel.forwardFriction.stiffness;

    //        _defaultCurveSidewaysRear.extremumSlip = otherWheel.sidewaysFriction.extremumSlip;
    //        _defaultCurveSidewaysRear.extremumValue = otherWheel.sidewaysFriction.extremumValue;
    //        _defaultCurveSidewaysRear.asymptoteSlip = otherWheel.sidewaysFriction.asymptoteSlip;
    //        _defaultCurveSidewaysRear.asymptoteValue = otherWheel.sidewaysFriction.asymptoteValue;
    //        _defaultCurveSidewaysRear.stiffness = otherWheel.sidewaysFriction.stiffness;

    //        WheelFrictionCurve curve = new WheelFrictionCurve();
    //        curve.extremumSlip = _defaultCurveForwardRear.extremumSlip;
    //        curve.extremumValue = _defaultCurveForwardRear.extremumValue;
    //        curve.asymptoteValue = _defaultCurveForwardRear.asymptoteValue;
    //        curve.asymptoteSlip = _defaultCurveForwardRear.asymptoteSlip;
    //        curve.stiffness = _forwardFrictionStifness;

    //        WheelFrictionCurve curve2 = new WheelFrictionCurve();
    //        curve2.extremumSlip = _defaultCurveSidewaysRear.extremumSlip;
    //        curve2.extremumValue = _defaultCurveSidewaysRear.extremumValue;
    //        curve2.asymptoteValue = _defaultCurveSidewaysRear.asymptoteValue;
    //        curve2.asymptoteSlip = _defaultCurveSidewaysRear.asymptoteSlip;
    //        curve2.stiffness = _sidewaysRearFrictionStifness;

    //        otherWheel.forwardFriction = curve;
    //        otherWheel.sidewaysFriction = curve2;
    //    }
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.tag == "WheelMeshColliderFW")
    //    {
    //            var otherWheel = other.GetComponentInParent<WheelCollider>();
    //            WheelFrictionCurve curve = new WheelFrictionCurve();
    //            WheelFrictionCurve curve2 = new WheelFrictionCurve();

    //            curve.extremumSlip = _defaultCurveForwardFront.extremumSlip;
    //            curve.extremumValue = _defaultCurveForwardFront.extremumValue;
    //            curve.asymptoteValue = _defaultCurveForwardFront.asymptoteValue;
    //            curve.asymptoteSlip = _defaultCurveForwardFront.asymptoteSlip;
    //            curve.stiffness = _defaultCurveForwardFront.stiffness;

    //        curve2.extremumSlip = _defaultCurveSidewaysFront.extremumSlip;
    //        curve2.extremumValue = _defaultCurveSidewaysFront.extremumValue;
    //        curve2.asymptoteValue = _defaultCurveSidewaysFront.asymptoteValue;
    //        curve2.asymptoteSlip = _defaultCurveSidewaysFront.asymptoteSlip;
    //        curve2.stiffness = _defaultCurveSidewaysFront.stiffness;

    //        otherWheel.sidewaysFriction = curve2;
    //        otherWheel.forwardFriction = curve;
    //    }
    //    else if(other.tag == "WheelMeshColliderRW")
    //    {
    //        var otherWheel = other.GetComponentInParent<WheelCollider>();
    //        WheelFrictionCurve curve = new WheelFrictionCurve();
    //        WheelFrictionCurve curve2 = new WheelFrictionCurve();

    //        curve.extremumSlip = _defaultCurveForwardRear.extremumSlip;
    //        curve.extremumValue = _defaultCurveForwardRear.extremumValue;
    //        curve.asymptoteValue = _defaultCurveForwardRear.asymptoteValue;
    //        curve.asymptoteSlip = _defaultCurveForwardRear.asymptoteSlip;
    //        curve.stiffness = _defaultCurveForwardRear.stiffness;

    //        curve2.extremumSlip = _defaultCurveSidewaysRear.extremumSlip;
    //        curve2.extremumValue = _defaultCurveSidewaysRear.extremumValue;
    //        curve2.asymptoteValue = _defaultCurveSidewaysRear.asymptoteValue;
    //        curve2.asymptoteSlip = _defaultCurveSidewaysRear.asymptoteSlip;
    //        curve2.stiffness = _defaultCurveSidewaysRear.stiffness;

    //        otherWheel.sidewaysFriction = curve2;
    //        otherWheel.forwardFriction = curve;
    //    }
    //}
}
