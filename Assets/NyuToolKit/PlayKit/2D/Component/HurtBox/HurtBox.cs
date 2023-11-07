using Godot;

namespace NyuToolKit.PlayKit._2D.Component.HurtBox
{
    /// <summary>
    /// 受击判定框组件，添加至对应的Area2D节点即可
    /// 指定对应_owner以连接
    /// 若要使用对应的功能，_owner实现对应的IHurtBox接口
    /// </summary>
    public partial class HurtBox : Area2D
    {
        [Export] private Node2D _owner;

        /// <summary>
        /// 受到攻击时调用，触发受击接口行为
        /// </summary>
        /// <param name="damage"></param>
        public void TriggerHurt(int damage)
        {
            if (_owner is IHurtBox hurtBox)
                hurtBox.GetHurt(damage);
        }
    }
}