using CalculoMC.Models;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace CalculoMC.Controllers
{
    public class ValuesController : ApiController
    {

        //// POST api/Account/Register
        //[AllowAnonymous]
        //[HttpPost]
        //[Route("api/calculeMC")]
        //public async Task<IHttpActionResult> CalculeMC(CalculeMC model)
        //{
        //    if (model.Hip == 0 && model.Sex == 'M') model.Hip = 1;
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    if (model.Sex != 'F' && model.Sex != 'M') return BadRequest("El sexo debe ser M o F");
        //    var a = 86.010;
        //    var b = 70.041;
        //    var c = 36.76;
        //    var d = 495;
        //    var e = 1.0324;
        //    var f = 0.19077;
        //    var g = 0.15456;
        //    var h = 450;
        //    var rest = model.Waist - model.Neck;
        //    mTable[] tableCalifications =new mTable[5];
        //    tableCalifications[0] = new mTable { Color = "#3fa1df", Text1 = "2 - 5%", Text2 = "Esencial" };
        //    tableCalifications[1] = new mTable { Color = "#297c30", Text1 = "6 - 13%", Text2 = "Deportista" };
        //    tableCalifications[2] = new mTable { Color = "#97b531", Text1 = "14 - 17%", Text2 = "Fitness" };
        //    tableCalifications[3] = new mTable { Color = "#c2a600", Text1 = "18 - 24%", Text2 = "Aceptable" };
        //    tableCalifications[4] = new mTable { Color = "#b85622", Text1 = "25% +", Text2 = "Obeso" };
        //    if (model.Sex == 'F')
        //    {
        //        a = 163.205;
        //        b = 97.684;
        //        c = -78.387;
        //        d = 495;
        //        e = 1.29579;
        //        f = 0.35004;
        //        g = 0.22100;
        //        h = 450;
        //        tableCalifications[0] = new mTable { Color = "#3fa1df", Text1 = "10 - 13%", Text2 = "Esencial" };
        //        tableCalifications[1] = new mTable { Color = "#297c30", Text1 = "14 - 20%", Text2 = "Deportista" };
        //        tableCalifications[2] = new mTable { Color = "#97b531", Text1 = "21 - 24%", Text2 = "Fitness" };
        //        tableCalifications[3] = new mTable { Color = "#c2a600", Text1 = "25 - 31%", Text2 = "Aceptable" };
        //        tableCalifications[4] = new mTable { Color = "#b85622", Text1 = "32% +", Text2 = "Obeso" };
        //        rest = model.Waist + Convert.ToDouble(model.Hip) - model.Neck;
        //    }
        //    var BFP = a * Math.Log10(rest) - b * Math.Log10(model.Height) + c;// unidades usc
        //    var SI = (d / (e - f * Math.Log10(rest) + g * Math.Log10(model.Height))) - h; // unidades metricas
        //    var results = new { BfpSI = SI, BfpUSC = BFP, califications= tableCalifications };
        //    return Ok(results);
        //}
    }
}
