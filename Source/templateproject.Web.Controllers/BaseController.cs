using System;
using System.Collections.Generic;

namespace templateproject.Web.Controllers
{
    using System.Web.Mvc;

    public abstract class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ViewData["Title"] = GetPageTitle();
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            View("Error", new ErrorMessageViewModel(filterContext.Exception.Message)).ExecuteResult(ControllerContext);
        }

        public virtual void SetMessage(string msgId)
        {
            TempData["Message"] = MessageSource.GetMessage(msgId);
        }

        protected abstract string GetPageTitle();
    }
}