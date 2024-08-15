namespace ExpenseTracker.Services
{
    public interface ITransientService
    {
        string GetValues();
        void SetValues(string value);
    }
    public class TransientService : ITransientService
    {
        private string _value;
        public TransientService()
        {
            _value = "Transient Service";
        }
        public void SetValues(string value)
        {
            _value = value;
        }

        public string GetValues()
        {
            return $"Transient: {_value}";
        }
    }
}
