using Grpc.Core;

using System.Threading.Tasks;

namespace GrpcService.Services
{
    public class CustomerService :Greeter.GreeterBase
    {
        public override Task<CustomerResponse> GetCustomer(GetCustomerRequest request, ServerCallContext context)
        {
            // Burada müşteri bilgilerini veritabanından veya başka bir kaynaktan alabilirsiniz
            // Örnek olarak sadece sabit bir değer döndürelim
            return Task.FromResult(new CustomerResponse { Name = "John Doe", Email = "john@example.com" });
        }
    }
}
