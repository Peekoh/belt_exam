using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using belt_exam.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace belt_exam.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext c)
        {
            dbContext = c;
        }
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }

        /* LOGIN REG */
        [HttpPost("Register")]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                if (dbContext.users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use");
                    return View("Index");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    user.Password = Hasher.HashPassword(user, user.Password);
                    dbContext.users.Add(user);
                    dbContext.SaveChanges();
                    HttpContext.Session.SetInt32("user", user.id);
                    return Redirect("Home");
                }
            }
            else
            {
                return View("Index");
            }
        }
        [HttpPost("Login")]
        public IActionResult Login(LoginCheck check)
        {
            if (ModelState.IsValid)
            {
                var inDB = dbContext.users.FirstOrDefault(u => u.Email == check.LoginEmail);
                if (inDB == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Index");
                }
                var hasher = new PasswordHasher<LoginCheck>();
                var result = hasher.VerifyHashedPassword(check, inDB.Password, check.LoginPassword);
                if (result == 0)
                {
                    ModelState.AddModelError("Password", "Invalid Password");
                }
                //if success
                HttpContext.Session.SetInt32("user", inDB.id);
                return Redirect("Home");
            }
            else
            {

                return View("Index");
            }
        }
        [HttpGet("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/");
        }

        /* HOME */
        [HttpGet("Home")]
        public IActionResult Home()
        {
            if (HttpContext.Session.GetInt32("user") == null)
            {
                return Redirect("/");
            }
            User user = dbContext.users.FirstOrDefault(u => u.id == HttpContext.Session.GetInt32("user"));
            List<Event> events = dbContext.events
            .Include(e => e.Participants)
            .ThenInclude(p => p.User)
            .ThenInclude(e => e.RSVPS)
            .OrderByDescending(e => e.CreatedAt)
            .ToList();
            foreach(var e in events){
                System.Console.WriteLine(e.Title);
            }
            ViewBag.User = user;
            return View(events);
        }
        /* NEW EVENT */
        [HttpGet("New")]
        public IActionResult New()
        {
            if (HttpContext.Session.GetInt32("user") == null)
            {
                return Redirect("/");
            }
            User user = dbContext.users.FirstOrDefault(u => u.id == HttpContext.Session.GetInt32("user"));
            ViewBag.User = user;
            return View();
        }
        [HttpPost("New")]
        public IActionResult CreateNew(Event e, string dd)
        {
            string duration = (String)e.Duration;
            duration += $" {dd}";
            e.Duration = duration;
            User us = dbContext.users.FirstOrDefault(u => u.id == HttpContext.Session.GetInt32("user"));
            e.Creator = us.Alias;
            if (e.Date < DateTime.Now)
            {
                ModelState.AddModelError("Date", "Date must be in the future!");
                return View("New");

            }
            if (ModelState.IsValid)
            {
                dbContext.events.Add(e);
                dbContext.SaveChanges();
                return Redirect("Home");
            }
            else
            {
                return View("New");
            }
        }
        /* EVENT ACTIONS */
        [HttpGet("Delete/{eid}")]
        public IActionResult Delete(int eid)
        {
            Event ev = dbContext.events.FirstOrDefault(e => e.EventId == eid);
            dbContext.events.Remove(ev);
            dbContext.SaveChanges();
            return RedirectToAction("Home");
        }
        [HttpGet("Join/{eeid}")]
        public IActionResult Join(int eeid)
        {
            System.Console.WriteLine("EID");
            System.Console.WriteLine(eeid);
            RSVP rsvp = new RSVP();
            Event ev = dbContext.events.FirstOrDefault(e => e.EventId == eeid);
            User user = dbContext.users.FirstOrDefault(u => u.id == HttpContext.Session.GetInt32("user"));
          System.Console.WriteLine("TEST");
            rsvp.Event = ev;
            rsvp.User = user;
            dbContext.rsvps.Add(rsvp);
            dbContext.SaveChanges();
            return Redirect("/Home");
        }
        [HttpGet("Leave/{eid}")]
        public IActionResult Leave(int eid)
        {
            Event ev = dbContext.events.FirstOrDefault(e => e.EventId == eid);
            User user = dbContext.users.FirstOrDefault(u => u.id == HttpContext.Session.GetInt32("user"));
            RSVP rsvp = dbContext.rsvps.FirstOrDefault(r => r.Event == ev && r.User == user);
            // user.RSVPS.Remove(rsvp);
            //ev.Participants.Remove(rsvp);
            dbContext.rsvps.Remove(rsvp);
            dbContext.SaveChanges();
            return Redirect("/Home");
        }
        [HttpGet("View/{eid}")]
        public IActionResult ViewEvent(int eid)
        {
            User user = dbContext.users.FirstOrDefault(u => u.id == HttpContext.Session.GetInt32("user"));

            Event ev = dbContext.events
            .Include(e => e.Participants)
            .ThenInclude(r => r.User)
            .FirstOrDefault(e => e.EventId == eid);

            ViewBag.User = user;
            return View(ev);
        }

    }
}

