using Backend.Core.Dtos;

namespace Backend.Core.Interfaces
{
    public interface IAgencyApiClient
    {
        Task<ValidateAgencyResponse> ValidateAgencyAsync(ValidateAgencyRequest request);
    }
}