namespace NyuToolKit.PlayKit._2D.Component.HurtBox
{
    public interface IHurtBox
    {
        /// <summary>
        /// 受击触发时实现者的行为
        /// </summary>
        /// <param name="damage"></param>
        public void GetHurt(int damage);
    }
}