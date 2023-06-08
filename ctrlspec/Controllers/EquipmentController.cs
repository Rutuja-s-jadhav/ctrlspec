using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ctrlspec.Models;
using ctrlspec.Repos;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using AutoMapper;
using ctrlspec.DTO;
using ctrlspec.Data;

namespace ctrlspec.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EquipmentController : ControllerBase
    {
        private IEquipment _equipment;
        private readonly IMapper _mapper;

       private CtrlSpecDbContext context;

        public EquipmentController(IEquipment equipment, IMapper mapper,CtrlSpecDbContext context)
        {
            _equipment = equipment;
            _mapper = mapper;
            context=context;
             
        }
        [HttpPost]
        [Route("AddEquipment")]
        public async Task<IActionResult> AddEquipment(AddEquipmentDTO equip)
        {

            var equipment = _mapper.Map<Equipment>(equip);
            var response = await _equipment.AddEquipmentDetails(equipment);
            var equipDTO = _mapper.Map<AddEquipmentDTO>(response);
            return Ok(equipDTO);
        }

        // if (equip != null)
        // {
        //     return Ok(equipDTO);

        // }

        // else if (equip != equip)

        // {

        //     return Ok("Already Exists");

        // }

        // return Ok(equip);


        [HttpGet]

        public async Task<IActionResult> GetEquipment(double equipID, double p_num)
        {

            try
            {
                var result = await _equipment.GetEquipment(equipID, p_num);
                if (result == null)
                {
                    return NotFound();
                }


                return Ok(_mapper.Map<EquipmentDTO>(result));
            }
            catch (Exception e)
            {
                return BadRequest("Error in Controller method GetEmployee by data" + e);
            }

        }

        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetEquipment()
        {
            try
            {
                var data = await _equipment.GetAllEquipment();
                return Ok(_mapper.Map<List<DTO.AddEquipmentDTO>>(data));
            }
            catch (Exception e) {
                return BadRequest("Error in Controller method GetEmployee"+ e);
            }
        }



        // [HttpGet]

        // public async Task<Equipment> GetallEquipment()
        // {

        //     try
        //     {
        //         var result = await _equipment.GetallEquipment();
        //         if (result == null)
        //         {
        //             return NotFound();
        //         }


        //         return Ok(result);
        //     }
        //     catch (Exception e)
        //     {
        //         return BadRequest("Error in Controller method GetEmployee by data" + e);
        //     }

        //}

        // [HttpGet]
        // [Route("ProjectNumber")]
        // public async Task<IActionResult> GetPNumber(double p_num)
        // {

        //     try
        //     {
        //         var result = await _equipment.GetProjectNum(p_num);
        //         if (result == null)
        //         {
        //             return NotFound();
        //         }


        //         return Ok(result);
        //     }
        //     catch(Exception e)
        //     {
        //         return BadRequest("Error in Controller method GetEmployee by data"+ e);
        //     }
        // }
        [HttpPost]

        [Route("AddExFanDetails")]
        public async Task<IActionResult> AddExFanDetails(ExhaustFanDTO equipId)
        {

            var exFan = _mapper.Map<Exhaust_Fan>(equipId);
            var response = await _equipment.AddExhaustFanDetails(exFan);
            var exhaustDTO = _mapper.Map<ExhaustFanDTO>(response);
            return Ok(exhaustDTO);





            //  await _equipment.AddExhaustFanDetails(equipId);

            if (equipId != null)
            {
                return Ok("Success");

            }

            else if (equipId != equipId)

            {

                return Ok("Already Exists");

            }

            return Ok(equipId);
        }



        [HttpPost]
        [Route("AddRUDetails")]
        public async Task<IActionResult> AddRUDetails(RoomUnitsDTO equipId)
        {
            var rU = _mapper.Map<Room_Units>(equipId);
            var response = await _equipment.AddRoomUnitsDetails(rU);
            var roomUnitsDTO = _mapper.Map<RoomUnitsDTO>(response);
            return Ok(roomUnitsDTO);

            if (equipId != null)
            {
                return Ok("Success");

            }

            else if (equipId != equipId)

            {

                return Ok("Already Exists");

            }

            return Ok(equipId);
        }

        [HttpPost]
        [Route("UHDetails")]
        public async Task<IActionResult> AddUHDetails(UnitaryHeatDTO equipId)
        {
            var unitaryHeat = _mapper.Map<Unitary_Heat>(equipId);
            var response = await _equipment.AddUnitaryHeatDetails(unitaryHeat);
            var unitaryHeatDTO = _mapper.Map<UnitaryHeatDTO>(response);
            return Ok(unitaryHeatDTO);

            if (equipId != null)
            {
                return Ok("Success");

            }

            else if (equipId != equipId)

            {

                return Ok("Already Exists");

            }

            return Ok(equipId);
        }

        // [HttpDelete]
        // public async Task<IActionResult> DeleteEquip(double equipID,double p_num,Equipment equipment)
        // {

        //     var equip = await _equipment.DeleteEquipment(equipID,p_num,equipment);
        //     if (equip == null)
        //     {
        //         return NoContent();
        //     }
        //     return Ok();

        // }


        //     [HttpDelete]
        //     [Route("{id}")]
        //   //  [Authorize]
        //     public IActionResult DeleteEquipment(int id)
        //     {
        //         var deleteBooking = _equipment.equipment.Where(x => x.BookingId == id).Select(p => p.EquipmentID).FirstOrDefault();
        //         var p = _equipment.equipment.Find(deleteBooking);

        //         if (p != null)
        //         {
        //             _equipment.equipment.Remove(p);

        //             _equipment.SaveChanges();

        //             return Ok();
        //         }

        //         return BadRequest();
        //     }



       

       

        [HttpDelete]

        public async Task<IActionResult> DeleteEquipment(double equipID, double p_num)

        {

            try

            {

                var equip = await _equipment.GetEquipment(equipID, p_num);

                if (equip == null)

                {


                    return NotFound();

                }



                await _equipment.DeleteEquipment(equip);





                return Ok(" Equipment Successfully Deleted ");

            }

            catch (Exception)

            {


                return BadRequest("Something went wrong");

            }

        }
    //     [HttpGet]
        
    //     public IActionResult GetRoomUnits(double equipID)
    // {
    //     var _zC= context.room_Units.Where(x => x.EquipmentID == equipID).Select(y => y.ZoneControl && y.FaceBypassDamper && y.Cooling && y.Heating && y.HeatingHighDischargeLimit && y.MixedAirDamper && y.MinimunOutsideAir && y.EnvironmentalIndex).FirstOrDefault();
    // }
        
  
    }
}