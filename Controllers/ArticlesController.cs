using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ArticlesController:Controller
    {
        public ActionResult ById(string name)
        {
            var viewModel = new DataViewModels();
            viewModel.ParameterValue = name;
            return this.View(viewModel);
        }
    }
}