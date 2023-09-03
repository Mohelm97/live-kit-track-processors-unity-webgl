using LiveKit;

namespace LiveKitTrackProcessors {
    public static class TrackProcessors
    {
        public static JSHandle BackgroundBlur(int blurRadius)
        {
            JSNative.PushString("trackprocessors");
            JSHandle tackprocessors = JSNative.GetProperty(JSNative.Window);
            JSNative.PushNumber(blurRadius);
            return JSNative.CallMethod(tackprocessors, "BackgroundBlur");
        }

        public static JSHandle VirtualBackground(string imagePath)
        {
            JSNative.PushString("trackprocessors");
            JSHandle tackprocessors = JSNative.GetProperty(JSNative.Window);
            JSNative.PushString(imagePath);
            return JSNative.CallMethod(tackprocessors, "VirtualBackground");
        }

        public static JSHandle Dummy()
        {
            JSNative.PushString("trackprocessors");
            JSHandle tackprocessors = JSNative.GetProperty(JSNative.Window);
            return JSNative.CallMethod(tackprocessors, "Dummy");
        }
    }
}