using AutoMapper;
using ProjetoDotNetUnidade2.Infra.Data.Repositorios;
using ProjetoDotNetUnidade2.MVC.DDD.ViewModels;
using ProjetoDotNetUnidade2DDD.dominio.Entidades;
using System.Collections.Generic;
using System.Web.Mvc;

// CRUD de Clientes
namespace ProjetoDotNetUnidade2.MVC.DDD.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ClienteRepositorio _clienteRepositorio = new ClienteRepositorio();

        // GET: Clientes
        public ActionResult Index()
        {
            // Transforma a coleção de clientes em cliente de Model
            var clienteViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteRepositorio.GetAll());
            //Devolve para o Index
            return View(clienteViewModel);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(cliente);
                _clienteRepositorio.Add(clienteDomain);

                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
