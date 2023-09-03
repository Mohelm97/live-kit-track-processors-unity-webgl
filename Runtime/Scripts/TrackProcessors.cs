using LiveKit;
using System.Runtime.InteropServices;

namespace LiveKitTrackProcessors {
    public static class TrackProcessors
    {
        [DllImport ("__Internal")]
        internal static extern void PushNumber(double nb);
        [DllImport ("__Internal")]
        internal static extern void PushString(string str);
        [DllImport ("__Internal")]
        internal static extern JSHandle GetProperty(JSHandle ptr);
        [DllImport ("__Internal")]
        internal static extern JSHandle CallMethod(JSHandle ptr, string fnc);
        [DllImport ("__Internal")]
        internal static extern JSHandle RetrieveWindowObject();

        public static JSHandle BackgroundBlur(int blurRadius)
        {
            PushString("trackprocessors");
            JSHandle tackprocessors = GetProperty(RetrieveWindowObject());
            PushNumber(blurRadius);
            return CallMethod(tackprocessors, "BackgroundBlur");
        }

        public static JSHandle VirtualBackground(string imagePath)
        {
            PushString("trackprocessors");
            JSHandle tackprocessors = GetProperty(RetrieveWindowObject());
            PushString(imagePath);
            return CallMethod(tackprocessors, "VirtualBackground");
        }

        public static JSHandle Dummy()
        {
            PushString("trackprocessors");
            JSHandle tackprocessors = GetProperty(RetrieveWindowObject());
            return CallMethod(tackprocessors, "Dummy");
        }
    }
}