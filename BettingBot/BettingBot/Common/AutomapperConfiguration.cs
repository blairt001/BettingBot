﻿using AutoMapper;
using BettingBot.Models;
using BettingBot.Models.ViewModels;

namespace BettingBot.Common
{
    public static class AutoMapperConfiguration
    {
        public static IMapper Mapper { get; set; }

        public static void Configure()
        {
            var config = new MapperConfiguration(ConfigureUserMapping);
            Mapper = config.CreateMapper();
            AutoMapper.Mapper.Initialize(ConfigureUserMapping);
        }

        private static void ConfigureUserMapping(IProfileExpression cfg)
        {
            cfg.CreateMap<Bet, BetToDisplayGvVM>();
            cfg.CreateMap<Bet, BetToSendVM>();
            cfg.CreateMap<Tipster, TipsterGvVM>();
            cfg.CreateMap<User, UserGvVM>();
        }
    }
}
