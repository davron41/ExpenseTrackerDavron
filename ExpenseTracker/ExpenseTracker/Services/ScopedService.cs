namespace ExpenseTracker.Services
{
    public interface IScopedService
    {
        string GetValues();
        void SetValues(string value);
    }
    public class ScopedService : IScopedService
    {
        private string _value = string.Empty;
        public ScopedService()
        {
            _value = "Scoped Service";
        }
        public void SetValues(string value)
        {
            _value = value;
        }

        public string GetValues()
        {
            return $"scoped : {_value}";
        }
    }
}
