namespace AcmeCorp.AspNetBuildSample.Web.UI.Controllers
{
    using System.Web.Mvc;

    using Microsoft.Web.WebPages.OAuth;

    internal class ExternalLoginResult : ActionResult
    {
        public ExternalLoginResult(string provider, string returnUrl)
        {
            this.Provider = provider;
            this.ReturnUrl = returnUrl;
        }

        public string Provider { get; private set; }

        public string ReturnUrl { get; private set; }

        public override void ExecuteResult(ControllerContext context)
        {
            OAuthWebSecurity.RequestAuthentication(this.Provider, this.ReturnUrl);
        }
    }
}