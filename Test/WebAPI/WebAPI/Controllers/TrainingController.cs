using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class TrainingController : ApiController
    {
        private DBModel db = new DBModel();

        // GET: api/Training
        public IQueryable<Training> GetTrainings()
        {
            return db.Trainings;
        }

        // PUT: api/Training/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTraining(int id, Training training)
        {
            if (id != training.TrainingID)
            {
                return BadRequest();
            }

            db.Entry(training).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrainingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Training
        [ResponseType(typeof(Training))]
        public IHttpActionResult PostTraining(Training training)
        {
            db.Trainings.Add(training);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = training.TrainingID }, training);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TrainingExists(int id)
        {
            return db.Trainings.Count(e => e.TrainingID == id) > 0;
        }
    }
}