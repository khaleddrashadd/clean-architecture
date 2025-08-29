namespace CleanArchitecture.Application.Services;

public class SubscriptionWriteService : ISubscriptionWriteService
{
    public string CreateSubscription(string subscriptionType, string adminId)
    {
        return Guid.CreateVersion7().ToString();
    }
}