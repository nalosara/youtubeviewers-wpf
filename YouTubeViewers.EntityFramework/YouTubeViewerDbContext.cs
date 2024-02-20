using DemoApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.EntityFramework.DTOs;

namespace YouTubeViewers.EntityFramework
{
    public class YouTubeViewerDbContext : DbContext
    {
        public YouTubeViewerDbContext(DbContextOptions options) : base(options) { }
        public DbSet<YouTubeViewerDTO> YouTubeViewers { get; set; }
    }
}
