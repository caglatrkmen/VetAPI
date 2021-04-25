using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinerAPI.Data;
using VeterinerAPI.Entities;

namespace VeterinerAPI.Controllers
{
   
    [Route("api/patients")]
    public class PatientsController:Controller
    { 

         IPatientsDal _patientsDal;

    public PatientsController(IPatientsDal patientsDal)
    {
            _patientsDal = patientsDal;
    }
        [HttpGet] 
        public IActionResult Get()
        {
            var patients = _patientsDal.GetList();
            return Ok(patients);
        }

        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            try { 

            var patients = _patientsDal.Get(p=>p.Id==Id);
            
            if (patients == null)
             {
                    return NotFound($"There is no patient with id {Id}");
             }
                return Ok(patients);
            }
            catch
            {

            }

            return BadRequest();
        }

        [HttpPost]
        public IActionResult Post(Patients patients)
        {
            try {

                _patientsDal.Add(patients);
                return new StatusCodeResult(201);
               
            }
            catch
            {

            }

            return BadRequest();
        }

        [HttpPut]
        public IActionResult Put(Patients patients)
        {
            try
            {

                _patientsDal.Update(patients);
                return Ok(patients);

            }
            catch
            {

            }

            return BadRequest();
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            try
            {

                _patientsDal.Delete(new Patients {Id = Id});
                return Ok();

            }
            catch
            {

            }

            return BadRequest();
        }
    }
    }
