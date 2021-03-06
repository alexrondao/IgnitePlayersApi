﻿using System.ComponentModel.DataAnnotations;

namespace PlayersApi {
    public class PlayerPostRequest {
        [Required]
        [MinLength(3)]
        [PlayerIsUnique]
        public string Name { get; set; }
        [Required]
        [Range(0, 150)]
        public int Age { get; set; }
    }
}