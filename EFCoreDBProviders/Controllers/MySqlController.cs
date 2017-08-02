using EFCoreDBProviders.Context;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreDBProviders.Controllers
{
    public class MySqlController : BaseController
    {
        public MySqlController([FromServices]LivrosMySqlContext context) : base(context) { }
    }
}