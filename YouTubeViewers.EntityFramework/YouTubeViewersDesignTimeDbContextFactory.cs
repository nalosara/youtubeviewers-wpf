using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeViewers.EntityFramework
{
    public class YouTubeViewersDesignTimeDbContextFactory : IDesignTimeDbContextFactory<YouTubeViewerDbContext>
    {
        
        public YouTubeViewerDbContext CreateDbContext(string[] args = null)
        {
            return new YouTubeViewerDbContext(new DbContextOptionsBuilder().UseSqlite("Data Source=YouTubeViewers.db").Options);
        }
    }
}
