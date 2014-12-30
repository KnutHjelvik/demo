using Timpex.Kata.Advanced.ByWord;

namespace Timpex.Kata.Advanced.ByFactory
{
    public class WordFactory<TWord> where TWord:Word,new()
    {
        private Factory<TWord> _innerFactory = Factory<TWord>.New();

        public WordFactory(Factory<TWord> factory)
        {
            _innerFactory = factory;
        } 

        public TWord Create()
        {
            var instance = _innerFactory.Create();
            return instance;
        }

        public WordFactory()
        {
        }
    }
}