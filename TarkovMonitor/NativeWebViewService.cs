namespace TarkovMonitor
{
    public class NativeWebViewService
    {
        public event Action<bool>? MapsVisibilityChanged;
        public event Action<bool>? TrackerVisibilityChanged;
        public event Action<bool>? DrawerOpenChanged;

        public void SetMapsVisible(bool visible)
        {
            MapsVisibilityChanged?.Invoke(visible);
        }

        public void SetTrackerVisible(bool visible)
        {
            TrackerVisibilityChanged?.Invoke(visible);
        }

        public void SetDrawerOpen(bool open)
        {
            DrawerOpenChanged?.Invoke(open);
        }
    }
}
