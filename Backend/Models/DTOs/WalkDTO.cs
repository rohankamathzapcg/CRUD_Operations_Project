﻿namespace Backend.Models.DTOs
{
    public class WalkDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Distance { get; set; }
        public string? ImageURL { get; set; }
        public int DifficultyId { get; set; }
        public int RegionId { get; set; }

        public RegionDTO Region { get; set; }
        public DifficultyDTO Difficulty { get; set; }
        
    }
}
