using EasyAbp.UniappManagement.Uniapps.Dtos;
using EasyAbp.UniappManagement.UniappVersions;
using EasyAbp.UniappManagement.UniappVersions.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.AspNetCore.Mvc;

namespace EasyAbp.UniappManagement.UniappVersions
{

    [RemoteService]
    [Area("EasyAbp")]
    [ControllerName("UniappVersion")]
    [Route("api/UniappManagement/UniappVersions/UniappVersion")]
    public class UniappVersionController : AbpController, IUniappVersionAppService
    {
        protected IUniappVersionAppService AppService { get; }

        public UniappVersionController(IUniappVersionAppService userAppService)
        {
            AppService = userAppService;
        }

        [HttpGet]
        [Route("PublicLatest/{appId}")]
        public Task<UniappVersionDto> GetPublicLatestAsync(Guid appId)
        {
            return AppService.GetPublicLatestAsync(appId);
        }

        [HttpGet]
        [Route("PublicLatestByAppName")]
        public Task<UniappVersionDto> GetPublicLatestByAppNameAsync(string name)
        {
            return AppService.GetPublicLatestByAppNameAsync(name);
        }

        [HttpGet]
        [Route("Public/{appId}")]
        public Task<UniappVersionDto> GetPublicAsync(Guid appId, string tag)
        {
            return AppService.GetPublicAsync(appId, tag);
        }

        [HttpGet]
        [Route("PublicByAppName")]
        public Task<UniappVersionDto> GetPublicByAppNameAsync(string name, string tag)
        {
            return AppService.GetPublicByAppNameAsync(name, tag);
        }


        [HttpPost]
        public Task<UniappVersionDto> CreateAsync(CreateUpdateUniappVersionDto input)
        {
            return AppService.CreateAsync(input);
        }

        [HttpGet]
        [Route("{id}")]
        public Task<UniappVersionDto> GetAsync(Guid id)
        {
            return AppService.GetAsync(id);
        }

        [HttpGet]
        public Task<PagedResultDto<UniappVersionDto>> GetListAsync(UniappVersionGetListDto input)
        {
            return AppService.GetListAsync(input);
        }

        [HttpPut]
        [Route("{id}")]
        public Task<UniappVersionDto> UpdateAsync(Guid id, CreateUpdateUniappVersionDto input)
        {
            return AppService.UpdateAsync(id, input);
        }

        [HttpDelete]
        [Route("{id}")]
        public Task DeleteAsync(Guid id)
        {
            return AppService.DeleteAsync(id);
        }       

    }
    
}
