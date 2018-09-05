/*
 * home
 *
 * The API for the Home Starter project
 *
 * OpenAPI spec version: 1.0.3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using IO.Swagger.Attributes;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class ZWaveApiController : Controller
    { 
        /// <summary>
        /// 
        /// </summary>
        
        /// <response code="200">ok</response>
        [HttpGet]
        [Route("/motta/home/1.0.3/lightingSummary")]
        [ValidateModelState]
        [SwaggerOperation("GetLightingSummary")]
        [SwaggerResponse(200, typeof(LightingSummary), "ok")]
        public virtual IActionResult GetLightingSummary()
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<LightingSummary>(exampleJson)
            : default(LightingSummary);
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="deviceId"></param>
        /// <response code="200">response</response>
        [HttpGet]
        [Route("/motta/home/1.0.3/lighting/switches/{deviceId}")]
        [ValidateModelState]
        [SwaggerOperation("GetSwitchState")]
        [SwaggerResponse(200, typeof(DeviceState), "response")]
        public virtual IActionResult GetSwitchState([FromRoute]string deviceId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<DeviceState>(exampleJson)
            : default(DeviceState);
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="deviceId"></param>
        /// <param name="value"></param>
        /// <response code="200">response</response>
        [HttpPost]
        [Route("/motta/home/1.0.3/lighting/dimmers/{deviceId}/{value}")]
        [ValidateModelState]
        [SwaggerOperation("SetDimmer")]
        [SwaggerResponse(200, typeof(ApiResponse), "response")]
        public virtual IActionResult SetDimmer([FromRoute]string deviceId, [FromRoute]int? value)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ApiResponse>(exampleJson)
            : default(ApiResponse);
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>sets a dimmer to a specific value on a timer</remarks>
        /// <param name="deviceId"></param>
        /// <param name="value"></param>
        /// <param name="timeunit"></param>
        /// <param name="units"></param>
        /// <response code="200">response</response>
        [HttpPost]
        [Route("/motta/home/1.0.3/lighting/dimmers/{deviceId}/{value}/timer/{timeunit}")]
        [ValidateModelState]
        [SwaggerOperation("SetDimmerTimer")]
        [SwaggerResponse(200, typeof(ApiResponse), "response")]
        public virtual IActionResult SetDimmerTimer([FromRoute]string deviceId, [FromRoute]int? value, [FromRoute]int? timeunit, [FromQuery]string units)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ApiResponse>(exampleJson)
            : default(ApiResponse);
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="deviceId"></param>
        /// <param name="value"></param>
        /// <response code="200">response</response>
        [HttpPost]
        [Route("/motta/home/1.0.3/lighting/switches/{deviceId}/{value}")]
        [ValidateModelState]
        [SwaggerOperation("SetSwitch")]
        [SwaggerResponse(200, typeof(ApiResponse), "response")]
        public virtual IActionResult SetSwitch([FromRoute]string deviceId, [FromRoute]string value)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ApiResponse>(exampleJson)
            : default(ApiResponse);
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>sets a switch to a specific value on a timer</remarks>
        /// <param name="deviceId"></param>
        /// <param name="value"></param>
        /// <param name="minutes"></param>
        /// <response code="200">response</response>
        [HttpPost]
        [Route("/motta/home/1.0.3/lighting/switches/{deviceId}/{value}/timer/{minutes}")]
        [ValidateModelState]
        [SwaggerOperation("SetSwitchTimer")]
        [SwaggerResponse(200, typeof(ApiResponse), "response")]
        public virtual IActionResult SetSwitchTimer([FromRoute]string deviceId, [FromRoute]string value, [FromRoute]int? minutes)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ApiResponse>(exampleJson)
            : default(ApiResponse);
            return new ObjectResult(example);
        }
    }
}
