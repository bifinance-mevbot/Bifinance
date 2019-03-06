using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bifinance.Controllers.Api
{
    [AllowAnonymous]
    public class ArrayCalcController : Controller
    {
        [Route("API/ARRAYCALC/REVERSE")]
        [HttpGet]
        public List<int> Reverse([FromQuery] List<int> productIds)
        {
            List<int> results = new List<int>() { };
            for(int i= productIds.Count-1; i >=0 ; i--)
            {
                results.Add(productIds[i]);
            }
            return results;
        }

        [Route("API/ARRAYCALC/DELETEPART")]
        [HttpGet]
        public List<int> DeletePart([FromQuery]int position,[FromQuery] List<int> productIds)
        {
            List<int> results = new List<int>() { };
            for (int i = 0; i < productIds.Count ; i++)
            {
                if(i != (position-1)) results.Add(productIds[i]);
            }
            return results;
        }
    }
}
