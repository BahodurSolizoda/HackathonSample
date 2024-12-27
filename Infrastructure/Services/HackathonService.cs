using System.Net;
using Domain.DTOs;
using Domain.Entities;
using Infrastructure.ApiResponses;
using Infrastructure.Data;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class HackathonService(DataContext context):IHackathonService
{
    public async Task<Response<List<HackathonDTO>>> GetHackathons()
    {
        var hackathons = await context.Hackathons.ToListAsync();
        var resulDtos = hackathons.Select(h => new HackathonDTO()
        {
            Id = h.Id,
            Name = h.Name,
            
        });
        return new Response<List<HackathonDTO>>(resulDtos.ToList());
    }

    public async Task<Response<string>> AddHackathon(HackathonDTO hackathon)
    {
        throw new NotImplementedException();
    }

    public async Task<Response<string>> UpdateHackathon(HackathonDTO hackathon)
    {
        throw new NotImplementedException();
    }

    public async Task<Response<string>> DeleteHackathon(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<Response<Hackathon>> GetHackathonTeamsById(int id)
    {
        throw new NotImplementedException();
    }
}