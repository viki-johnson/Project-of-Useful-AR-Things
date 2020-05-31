using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.ARFoundation;

public class ARTracking : MonoBehaviour
{

// void Start ()
// {
// //1. Register For The ARFrame Updated Event
// UnityARSessionNativeInterface.ARFrameUpdatedEvent += ARFrameUpdated;
// UnityARSessionNativeInterface.ARSessionFailedEvent += ARSessionFailedEvent;
// }
// ///Then you would create functions to handle the callbacks e.g:
// /// <summary>
// /// Called Each Time The ARCamera Is Updated
// /// </summary>
// /// <param name="camera">Camera.</param>
// // public void ARFrameUpdated (UnityARCamera camera)
// public void ARFrameUpdated (ARCameraManager camera)
// {
// //1. Track The ARSession
// if (camera.trackingState == ARTrackingState.ARTrackingStateLimited) {
// logTrackingReason (camera.trackingReason);
// } else {
// logTrackingState (camera.trackingState);
// }
// logLighting (camera.lightData.arLightEstimate.ambientIntensity);
// }
// /// <summary>
// /// Determines If The Current Lighting Conditions Are Appropriate For The ARSession
// /// </summary>
// /// <param name="lightEstimate">Light estimate.</param>
// public void logLighting (float lightEstimate)
// {
// if (lightEstimate < 100) {
// arTrackingStatus = "Lighting Is To Dark";
// }
// }
// /// <summary>
// /// Informs The User About The Current Tracking State
// /// </summary>
// /// <param name="trackingState">Tracking state.</param>
// public void logTrackingState (ARTrackingState trackingState)
// {
// switch (trackingState) {
// case ARTrackingState.ARTrackingStateNormal:
// arTrackingStatus = "Tracking Ready";
// break;
// case ARTrackingState.ARTrackingStateNotAvailable:
// arTrackingStatus = "Tracking Unavailable";
// break;
// }
// }
// /// <summary>
// /// Informs The User About The Current Tracking Status
// /// </summary>
// /// <param name="reason">Reason.</param>
// public void logTrackingReason (ARTrackingStateReason reason)
// {
// switch (reason) {
// case ARTrackingStateReason.ARTrackingStateReasonExcessiveMotion:
// arTrackingStatus = "Please Slow Your Movement";
// break;
// case ARTrackingStateReason.ARTrackingStateReasonInsufficientFeatures:
// arTrackingStatus = "Try To Point At A Flat Surface";
// break;
// case ARTrackingStateReason.ARTrackingStateReasonInitializing:
// arTrackingStatus = "Initializing";
// break;
// }
// }
// /// <summary>
// /// Prints The ARSession Failed Event
// /// </summary>
// /// <param name="error">Error.</param>
// public void ARSessionFailedEvent (string error)
// {
// print (error);
// }
// /// Having done this you can handle these in the Update method like so:
// void Update ()
// {
// print (arTrackingStatus);
// }
}
