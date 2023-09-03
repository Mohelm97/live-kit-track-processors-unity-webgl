# LiveKit Track Processors Unity SDK

<!--BEGIN_DESCRIPTION-->Use this SDK to add track processors feature to <a href="https://github.com/livekit/client-sdk-unity-web">LiveKit WebGL Unity SDK</a>, this SDK uses <a href="https://github.com/livekit/track-processors-js">LiveKit Track Processors</a><!--END_DESCRIPTION-->

## Installation :
Follow this [unity tutorial](https://docs.unity3d.com/Manual/upm-ui-giturl.html) using the `https://github.com/Mohelm97/live-kit-track-processors-unity-webgl.git` link.

## Examples

### Enable Background Blur
```cs
IEnumerator EnableCameraWithBlur ()
{
    var setCameraEnabledPromise = room.LocalParticipant.SetCameraEnabled(true);
    yield return setCameraEnabledPromise;
    if (!setCameraEnabledPromise.IsError)
    {
        JSHandle backgroundBlur = TrackProcessors.BackgroundBlur(10);
        setCameraEnabledPromise.ResolveValue.VideoTrack.SetProcessor(backgroundBlur);
    }
}
```