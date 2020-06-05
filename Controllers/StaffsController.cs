using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SalaryApp.Data;
using System.Web;  
using SalaryApp.Models.SalaryAppViewModels;
using SalaryApp.Models;
using System.Text.Encodings.Web;


namespace SalaryApp.Controllers
{
    public class StaffsController : Controller
    {
        private readonly SalaryAppContext _context;

        public StaffsController(SalaryAppContext context){
            _context = context;
        }


        //Show full information, total salary and search(Id, Name, Email, Regency)
        public async Task<IActionResult> Index(string searchString)
        {   
            var viewModel = new InstructorIndexData();
                viewModel.staffs = await _context.Staffs
                    .Include(i => i.Salaries)
                        .ThenInclude(i => i.Overtimes)
                    .Include(i => i.Salaries)
                        .ThenInclude(i => i.Allowances)
                    .AsNoTracking()
                    .OrderBy(i => i.StaffId)
                    .ToListAsync();
            if(searchString != null)
            {
                ViewData["CurrentFilter"] = searchString;
    
                if (!String.IsNullOrEmpty(searchString))
                {
                    viewModel.staffs = viewModel.staffs.Where(s => s.StaffId.Contains(searchString) || s.Name.Contains(searchString) || s.Email.Contains(searchString)  || s.Regency.Contains(searchString));
                }
                return View(viewModel);
            }
            else{
                return View(viewModel);
            }
        }

        //Show Salary, Allowance, Overtime
        public async Task<IActionResult> Details(string StaffId)
        {
            var viewModel = new InstructorIndexData();
            viewModel.staffs = await _context.Staffs
                .Include(i => i.Salaries)
                    .ThenInclude(i => i.Overtimes)
                .Include(i => i.Salaries)
                    .ThenInclude(i => i.Allowances)
                .AsNoTracking()
                .ToListAsync();

            if(StaffId != null){
                ViewData["StaffId"] = StaffId;
                // Salary salary = viewModel.salaries
                //     .Where(i => i.StaffId == StaffId.ToString()).Single();
            }
            return View(viewModel);
        }

        //Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StaffId,Name,dayIn,Regency,Email")] Staff staff)
        {
            if (ModelState.IsValid)
            {
                _context.Add(staff);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(staff);
        }

        //Edit
        private void PopulateDepartmentsDropDownList(object selectedStaff = null)
        {
            var staffsQuery = from d in _context.Staffs
                                   orderby d.Name
                                   select d;
            ViewBag.StaffID = new SelectList(staffsQuery.AsNoTracking(), "StaffId", "Name", selectedStaff);
        }
        public async Task<IActionResult> Edit(string staffid)
        {
            if (staffid == null)
            {
                return NotFound();
            }

            var staff = await _context.Staffs
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.StaffId == staffid);
            if (staff == null)
            {
                return NotFound();
            }
            PopulateDepartmentsDropDownList(staff.StaffId);
            return View(staff);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(string staffid)
        {
            if (staffid == null)
            {
                return NotFound();
            }

            var staffToUpdate = await _context.Staffs
                .FirstOrDefaultAsync(c => c.StaffId == staffid);

            if (await TryUpdateModelAsync<Staff>(staffToUpdate,
                "",
                c => c.StaffId, c => c.Name, c => c.dayIn, c => c.Regency, c => c.Email))
            {
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException /* ex */)
                {
                    //Log the error (uncomment ex variable name and write a log.)
                    ModelState.AddModelError("", "Unable to save changes. " +
                        "Try again, and if the problem persists, " +
                        "see your system administrator.");
                }
                return RedirectToAction(nameof(Index));
            }
            PopulateDepartmentsDropDownList(staffToUpdate.StaffId);
            return View(staffToUpdate);
        }
        //Delete
        public async Task<IActionResult> Delete(string staffid)
        {
            if (staffid == null)
            {
                return NotFound();
            }

            var staff = await _context.Staffs
                .FirstOrDefaultAsync(m => m.StaffId == staffid);
            if (staff == null)
            {
                return NotFound();
            }

            return View(staff);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string staffid)
        {
            var staff = await _context.Staffs.FindAsync(staffid);
            _context.Staffs.Remove(staff);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}