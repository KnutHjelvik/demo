using System;

namespace Timpex.Sscc.ByCode
{
    public class CodeFactory
    {
        public static Func<CodeFactory> New = () => new CodeFactory();
        private SpaceRemover _spaceRemover = SpaceRemover.New();

        public CodeFactory(SpaceRemover spaceRemover)
        {
            _spaceRemover = spaceRemover;
        }

        public virtual Code CreateCode(string code)
        {
            var instance = Code.New();
            code = _spaceRemover.Remove(code);
            instance.Setup(code);
            return instance;
        }

        public CodeFactory()
        {
        }
    }
}