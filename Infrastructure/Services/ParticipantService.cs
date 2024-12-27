using Domain.DTOs;
using Domain.Entities;
using Infrastructure.ApiResponses;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class ParticipantService(DataContext context):IParticipantService
{
    public async Task<Response<List<ParticipantDTO>>> GetParticiants()
    {
        throw new NotImplementedException();
    }

    public async Task<Response<string>> AddParticipant(ParticipantDTO participant)
    {
        throw new NotImplementedException();
    }

    public async Task<Response<string>> UpdateParticipant(ParticipantDTO participant)
    {
        throw new NotImplementedException();
    }

    public async Task<Response<string>> DeleteParticipant(int id)
    {
        throw new NotImplementedException();
    }
}