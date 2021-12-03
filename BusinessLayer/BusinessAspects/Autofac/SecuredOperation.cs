using System;
using System.Collections.Generic;
using System.Linq;
using Castle.DynamicProxy;
using CoreLayer.Extensions;
using CoreLayer.Utilities.Interceptors;
using CoreLayer.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Business.BusinessAspects.Autofac
{

    public class SecuredOperation : MethodInterception
    {
        private List<string> _roles;
        private IHttpContextAccessor _httpContextAccessor;

        public SecuredOperation(string roles)
        {
            _roles = roles.Split(',').ToList();
            _roles.Add("admin");
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();
        }

        protected override void OnBefore(IInvocation invocation)
        {
            //return;
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
            _httpContextAccessor.HttpContext.User.ClaimRoles();
            if (_roles.Any(role => roleClaims.Contains(role)))
            {
                return;
            }
            throw new Exception("Yetkiniz Yok");
        }
    }
}