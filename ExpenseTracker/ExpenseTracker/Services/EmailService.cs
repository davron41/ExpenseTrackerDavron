namespace ExpenseTracker.Services
{
    public interface ISmsService
    {
        string GetValues();
        void ChangeValues();
    }

    public interface IEmailService
    {
        string GetValues();
        void ChangeValues();
    }

    public class EmailService : IEmailService
    {
        private readonly ISingletonService _singletonService;
        private readonly IScopedService _scopedService;
        private readonly ITransientService _transientService;

        public EmailService(ISingletonService singletonServiec, IScopedService scopedService, ITransientService transientService)
        {
            _singletonService = singletonServiec;
            _scopedService = scopedService;
            _transientService = transientService;
        }

        public void ChangeValues()
        {
            _singletonService.SetValues("Email Service Update");
            _scopedService.SetValues("Email Service Update");
            _transientService.SetValues("Email Service Update");
        }

        public string GetValues()
        {
            return $"Email service :\n{_singletonService.GetValues()}\n{_scopedService.GetValues()}\n{_transientService.GetValues()}";
        }
    }
    public class SmsService : ISmsService
    {
        private readonly ISingletonService _singletonService;
        private readonly IScopedService _scopedService;
        private readonly ITransientService _transientService;

        public SmsService(ISingletonService singletonService, IScopedService scopedService, ITransientService transientService)
        {
            _singletonService = singletonService;
            _scopedService = scopedService;
            _transientService = transientService;
        }

        public string GetValues()
        {
            return $"Sms Service: \n{_singletonService.GetValues()}\n{_scopedService.GetValues()}\n{_transientService.GetValues()}";
        }

        public void ChangeValues()
        {
            _singletonService.SetValues($"Sms Service Update");
            _scopedService.SetValues($"Sms Service Update");
            _transientService.SetValues($"Sms Service Update");
        }
    }
}
