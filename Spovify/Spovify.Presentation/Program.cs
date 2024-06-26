﻿using Spovify.Domain;

Console.WriteLine("Hello, World!");

var artist = new Person()
{
    Id = Guid.NewGuid(),
    Name = "Adele",
    Surname = "Adkins",
    Nick = "Adele"
};
var producer = new Person()
{
    Id = Guid.NewGuid(),
    Name = "Greg",
    Surname = "Kurstin",
    Nick = "Greg"
};

var song = new Song
{
    Id = Guid.NewGuid(),
    Name = "Hello",
    Artist = artist,
    Producer = producer,
    Lyricist = artist
};

var songService = new SongService();

songService.AddSong(song);

