using Microsoft.AspNetCore.Authorization;

namespace RestaurantAPI.Autorizations
{
    public class CreatedMultipleRestaurantRequirement : IAuthorizationRequirement
    {
        public CreatedMultipleRestaurantRequirement(int minimumRestaurantCreated)
        {
            MinimumRestaurantCreated = minimumRestaurantCreated;
        }
        public int MinimumRestaurantCreated { get; }
    }
}
