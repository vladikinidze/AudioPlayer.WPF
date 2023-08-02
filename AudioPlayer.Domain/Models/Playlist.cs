using System;
using System.Collections.Generic;

namespace AudioPlayer.Domain.Models;

public class Playlist
{
    public Guid Id { get; set; }    
    public string Title { get; set; } = null!;
    public DateTime CreationDate { get; set; }
    public string Image { get; set; } = null!;
    public User User { get; set; } = null!;


}