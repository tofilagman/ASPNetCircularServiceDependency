namespace WebApplication1.Services
{
    public class BService
    {
        private readonly Lazy<AService> _A;

        private AService A
        {
            get { return _A.Value; }
        }

        public BService(Lazy<AService> a)
        {
            _A = a;
        }

        public async Task<string> TestACall()
        {
            return await A.GetFromA();
        }

        public async Task<string> GetFromB()
        {
            return await Task.FromResult("B");
        }
    }
}
