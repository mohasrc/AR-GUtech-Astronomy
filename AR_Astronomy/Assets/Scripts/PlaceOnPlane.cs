using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlaceOnPlane : MonoBehaviour
{
    public GameObject objectToPlace; // Model of Object to Place.
    public GameObject placementIndicator; // The "Placement" object that shows where to place object
    private GameObject placedObject; // The Object we created at the Indicator position
    private ARRaycastManager raycaster; // AR Components on XR Origin
    private ARPlaneManager planecaster;

    private Pose placementPose; // Rotation and Position of the Indicator
    private bool placementPoseIsValid = false; // Can we place the Object on this Place (is a Plane detected etc.)

    void Start()
    {
        raycaster = FindObjectOfType<ARRaycastManager>(); 
        planecaster = FindObjectOfType<ARPlaneManager>();
        raycaster.enabled = true; // Enable the Components (safety meassure)
        planecaster.enabled = true;
    }

    void Update()
    {
        Vector3 screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f)); //3D Point in the Middle of the Screen
        List<ARRaycastHit> hits = new List<ARRaycastHit>(); // List of points we hit with the Raycast

        raycaster.Raycast(screenCenter, hits, TrackableType.Planes); 

        placementPoseIsValid = hits.Count > 0;

        if (placementPoseIsValid)
        {
            placementPose = hits[0].pose; // access the pose of the first hit Plane

            var cameraForward = Camera.current.transform.forward; // The direction Vector the AR Camera is looking in
            var cameraBearing = new Vector3(cameraForward.x, 0, cameraForward.z).normalized; // Normalize the Direction Vector and flatening it on the x-z plane
            placementPose.rotation = Quaternion.LookRotation(cameraBearing); 

            placementIndicator.SetActive(true); // Make the Indicator visible
            placementIndicator.transform.SetPositionAndRotation(placementPose.position, placementPose.rotation);
        }
        else
        {
            placementIndicator.SetActive(false); // deactivate the Indicator when we dont hit a plane
        }

        // if we have placed an object in the scene then remove the placement indicator
        if (placedObject != null) {
            placementIndicator.SetActive(false);
        }
    }

    public void PlaceObject() // Function to call when button is pressed
    {
        if (placementPoseIsValid) // check if we hit a plane
        {
            if (placedObject != null)
                Destroy(placedObject);

            placedObject = Instantiate(objectToPlace, placementPose.position, placementPose.rotation);
        }
    }
}
