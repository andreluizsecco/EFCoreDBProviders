using EFCoreDBProviders.Context;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreDBProviders.Controllers
{
    public class SqlServerController : BaseController
    {
        public SqlServerController([FromServices]LivrosSqlServerContext context) : base(context) { }
    }
}