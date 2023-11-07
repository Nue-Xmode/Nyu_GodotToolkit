using Godot;

namespace NyuToolKit.PlayKit._2D.Component.ScreenNotifier
{
    /// <summary>
    /// 物体相对屏幕检测的相关工具
    /// 添加至对应VisibleOnScreenNotifier2D节点
    /// 指定对应_owner以连接
    /// 若要使用对应的功能，_owner实现对应的IScreenNotifier接口
    /// </summary>
    public class ScreenNotifier : VisibleOnScreenNotifier2D
    {
        [Export] private Node2D _owner;
		
        public override void _Ready()
        {
            ScreenExited += OnScreenExited;
        }

        private void OnScreenExited()
        {
            if (_owner is IScreenNotifier screenNotifier)
                screenNotifier.OnScreenExited();
        }
    }
}

