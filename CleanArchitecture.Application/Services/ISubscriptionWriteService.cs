namespace CleanArchitecture.Application.Services;

public interface ISubscriptionWriteService
{
    string CreateSubscription(string subscriptionType, string adminId);
}