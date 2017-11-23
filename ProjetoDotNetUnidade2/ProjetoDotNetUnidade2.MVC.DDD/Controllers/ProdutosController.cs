using AutoMapper;
using ProjetoDotNetUnidade2.MVC.DDD.ViewModels;
using ProjetoDotNetUnidade2DDD.Aplicacao.Interface;
using ProjetoDotNetUnidade2DDD.dominio.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoDotNetUnidade2.MVC.DDD.Controllers
{
    public class ProdutosController : Controller
    {
        // Injeção de depedências de produto e cliente
        // GET: Produtos
        private readonly IProdutoAppServico _produtoApp;
        private readonly IClienteAppServico _clienteApp;

        public ProdutosController(IProdutoAppServico produtoApp, IClienteAppServico clienteApp)
        {
            _produtoApp = produtoApp;
            _clienteApp = clienteApp;
        }

        // GET: Cliente
        public ActionResult Index()
        {
            var produtoViewModel = Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoApp.GetAll());
            return View(produtoViewModel);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            var produto = _produtoApp.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);

            return View(produtoViewModel);
        }

        // GET: Ciente/Create
        public ActionResult Create()
        {
            ViewBag.ClienteID = new SelectList(_clienteApp.GetAll(), "ClienteID", "Nome");
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoViewModel produto)
        {
            if (ModelState.IsValid)
            {
                var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produto);
                _produtoApp.Add(produtoDomain);

                return RedirectToAction("Index");
            }
            ViewBag.ClienteID = new SelectList(_clienteApp.GetAll(), "ClienteID", "Nome", produto.ClienteID);
            return View(produto);
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            var produto = _produtoApp.GetById(id);
            var produtoviewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);

            ViewBag.ClienteID = new SelectList(_clienteApp.GetAll(), "ClienteID", "Nome", produtoviewModel.ClienteID);

            return View(produtoviewModel);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProdutoViewModel produto)
        {
            if (ModelState.IsValid)
            {
                var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produto);
                _produtoApp.Update(produtoDomain);

                return RedirectToAction("Index");
            }
            ViewBag.ClienteID = new SelectList(_clienteApp.GetAll(), "ClienteID", "Nome", produto.ClienteID);
            return View(produto);
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            var produto = _produtoApp.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);

            return View(produtoViewModel);
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            var produto = _produtoApp.GetById(id);
            _produtoApp.Remove(produto);

            return RedirectToAction("Index");
        }
    }
}
