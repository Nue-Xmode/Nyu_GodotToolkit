using Godot;

namespace NyuToolKit.PlayKit._2D.Component.HitBox
{
    /// <summary>
    /// 打击判定框组件，添加至对应的Area2D节点即可
    /// 若要使用对应的功能，实现对应的IHitBox接口
    /// </summary>
    public partial class HitBox : Area2D
    {
        [Export] private Node2D _owner;
        [Export] private int _damage;
		
        public override void _Ready()
        {
            AreaEntered += OnAreaEntered;
        }
		
		
        /// <summary>
        /// 攻击触发时调用，触发对应接口行为
        /// </summary>
        /// <param name="other"></param>
        private void OnAreaEntered(Area2D other)
        {
            if (_owner is IHitBox hitBox)
                hitBox.Hit();

            if (other is HurtBox hurtBox)
                hurtBox.GetHurt(_damage);
        }
    }
}