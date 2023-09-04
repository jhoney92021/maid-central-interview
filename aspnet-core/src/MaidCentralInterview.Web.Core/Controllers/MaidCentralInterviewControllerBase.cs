using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MaidCentralInterview.Controllers
{
    public abstract class MaidCentralInterviewControllerBase: AbpController
    {
        protected MaidCentralInterviewControllerBase()
        {
            LocalizationSourceName = MaidCentralInterviewConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
