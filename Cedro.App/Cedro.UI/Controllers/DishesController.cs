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
    public class DishesController : Controller
    {
        private readonly IDishAppService _dishAppService;
        private readonly IRestaurantAppService _restaurantAppService;
        public DishesController(IDishAppService dishAppService, IRestaurantAppService restaurantAppService)
        {
            _dishAppService = dishAppService;
            _restaurantAppService = restaurantAppService;
        }
        // GET: Dishes
  
        public JsonResult Index()
        {
            var result = new ResultApiBuilder<Dish>();
            try
            {
                IList<DishListViewModel> z = _dishAppService.Get().Select(x => new DishListViewModel()
                {
                    Name = x.Name,
                    Price = x.Price,
                    RestaurantName= x.Restaurant.Name,
                    DishId = x.DishId
                    

                }).ToList();
                var resp = new ResultApiBuilder<DishListViewModel>().List(z).Build();
                return Json(resp, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {

                return Json(result.Error("Falha ao listar os prato: " + e.Message).Build(), JsonRequestBehavior.AllowGet); ;
            }
   

        }


        public JsonResult Add(DishRegisterViewModel model)
        {
            var result = new ResultApiBuilder<Dish>();
            try
            {
                //var r = _restaurantAppService.GetById(model.RestaurantId);
                
                _dishAppService.Add(new Dish() { Name = model.Name, Price = model.Price,RestaurantId = model.RestaurantId });
                return Json(result.SetMessage("Prato adicionado com sucesso!").Build(), JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(result.Error("Falha ao adicionar prato: " + e.Message).Build(), JsonRequestBehavior.AllowGet); ;
            }
        }

        public JsonResult Update(DishEditViewModel model)
        {
            var result = new ResultApiBuilder<Dish>();
            try
            {
                var obj = _dishAppService.GetById(model.DishId);
                obj.Name = model.Name;
                obj.Price = model.Price;
                _dishAppService.Update(obj);

                return Json(result.SetMessage("Prato alterado com sucesso!").Build(), JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(result.Error("Falha ao adicionar o prato: " + e.Message).Build(), JsonRequestBehavior.AllowGet); ;
            }
        }

        [HttpGet]
        public JsonResult Remove(int id)
        {
            var result = new ResultApiBuilder<Dish>();
            try
            {
                var obj = _dishAppService.GetById(id);
                _dishAppService.Remove(obj);

                return Json(result.SetMessage("Prato removido com sucesso!").Build(), JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(result.Error("Falha ao remover o prato: " + e.Message).Build(), JsonRequestBehavior.AllowGet); ;
            }
        }


        public JsonResult GetById(int id)
        {

            var obj = _dishAppService.GetById(id);
            var resp = new ResultApiBuilder<Dish>().Single(new Dish()
            {
                Name = obj.Name,
                RestaurantId = obj.RestaurantId,
                DishId = obj.DishId,
                Price = obj.Price

            })
        .Build();
            return Json(resp, JsonRequestBehavior.AllowGet);
        }
    }
}