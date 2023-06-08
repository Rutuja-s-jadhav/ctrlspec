using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ctrlspec.Models;
using ctrlspec.Data;
using Microsoft.EntityFrameworkCore;
using ctrlspec.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ctrlspec.Repos
{
    public class EquipmentRepo : IEquipment
    {


        private readonly CtrlSpecDbContext context;

        public EquipmentRepo(CtrlSpecDbContext context)
        {
            this.context = context;
        }

        #region AddEquipmentDetails
        public async Task<Equipment> AddEquipmentDetails(Equipment equip)
        {
            try
            {
                  
                await context.AddAsync(equip);
                await context.SaveChangesAsync();
                return equip;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region GetEquipmentID   
        public async Task<Equipment> GetEquipment(double equipID,double p_num)
        {
            try
            {
                return await context.equipment.FirstOrDefaultAsync(x => x.EquipmentID == equipID &&  x.ProjectNumber == p_num);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Equipment>> GetAllEquipment()
        {
            try
            {
                return await context.equipment.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        // public async Task<Equipment> GetallEquipment()
        // {
        //     try
        //     {
        //         return await context.equipment.ToList();
        //     }
        //     catch (Exception)
        //     {
        //         throw;
        //     }
        // }
        
        // public async Task<Equipment> GetProjectNum( double p_num)
        // {
        //     try
        //     {
        //         return await context.equipment.FirstOrDefaultAsync(x => x.ProjectNumber == p_num);
        //     }
        //     catch (Exception)
        //     {
        //         throw;
        //     }
        // }

       
        
        
        //    public async Task<Exhaust_Fan> AddExhaustFanDetails(Exhaust_Fan equip)
       public  async Task<Exhaust_Fan> AddExhaustFanDetails(Exhaust_Fan equip)
        {
           try
            {
             
               
                // var q= (from x in context.equipment 
                // join y in context.exhaust_Fans on x.EquipmentID equals y.EquipmentID
                // select new
                // {
                //    y.DamperControl,
                //    x.RunConditions,
                //    x.Fan,
                //    x.FilterMonitoring,
                //    x.MiscMonitoring

                // }).FirstOrDefault();
                
            
               

                await context.AddAsync(equip);
                await context.SaveChangesAsync();
                return equip;
                
            }
            catch (Exception)
            {
                throw;
            }
        }

           public async Task<Room_Units> AddRoomUnitsDetails(Room_Units equipId)
        {
           try
            {

                await context.AddAsync(equipId);
                await context.SaveChangesAsync();
                return equipId;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Unitary_Heat>  AddUnitaryHeatDetails(Unitary_Heat equipId)
        {
           try
            {

                await context.AddAsync(equipId);
                await context.SaveChangesAsync();
                return equipId;
            }
            catch (Exception)
            {
                throw;
            }
        }
           
           public async Task<Equipment> DeleteEquipment(Equipment equip)
           {
           // var equip = context.equipment.Find(x => x.EquipmentID == equipID);
           context.Remove(equip);
            context.SaveChanges();
             return (equip);
           }
          
        
       
    }
        // public Task<Room_Units> GetRU(double equipID)
        // {
        // //    var _runConditions=context.equipment.Where(x => x.EquipmentID == equipID).Select(y => y.RunConditions).FirstOrDefault();
        // //    var _fan=context.equipment.Where(x => x.EquipmentID == equipID).Select(y => y.Fan).FirstOrDefault();
        // //    var _fM=context.equipment.Where(x => x.EquipmentID == equipID).Select(y => y.FilterMonitoring).FirstOrDefault();
        // //    var _mM=context.equipment.Where(x => x.EquipmentID == equipID).Select(y => y.MiscMonitoring).FirstOrDefault();

    
        //  var _zC= context.room_Units.Where(x => x.EquipmentID == equipID).Select(y => y.ZoneControl && y.FaceBypassDamper && y.Cooling && y.Heating && y.HeatingHighDischargeLimit && y.MixedAirDamper && y.MinimunOutsideAir && y.EnvironmentalIndex).FirstOrDefault();
        // //    var _safeties=context.room_Units.Where(x => x.EquipmentID == equipID).Select(y => y.Safeties).FirstOrDefault();
        // //    var _fbd=context.room_Units.Where(x => x.EquipmentID == equipID).Select(y => y.FaceBypassDamper).FirstOrDefault();
        // //    var _cooling=context.room_Units.Where(x => x.EquipmentID == equipID).Select(y => y.Cooling).FirstOrDefault();
        // //    var _heating=context.room_Units.Where(x => x.EquipmentID == equipID).Select(y => y.Heating).FirstOrDefault();
        // //    var _hhdl=context.room_Units.Where(x => x.EquipmentID == equipID).Select(y => y.HeatingHighDischargeLimit).FirstOrDefault();
        // //    var _mad=context.room_Units.Where(x => x.EquipmentID == equipID).Select(y => y.MixedAirDamper).FirstOrDefault();
        // //    var _moa=context.room_Units.Where(x => x.EquipmentID == equipID).Select(y => y.MinimunOutsideAir).FirstOrDefault();
        // //    var _envtInd=context.room_Units.Where(x => x.EquipmentID == equipID).Select(y => y.EnvironmentalIndex).FirstOrDefault();
           
        // //    Equipment e=new Equipment()
        // //    {
        // //      EquipmentID=equipID,
        // //     //  RunConditions=runConditions,
        // //     //  Fan=fan,
        // //     //  FilterMonitoring=fM,
        // //     //  MiscMonitoring=mM,

        // //    };
        // //    string[] s= {runConditions,fan,fM,mM,zC,safeties,fbd,cooling,heating,hhdl,mad,moa,envtInd};
        // //     List<string> list = s.ToList();
            
        //    context.equipment.Add(equipID);
        //    context.SaveChanges();
          

            // return (IActionResult)list;
        }
     
 #endregion
    