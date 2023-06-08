using AutoMapper;
using ctrlspec.Models;
using ctrlspec.DTO;

namespace ctrlspec.Profiles
{
    public class AutomapperProfile:Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Equipment,EquipmentDTO>()
            .ReverseMap();
        
            // CreateMap<EquipmentDTO,Equipment>()
            // .ReverseMap();

             CreateMap<AddEquipmentDTO,Equipment>()
            .ReverseMap();

            CreateMap<ExhaustFanDTO,Exhaust_Fan>()
            .ReverseMap();

             CreateMap<RoomUnitsDTO,Room_Units>()
            .ReverseMap();

            CreateMap<UnitaryHeatDTO,Unitary_Heat>()
            .ReverseMap();
        }
    }
}