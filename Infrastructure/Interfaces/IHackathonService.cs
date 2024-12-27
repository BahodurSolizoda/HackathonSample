using Domain.DTOs;
using Domain.Entities;
using Infrastructure.ApiResponses;

namespace Infrastructure.Interfaces;

public interface IHackathonService
{
    public Task<Response<List<HackathonDTO>>> GetHackathons();
    public Task<Response<string>> AddHackathon(HackathonDTO hackathon);
    public Task<Response<string>> UpdateHackathon(HackathonDTO hackathon);
    public Task<Response<string>> DeleteHackathon(int id);
    public Task<Response<Hackathon>> GetHackathonTeamsById(int id);
}