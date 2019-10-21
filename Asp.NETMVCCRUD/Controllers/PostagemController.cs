using Asp.NETMVCCRUD.Models;
using Asp.NETMVCCRUD.service;
using Asp.NETMVCCRUD.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.NETMVCCRUD.Controllers
{
    public class PostagemController : Controller
    {

        private AtividadeService service = new AtividadeService();

        // GET: Postagem
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {


            List<AtividadeDAO> empList = service.getListDAO();
            return Json(new { data = empList }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Enviar(int id)
        {

            Atividade atv = service.find(id);
            
            if(atv.DataLimite > DateTime.Now)
            {
               
                return Json(new { success = true, message = "Enviado" }, JsonRequestBehavior.AllowGet);
            }

            return Json(new { success = true, message = "Fora do Prazo" }, JsonRequestBehavior.AllowGet);

        }
    }
}