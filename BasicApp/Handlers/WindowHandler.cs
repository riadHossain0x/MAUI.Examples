#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;
#endif

namespace BasicApp.Handlers;

public class WindowHandler
{
    /// <summary>
    /// Resize window in win10
    /// </summary>
    /// <param name="windowWidth"></param>
    /// <param name="windowHeight"></param>
    public static void Handler(int windowWidth, int windowHeight)
    {
#if WINDOWS
        Microsoft.Maui.Handlers.WindowHandler.Mapper.AppendToMapping(nameof(IWindow), (handler, view) =>
        {
            var mauiWindow = handler.VirtualView;
            var nativeWindow = handler.PlatformView;
            nativeWindow.Activate();
            IntPtr windowHandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
            WindowId windowId = Win32Interop.GetWindowIdFromWindow(windowHandle);
            AppWindow appWindow = AppWindow.GetFromWindowId(windowId);
            appWindow.Resize(new Windows.Graphics.SizeInt32(windowWidth, windowHeight));
        });
#endif
    }
}
