using EasyAbp.UniappManagement.Uniapps.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace EasyAbp.UniappManagement.Uniapps
{
    [RemoteService]
    [Area("EasyAbp")]
    [ControllerName("Uniapp")]
    [Route("api/UniappManagement/Uniapps/Uniapp")]
    public class UniappController : AbpController, IUniappAppService
    {
        protected IUniappAppService AppService { get; }

        public UniappController(IUniappAppService userAppService)
        {
            AppService = userAppService;
        }

        [HttpPost]
        public Task<UniappDto> CreateAsync(CreateUpdateUniappDto input)
        {
            return AppService.CreateAsync(input);
        }

        [HttpGet]
        [Route("{id}")]
        public Task<UniappDto> GetAsync(Guid id)
        {
            return AppService.GetAsync(id);
        }

        [HttpGet]
        public Task<PagedResultDto<UniappDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            return AppService.GetListAsync(input);
        }

        [HttpPut]
        [Route("{id}")]
        public Task<UniappDto> UpdateAsync(Guid id, CreateUpdateUniappDto input)
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
