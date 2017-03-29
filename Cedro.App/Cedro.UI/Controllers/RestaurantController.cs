using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cedro.Application.Interfaces;
using Cedro.Domain.Entities;
using Cedro.UI.Models;
using Cedro.UI.ResultApi;

namespace Cedro.UI.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IRestaurantAppService _restaurantAppService;

        public RestaurantController(IRestaurantAppService restaurantAppService)
        {
            _restaurantAppService = restaurantAppService;
        }
        // GET: Restaurant
        public JsonResult Index()
        {

            IList<RestaurantListViewModel> z = _restaurantAppService.Get().Select(x => new RestaurantListViewModel()
            {
                Name = x.Name,
                Id = x.RestaurantId
            }).ToList();
            var resp = new ResultApiBuilder<RestaurantListViewModel>().List(z).Build();
            return Json(resp, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetById(int id){

            var obj = _restaurantAppService.GetById(id);
            var resp = new ResultApiBuilder<Restaurant>().Single(new Restaurant()
            {
                Name = obj.Name,
                RestaurantId = obj.RestaurantId
               
            })
        .Build();
            return Json(resp, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult Add(RestaurantRegisterViewModel model)
        {
            var result = new ResultApiBuilder<Restaurant>();
            try
            {
                _restaurantAppService.Add(new Restaurant() {Name = model.Name});
                return Json(result.SetMessage("Restaurante adicionado com sucesso!").Build(), JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(result.Error("Falha ao adicionar restaurante: "+ e.Message).Build(), JsonRequestBehavior.AllowGet); ;
            }
        }
        [HttpPost]
        public JsonResult Update(RestaurantEditViewModel model)
        {
            var result = new ResultApiBuilder<Restaurant>();
            try
            {
                var obj = _restaurantAppService.GetById(model.Id);
                obj.Name = model.Name;
                _restaurantAppService.Update(obj);

                return Json(result.SetMessage("Restaurante alterado com sucesso!").Build(), JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(result.Error("Falha ao adicionar o Restaurante: " + e.Message).Build(), JsonRequestBehavior.AllowGet); ;
            }
        }
        [HttpGet]
        public JsonResult Remove(int id)
        {
            var result = new ResultApiBuilder<Restaurant>();
            try
            {
                var obj = _restaurantAppService.GetById(id);
                _restaurantAppService.Remove(obj);

                return Json(result.SetMessage("Restaurante removido com sucesso!").Build(), JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(result.Error("Falha ao remover o Restaurante: " + e.Message).Build(), JsonRequestBehavior.AllowGet); ;
            }
        }
    }


}