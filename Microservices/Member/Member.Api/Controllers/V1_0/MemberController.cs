using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;
//using AutoMapper;
//using MediatR;
//using Member.DTOs.Member.Add.Requests;
//using Member.DTOs.Member.Edit.Requests;
//using Member.DTOs.Member.Get.Requests;
//using Member.DTOs.Member.Get.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Member.Api.Controllers.V1_0
{
    [ApiController]
    [Route("[controller]")]
    public class MemberController : ControllerBase
    {
        private readonly ILogger<MemberController> _logger;

        public MemberController(ILogger<MemberController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public bool Get()
        {
            return true;
        }
    }
}
