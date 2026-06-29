using Minigames.Application.Interfaces;
using Minigames.Domain.Entities;

namespace Minigames.Infrastructure.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        public Task<Player?> GetPlayerByNameAsync(string playerName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Player>> GetAllPlayersAsync()
        {
            throw new NotImplementedException();
        }

        public Task AddPlayerAsync(Player player)
        {
            throw new NotImplementedException();
        }
    }
}