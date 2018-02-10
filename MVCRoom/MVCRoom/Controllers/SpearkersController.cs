using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCRoom.Models;

namespace MVCRoom.Controllers
{
    public class SpearkersController : Controller
    {
        private ConfContext db = new ConfContext();

        // GET: Spearkers
        public async Task<ActionResult> Index()
        {
            var spearkers = db.Spearkers.Include(s => s.Room);
            return View(await spearkers.ToListAsync());
        }

        // GET: Spearkers/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Spearker spearker = await db.Spearkers.FindAsync(id);
            if (spearker == null)
            {
                return HttpNotFound();
            }
            return View(spearker);
        }

        // GET: Spearkers/Create
        public ActionResult Create()
        {
            ViewBag.RoomId = new SelectList(db.Rooms, "RoomId", "Name");
            return View();
        }

        // POST: Spearkers/Create
        // 초과 게시 공격으로부터 보호하려면 바인딩하려는 특정 속성을 사용하도록 설정하십시오. 
        // 자세한 내용은 https://go.microsoft.com/fwlink/?LinkId=317598을(를) 참조하십시오.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "RoomSpeakerId,Name,RoomId")] Spearker spearker)
        {
            if (ModelState.IsValid)
            {
                db.Spearkers.Add(spearker);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.RoomId = new SelectList(db.Rooms, "RoomId", "Name", spearker.RoomId);
            return View(spearker);
        }

        // GET: Spearkers/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Spearker spearker = await db.Spearkers.FindAsync(id);
            if (spearker == null)
            {
                return HttpNotFound();
            }
            ViewBag.RoomId = new SelectList(db.Rooms, "RoomId", "Name", spearker.RoomId);
            return View(spearker);
        }

        // POST: Spearkers/Edit/5
        // 초과 게시 공격으로부터 보호하려면 바인딩하려는 특정 속성을 사용하도록 설정하십시오. 
        // 자세한 내용은 https://go.microsoft.com/fwlink/?LinkId=317598을(를) 참조하십시오.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "RoomSpeakerId,Name,RoomId")] Spearker spearker)
        {
            if (ModelState.IsValid)
            {
                db.Entry(spearker).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.RoomId = new SelectList(db.Rooms, "RoomId", "Name", spearker.RoomId);
            return View(spearker);
        }

        // GET: Spearkers/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Spearker spearker = await db.Spearkers.FindAsync(id);
            if (spearker == null)
            {
                return HttpNotFound();
            }
            return View(spearker);
        }

        // POST: Spearkers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Spearker spearker = await db.Spearkers.FindAsync(id);
            db.Spearkers.Remove(spearker);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
