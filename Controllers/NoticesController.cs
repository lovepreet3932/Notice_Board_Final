using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Student_Notice_Board_Final.Models;

namespace Student_Notice_Board_Final.Controllers
{
   
    public class NoticesController : Controller
    {
        private readonly Student_Notice_BoardContext _context;

        public NoticesController(Student_Notice_BoardContext context)
        {
            _context = context;
        }

        // GET: Notices
        [Authorize(Roles = "notice_admin,student")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Notice.ToListAsync());
        }

        // GET: Notices/Details/5
        [Authorize(Roles = "notice_admin,student")]
        public async Task<IActionResult> Details(int? id)
        {
            if (User.IsInRole("student")) {

                //Write the notice viewed record
                var user = (from student in _context.Student
                            where student.StudentEmail.Equals(User.Identity.Name)
                            select student).FirstOrDefault();

                NoticeView view = new NoticeView();

                view.StudentId = user.Id;
                view.NoticeId = id.GetValueOrDefault();
                var noticeViews = (from views in _context.NoticeView
                            where views.StudentId == user.Id && views.NoticeId == id.GetValueOrDefault()
                                   select views).ToList();

                if (noticeViews.Count == 0) {

                    _context.Add(view);
                    await _context.SaveChangesAsync();


                }


            }


            if (id == null)
            {
                return NotFound();
            }

            var notice = await _context.Notice
                .FirstOrDefaultAsync(m => m.Id == id);
            if (notice == null)
            {
                return NotFound();
            }

            return View(notice);
        }

        [Authorize(Roles = "notice_admin")]
        // GET: Notices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Notices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "notice_admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NoticeTitle,NoticeInformation")] Notice notice)
        {
            if (ModelState.IsValid)
            {
                _context.Add(notice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(notice);
        }

        // GET: Notices/Edit/5

        [Authorize(Roles = "notice_admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notice = await _context.Notice.FindAsync(id);
            if (notice == null)
            {
                return NotFound();
            }
            return View(notice);
        }

        // POST: Notices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "notice_admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NoticeTitle,NoticeInformation")] Notice notice)
        {
            if (id != notice.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(notice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NoticeExists(notice.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(notice);
        }

        // GET: Notices/Delete/5
        [Authorize(Roles = "notice_admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notice = await _context.Notice
                .FirstOrDefaultAsync(m => m.Id == id);
            if (notice == null)
            {
                return NotFound();
            }

            return View(notice);
        }

        // POST: Notices/Delete/5
        [Authorize(Roles = "notice_admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var notice = await _context.Notice.FindAsync(id);
            _context.Notice.Remove(notice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NoticeExists(int id)
        {
            return _context.Notice.Any(e => e.Id == id);
        }
    }
}
