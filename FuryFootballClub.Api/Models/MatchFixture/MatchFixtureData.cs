﻿using System;

namespace FuryFootballClub.Api.Models.MatchFixture
{
    // TODO: convert stringly typed to strongly typed
    public class MatchFixtureData
    {
        public Guid Id { get; set; }
        public string Competition { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public string Field { get; set; }
        public DateTime? MatchTime { get; set; }
    }
}