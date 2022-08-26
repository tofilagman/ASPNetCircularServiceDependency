namespace WebApplication1.Services
{
    public class AService
    {
        private readonly Lazy<BService> _B;

        private BService B
        {
            get
            {
                return _B.Value;
            }
        }

        public AService(Lazy<BService> b)
        {
            _B = b;
        }

        public async Task<string> TestBCall()
        {
            return await B.GetFromB();
        }

        public async Task<string> GetFromA()
        {
            return await Task.FromResult("A");
        }
    }
}
