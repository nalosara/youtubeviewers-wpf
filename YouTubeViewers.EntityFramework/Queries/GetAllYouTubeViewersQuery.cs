using DemoApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.Domain.Queries;
using YouTubeViewers.EntityFramework.DTOs;

namespace YouTubeViewers.EntityFramework.Queries
{
    public class GetAllYouTubeViewersQuery : IGetAllYouTubeViewersQuery
    {

        private readonly YouTubeViewersDbContextFactory _dbContextFactory;

        public GetAllYouTubeViewersQuery(YouTubeViewersDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }
        public async Task<IEnumerable<YouTubeViewer>> Execute()
        {
            using(YouTubeViewerDbContext context = _dbContextFactory.Create())
            {
                IEnumerable<YouTubeViewerDTO> youTubeDTOs = await context.YouTubeViewers.ToListAsync();
                return youTubeDTOs.Select(y => new YouTubeViewer(y.Id, y.Username, y.IsSubscribed, y.IsMember));
            }
        }
    }
}
