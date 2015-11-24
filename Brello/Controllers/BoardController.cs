﻿using Brello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace Brello.Controllers
{
    public class BoardController : Controller
    {
        private BoardRepository repository;
        //private Mock<>

        public BoardController()
        {
            repository = new BoardRepository();
        }

        public BoardController(BoardRepository _repo)
        {
            repository = _repo;
        }

        // GET: Board
        [Authorize]
        public ActionResult Index()
        {
<<<<<<< HEAD
            // UserManger<ApplicationUser> manager =.Identity.GetUserId();
           UserManager<ApplicationUser> manager =  HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
           ApplicationUser me =  manager.FindById(User.Identity.GetUserId());
=======
            //UserManager<ApplicationUser> manager = new UserManager<ApplicationUser>();
            UserManager<ApplicationUser> manager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            ApplicationUser me = manager.FindById(User.Identity.GetUserId());
>>>>>>> 780784439ff333ec8eefc1857ee45d938ce4ca45

            List<Board> boards = repository.GetBoards(me);
            Board my_board = null;
            if (boards.Count() == 0)
            {
<<<<<<< HEAD
                my_board = repository.CreateBoard("My Board", me);
=======
                 my_board = repository.CreateBoard("My Board", me);
>>>>>>> 780784439ff333ec8eefc1857ee45d938ce4ca45
            } else
            {
                my_board = boards.First();
            }
<<<<<<< HEAD

            repository.CreateBoard("My Board", me);
            //ViewBag.Boards = repository.GetAllBoards();
            ViewBag.Title = my_board.Title;

           // bool succesful = repository.AddList(my_board.BoardId, new BrelloList { Title = "ToDo" });

            List<BrelloList> board_lists = repository.GetAllLists(my_board.BoardId);

            
             
=======
            ViewBag.Title = my_board.Title;

            //bool successful = repository.AddList(my_board.BoardId, new BrelloList { Title = "ToDo" });

            List<BrelloList> board_lists = repository.GetAllLists(my_board.BoardId);

>>>>>>> 780784439ff333ec8eefc1857ee45d938ce4ca45
            return View(board_lists);
        }

        // GET: Board/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Board/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Board/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Board/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Board/Edit/5
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

        // GET: Board/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Board/Delete/5
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
