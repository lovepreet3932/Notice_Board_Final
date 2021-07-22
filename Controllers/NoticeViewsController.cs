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
    [Authorize(Roles = "notice_admin")]
    public class NoticeViewsController : Controller
    {
        private readonly Student_Notice_BoardContext _context;

        public NoticeViewsController(Student_Notice_BoardContext context)
        {
            _context = context;
        }

        // GET: NoticeViews
        public async Task<IActionResult> Index()
        {
            var student_Notice_BoardContext = _context.NoticeView.Include(n => n.Notice).Include(n => n.Student);
            return View(await student_Notice_BoardContext.ToListAsync());
        }

        // GET: NoticeViews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var noticeView = await _context.NoticeView
                .Include(n => n.Notice)
                .Include(n => n.Student)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (noticeView == null)
            {
                return NotFound();
            }

            return View(noticeView);
        }

        // GET: NoticeViews/Create
        public IActionResult Create()
        {
            ViewData["NoticeId"] = new SelectList(_context.Notice, "Id", "Id");
            ViewData["StudentId"] = new SelectList(_context.Set<Student>(), "Id", "Id");
            return View();
        }

        // POST: NoticeViews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NoticeId,StudentId")] NoticeView noticeView)
        {
            if (ModelState.IsValid)
            {
                _context.Add(noticeView);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["NoticeId"] = new SelectList(_context.Notice, "Id", "Id", noticeView.NoticeId);
            ViewData["StudentId"] = new SelectList(_context.Set<Student>(), "Id", "Id", noticeView.StudentId);
            return View(noticeView);
        }

        // GET: NoticeViews/Edit/5
       

        // POST: NoticeViews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NoticeId,StudentId")] NoticeView noticeView)
        {
            if (id != noticeView.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(noticeView);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NoticeViewExists(noticeView.Id))
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
            ViewData["NoticeId"] = new SelectList(_context.Notice, "Id", "Id", noticeView.NoticeId);
            ViewData["StudentId"] = new SelectList(_context.Set<Student>(), "Id", "Id", noticeView.StudentId);
            return View(noticeView);
        }

        // GET: NoticeViews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var noticeView = await _context.NoticeView
                .Include(n => n.Notice)
                .Include(n => n.Student)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (noticeView == null)
            {
                return NotFound();
            }

            return View(noticeView);
        }

        // POST: NoticeViews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var noticeView = await _context.NoticeView.FindAsync(id);
            _context.NoticeView.Remove(noticeView);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NoticeViewExists(int id)
        {
            return _context.NoticeView.Any(e => e.Id == id);
        }
    }
}
