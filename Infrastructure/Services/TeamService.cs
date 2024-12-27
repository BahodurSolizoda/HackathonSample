using Domain.DTOs;
using Domain.Entities;
using Infrastructure.ApiResponses;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class TeamService(DataContext context):ITeamService
{
    public async Task<Response<List<TeamDTO>>> GetTeams()
    {
        throw new NotImplementedException();
    }

    public async Task<Response<string>> AddTeam(TeamDTO team)
    {
        throw new NotImplementedException();
    }

    public async Task<Response<string>> UpdateTeam(TeamDTO team)
    {
        throw new NotImplementedException();
    }

    public async Task<Response<string>> DeleteTeam(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<Response<Team>> GetHTeamParticipantById(int id)
    {
        throw new NotImplementedException();
    }
}