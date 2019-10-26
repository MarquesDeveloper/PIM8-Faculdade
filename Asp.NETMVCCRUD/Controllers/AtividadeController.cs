using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Asp.NETMVCCRUD.Models;
using System.Data.Entity;
using Asp.NETMVCCRUD.service;
using Asp.NETMVCCRUD.dto;

namespace Asp.NETMVCCRUD.Controllers
{
    public class AtividadeController : Controller
    {

        private AtividadeService service = new AtividadeService();

        //
        // GET: /Atividade/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
            DateTime time = DateTime.Now;

            time.ToString();

            List<AtividadeDTO> empList = service.getListDTO();
            return Json(new { data = empList }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Atividade());
            else
            {
                    Atividade model = service.find(id);
                    return View(Json(new { data = model }));
                
            }
        }

        [HttpPost]
        public ActionResult AddOrEdit(Atividade atividade)
        {
            
            
                if (atividade.Id == 0)
                {
                     service.save(atividade);
                  
                    return Json(new { success = true, message = "Salvo" }, JsonRequestBehavior.AllowGet);
                }
                else {
                     service.update(atividade);
                    return Json(new { success = true, message = "Atualizado" }, JsonRequestBehavior.AllowGet);
                }
            


        }

        [HttpPost]
        public ActionResult Enivar(int id)
        {

                 service.delete(id);
               
                return Json(new { success = true, message = "Apagado" }, JsonRequestBehavior.AllowGet);
            
        }
    }
}