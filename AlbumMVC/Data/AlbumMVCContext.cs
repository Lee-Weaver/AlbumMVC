using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AlbumMVC.Models;

namespace AlbumMVC.Data
{
    public class AlbumMVCContext : DbContext
    {
        public AlbumMVCContext (DbContextOptions<AlbumMVCContext> options)
            : base(options)
        {
        }

        public DbSet<AlbumMVC.Models.Album> Album { get; set; } = default!;
    }
}
