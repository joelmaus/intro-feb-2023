using LearningResourcesApi.Domain;

namespace LearningResourcesApi.Models
{
    public record GetResourcesResponse
    {

    }
    public record GetResourceItem
    {
        public string Id { get; init; } = "";
        public string Description { get; init; } = "";
        public LearningItemType Type { get; init; }
        public string Link { get; init; } = "";
    }
}
