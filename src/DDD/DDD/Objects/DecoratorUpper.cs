namespace DDD.Objects
{
    // 1. 同じインターフェースの実装にする
    public sealed class DecoratorUpper : IComponent
    {
        // 2. 同じインターフェースを保持する
        private IComponent _child;

        // 3. コンストラクタで子階層を受ける
        public DecoratorUpper(IComponent child)
        {
            _child = child;
        }

        // 4. _childを使って実装（拡張）する
        public string GetData()
        {
            return _child.GetData().ToUpper();
        }
    }
}
