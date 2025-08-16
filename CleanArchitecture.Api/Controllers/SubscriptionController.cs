using CleanArchitecture.Contracts.Subscriptions;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SubscriptionController : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<SubscriptionResponse>> CreateSubscription(
        [FromBody] CreateSubscriptionRequest request)
    {
        // Here you would typically call a service to handle the subscription creation logic.
        // For this example, we will just return a dummy response.

        var response = new SubscriptionResponse
        {
            Id = Guid.CreateVersion7().ToString(),
            SubscriptionType = request.SubscriptionType
        };

        return Ok(response);
    }
}