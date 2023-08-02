using AudioPlayer.Domain.Models;
using AudioPlayer.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace AudioPlayer.Infrastructure;

public class AudioPlayerDbContext : DbContext, IAudioPlayerDbContext
{
    public AudioPlayerDbContext(DbContextOptions<AudioPlayerDbContext> options) 
        : base(options) { }

    public DbSet<Playlist> Playlists { get; set; } = null!;
    public DbSet<Track> Tracks { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
}