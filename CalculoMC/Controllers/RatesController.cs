using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using CalculoMC.Models;
using DataAccess;

namespace CalculoMC.Controllers
{
    public class RatesController : ApiController
    {
        private Entities db = new Entities();

        // POST api/calculeMC
        [AllowAnonymous]
        [HttpPost]
        [Route("api/calculeMC")]
        public async Task<IHttpActionResult> CalculeMC(CalculeMC model)
        {
            if (model.Hip == 0 && model.Sex == 'M') model.Hip = 1;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (model.Sex != 'F' && model.Sex != 'M') return BadRequest("El sexo debe ser M o F");
            var a = 86.010;
            var b = 70.041;
            var c = 36.76;
            var d = 495;
            var e = 1.0324;
            var f = 0.19077;
            var g = 0.15456;
            var h = 450;
            var rest = model.Waist - model.Neck;
            var sex = model.Sex.ToString();
            var tableCalifications = await db.Rate.Where((x) => x.Sex ==sex ).OrderBy(y=>y.Orden).ToListAsync();
            if (model.Sex == 'F')
            {
                a = 163.205;
                b = 97.684;
                c = -78.387;
                d = 495;
                e = 1.29579;
                f = 0.35004;
                g = 0.22100;
                h = 450;
                rest = model.Waist + Convert.ToDouble(model.Hip) - model.Neck;
            }
            var BFP = a * Math.Log10(rest) - b * Math.Log10(model.Height) + c;// unidades usc
            var SI = (d / (e - f * Math.Log10(rest) + g * Math.Log10(model.Height))) - h; // unidades metricas
            var results = new { BfpSI = SI, BfpUSC = BFP, califications = tableCalifications };
            return Ok(results);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RateExists(int id)
        {
            return db.Rate.Count(e => e.Id == id) > 0;
        }
    }
}