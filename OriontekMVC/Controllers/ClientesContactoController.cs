using API.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OriontekMVC.Models;

namespace OriontekMVC.Controllers
{
    public class ClientesContactoController : Controller
    {
        // GET: ClientesContactoController
        public async Task<ActionResult> Index()
        {
            var data = RequestAPI.GetAPIAsync("https://localhost:44341/api/ClienteContacto");
            return View(await data);
        }

        // GET: ClientesContactoController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var data = RequestAPI.GetOneAPIAsync("https://localhost:44341/api/ClienteContacto/"+ id);
            return View(await data);
        }

        // GET: ClientesContactoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientesContactoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteContactoDto collection)
        {
            try
            {
                _ = RequestAPI.PostAPIAsync("https://localhost:44341/api/ClienteContacto/", collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientesContactoController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var data = RequestAPI.GetOneAPIAsync("https://localhost:44341/api/ClienteContacto/" + id);
            return View(await data);
        }

        // POST: ClientesContactoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ClienteContactoDto collection)
        {
            try
            {
                _ = RequestAPI.PutAPIAsync("https://localhost:44341/api/ClienteContacto/" + id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientesContactoController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var data = RequestAPI.GetOneAPIAsync("https://localhost:44341/api/ClienteContacto/" + id);
            return View(await data);
        }

        // POST: ClientesContactoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ClienteContactoDto collection)
        {
            try
            {
                RequestAPI.DeleteAPIAsync("https://localhost:44341/api/ClienteContacto/" + id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
