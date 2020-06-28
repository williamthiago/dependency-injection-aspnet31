namespace Shared
{
    public class BooleanService : IBooleanService
    {
        private readonly bool _booleanValue;

        public BooleanService(bool booleanValue = false)
        {
            _booleanValue = booleanValue;
        }

        public bool GetBooleanValue()
        {
            return _booleanValue;
        }
    }
}