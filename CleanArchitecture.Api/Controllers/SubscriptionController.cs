using CleanArchitecture.Application.Services;
using CleanArchitecture.Contracts.Subscriptions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SubscriptionController(ISubscriptionWriteService subscriptionWriteService,Mediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<SubscriptionResponse>> CreateSubscription(
        [FromBody] CreateSubscriptionRequest request)
    {
        // Here you would typically call a service to handle the subscription creation logic.
        // For this example, we will just return a dummy response.
        var subscriptionId =
            subscriptionWriteService.CreateSubscription(request.SubscriptionType.ToString(), request.AdminId);
        var response = new SubscriptionResponse
        {
            Id = subscriptionId,
            SubscriptionType = request.SubscriptionType
        };

        return Ok(response);
    }
}