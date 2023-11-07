using Godot;

namespace NyuToolKit.Generic
{
    public static class GenericSettings
    {
        public static float Gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle(); //将Variant转换为float
    }
}

