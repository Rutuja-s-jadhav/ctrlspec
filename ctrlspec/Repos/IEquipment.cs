using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ctrlspec.Models;
using ctrlspec.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ctrlspec.Repos
{
    public interface IEquipment
    {
        Task<Equipment> AddEquipmentDetails(Equipment equipID);

      //  Task<Equipment> AddEquipmentByID(double equipID);
         Task<Equipment> GetEquipment(double equipID,double p_num);

         Task<IEnumerable<Equipment>> GetAllEquipment();

        //  Task<Equipment> GetallEquipment();
     
         Task<Exhaust_Fan> AddExhaustFanDetails(Exhaust_Fan equip);

        //    Task<IEnumerable<Exhaust_Fan>> AddExhaustFanDetails(Exhaust_Fan equip);

         Task<Room_Units> AddRoomUnitsDetails(Room_Units equipId);

         Task<Unitary_Heat> AddUnitaryHeatDetails(Unitary_Heat equipId);

        Task<Equipment> DeleteEquipment(Equipment equipment);

    //    Task<Room_Units> GetRU(double equipID);


    }
}