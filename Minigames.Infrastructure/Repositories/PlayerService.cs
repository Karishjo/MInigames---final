using Minigames.Application.DTOs;
using Minigames.Application.Interfaces;

namespace Minigames.Infrastructure.Repositories
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public Task<PlayerDto> CreatePlayerAsync(CreatePlayerDto createPlayerDto)
        {
            throw new NotImplementedException();
        }

        public Task<PlayerDto> GetPlayerByNameAsync(string playerName)
        {
            throw new NotImplementedException();
        }

        public Task<PlayerGameSummaryDto?> GetPlayerGameSummaryAsync(string playerName)
        {
            throw new NotImplementedException();
        }
    }
}