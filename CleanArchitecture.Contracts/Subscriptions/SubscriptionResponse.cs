namespace CleanArchitecture.Contracts.Subscriptions;

public sealed record SubscriptionResponse
{
    public required string Id { get; init; }
    public required SubscriptionType SubscriptionType { get; init; }
}