using AngleSharp.Dom.Events;
using AutoMapper;
using ScreenProject.Models;
using ScreenProject.ViewModles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event = ScreenProject.Models.Event;

namespace ScreenProject
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {

            CreateMap<Event, EventViewModles>().ForMember(c => c.BackGround, map => map.MapFrom(c => c.MyTemplate.BackGroundImg));
           
            CreateMap<Template, TemplateViewModles>().ReverseMap();
            CreateMap<TemplateField, TemplateFieldViewModles>().ForMember(c => c.FontWeight, map => map.MapFrom(c => c.FontWeight
            )).ForMember(c => c.FontStyle, map => map.MapFrom(c => c.FontStyle
            )).ForMember(c => c.FontFamily, map => map.MapFrom(c => c.FontFamily
            )).ForMember(c => c.FontColor, map => map.MapFrom(c => c.FontColor
            ));
            CreateMap<EventField, EventFieldViewModles>().ForMember(c => c.Value, map => map.MapFrom(c => c.Value)).ReverseMap();
            CreateMap<EventField, EventListViewModle>().ForMember(c => c.FontColor, map => map.MapFrom(c => c.MyTemplateField.FontColor)).ForMember(c => c.FontFamily, map => map.MapFrom(c => c.MyTemplateField.FontFamily)).ReverseMap();


        }
    }
}
