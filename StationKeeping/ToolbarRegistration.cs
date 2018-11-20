using UnityEngine;
using ToolbarControl_NS;

namespace StationKeeping
{
    [KSPAddon(KSPAddon.Startup.MainMenu, true)]
    public class RegisterToolbar : MonoBehaviour
    {
        void Start()
        {
            ToolbarControl.RegisterMod(StationKeeping.MODID, StationKeeping.MODNAME);
        }
    }
}