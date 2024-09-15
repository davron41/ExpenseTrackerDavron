namespace ExpenseTracker.Services
{
    public interface ISingletonService
    {
        string GetValues();
        void SetValues(string value);
    }
    public class SingletonService : ISingletonService
    {
        private string _value;
        public SingletonService()
        {
            _value = "singleton service";
        }
        public void SetValues(string value)
        {
            _value = value;
        }

        public string GetValues()
        {
            return $"singleton: {_value}";
        }
    }
}
