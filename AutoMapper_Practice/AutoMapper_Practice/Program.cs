using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using AutoMapper.Mappers;
using AutoMapper_Practice.Dtos;
using AutoMapper_Practice.Models;
using AutoMapper;


namespace AutoMapper_Practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();
            MapAsingValueSource();

        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        public static void Map()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AuthorModel, AuthorDTO>();
            });

            IMapper iMapper = config.CreateMapper();
            var source = new AuthorModel(); var destination = iMapper.Map<AuthorModel, AuthorDTO>(source);

        }

        public static void MapAsingValueSource()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AuthorModel, AuthorDTO>();
            });
            IMapper iMapper = config.CreateMapper();
            var source = new AuthorModel();
            source.Id = 1;
            source.FirstName = "Joydip";
            source.LastName = "Kanjilal";
            source.Address.City = "India";
            var destination = iMapper.Map<AuthorModel, AuthorDTO>(source);
            Console.WriteLine("Author Name: " + destination.FirstName + " " + destination.LastName);
        }

        public static void MapDistinctNameProperties()
        {

            var config = new MapperConfiguration(cfg =>
           {
               cfg.CreateMap<AuthorModel, AuthorDTO>()
               .ForMember(destination => destination.Address, opts => opts.MapFrom(source => source.Address));
           });

        }
        public static void MaptoOneToMuch()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AuthorModel, AuthorDTO>()
                .ForMember(destination => destination.Address, map =>
                map.MapFrom(
                    source => new Address
                    {
                        City = source.Address.City,
                        State = source.Address.State,
                        Country = source.Address.Country
                    }
                ));
            });
        }
    }
}
