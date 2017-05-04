using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace KnowledgeTest
{
    public class CustomControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType != null
                ? (IController)AutofacDependencyResolver.Current.RequestLifetimeScope.Resolve(controllerType)
                : null;
        }
    }
}