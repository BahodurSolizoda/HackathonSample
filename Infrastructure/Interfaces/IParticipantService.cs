using Domain.DTOs;
using Domain.Entities;
using Infrastructure.ApiResponses;

namespace Infrastructure.Interfaces;

public interface IParticipantService
{
    public Task<Response<List<ParticipantDTO>>> GetParticiants();
    public Task<Response<string>> AddParticipant(ParticipantDTO participant);
    public Task<Response<string>> UpdateParticipant(ParticipantDTO participant);
    public Task<Response<string>> DeleteParticipant(int id);
}