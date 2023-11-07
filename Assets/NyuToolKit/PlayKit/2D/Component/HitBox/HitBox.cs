using Godot;
using NyuToolKit.PlayKit._2D.Component.HurtBox;

namespace NyuToolKit.PlayKit._2D.Component.HitBox
{
    /// <summary>
    /// 打击判定框组件，添加至对应的Area2D节点即可
    /// 指定对应_owner以连接
    /// 若要使用对应的功能，_owner实现对应的IHitBox接口
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
        /// 攻击触发时调用，触发打击接口行为
        /// </summary>
        /// <param name="other"></param>
        private void OnAreaEntered(Area2D other)
        {
            if (_owner is IHitBox hitBox)
                hitBox.GetHit();

            if (other is IHurtBox hurtBox)
                hurtBox.GetHurt(_damage);
        }
    }
}