using EFCoreDBProviders.Context;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreDBProviders.Controllers
{
    public class PostgreSqlController : BaseController
    {
        public PostgreSqlController([FromServices]LivrosPostgresContext context) : base(context) { }
    }
}