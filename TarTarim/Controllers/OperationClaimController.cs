using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.BusinessAspects.Autofac;
using BusinessLayer.Abstract;
using CoreLayer.Entities.Concrete;
using CoreLayer.Extensions;
using CoreLayer.Utilities.Results;

namespace TarTarim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationClaimController : ControllerBase
    {
        private IOperationClaimService _operationClaimService;

        public OperationClaimController(IOperationClaimService operationClaimService)
        {
            _operationClaimService = operationClaimService;
        }

        [HttpGet("getoprationclaims")]
        public IActionResult Get()
        {
            var user = User;
            var claims = user.ClaimRoles().Contains("admin");
            return Ok(new SuccessDataResult<IEnumerable<OperationClaim>>(_operationClaimService.GetAll().Data
                .Where(o => o.Status == claims ||!o.Status)));
        }
    }
}
