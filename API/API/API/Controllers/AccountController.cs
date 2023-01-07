using Microsoft.AspNetCore.Mvc;
using API.Models;
using System.Linq;

namespace API.Controllers
{
    [ApiController]
    public class AccountController : Controller
    {
        APIContext db = new APIContext();
        [Route("add_account")]
        [HttpPost]
        public void Add_Product([FromBody] Account sp)
        {
            try
            {
                db.Account.Add(sp);
                db.SaveChanges();
            }
            catch (System.Exception e)
            {

                throw e;
            }
        }
        [Route("update_product")]
        [HttpPut]
        public void Update_Product([FromBody] Account sp)
        {
            try
            {
                db.Account.Update(sp);
                db.SaveChanges();
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
        [Route("delete_product")]
        [HttpDelete]
        public void Delete_Product(int Masp)
        {
            Account sp = db.Account.FirstOrDefault(x => x.MaTaiKhoan == Masp);
            try
            {
                db.Account.Remove(sp);
                db.SaveChanges();
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
    }
}
