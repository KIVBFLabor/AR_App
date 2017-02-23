using System.Collections;
using UnityEngine;

namespace Kudan.AR
{ 
public class PlaceMarkerlessObject : MonoBehaviour
{
    public KudanTracker _kudanTracker;

        public void PlaceClick()
        {
            Vector3 position;
            Quaternion orientation;

            _kudanTracker.FloorPlaceGetPose(out position, out orientation);
            _kudanTracker.ArbiTrackStart(position, orientation);
        }

}
}