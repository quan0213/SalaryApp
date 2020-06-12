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
using Microsoft.Docs.Samples;

namespace SalaryApp.Controllers
{
    public class SalariesController : Controller
    {
        private readonly SalaryAppContext _context;

        public SalariesController(SalaryAppContext context){
            _context = context;
        }
        //Show Salary, Allowance, Overtime
        public async Task<IActionResult> Index(int? StaffId)
        {
            var viewModel = new InstructorIndexData();
            viewModel.staffs = await _context.Staffs
                .Include(i => i.Salaries)
                    .ThenInclude(i => i.Overtimes)
                        .ThenInclude(i => i.Allowance)
                .AsNoTracking()
                .ToListAsync();

            if(StaffId != null){
                ViewData["StaffId"] = StaffId;
            }
            return View(viewModel);
        }
        public IActionResult Create(int staffid)
        {
            ViewData["StaffId"] = staffid; 
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StaffId,basicSalary,chargeInsurrance,chargeTax,dayTake,keepSalary,supportCash,totalSalary")] Salary salary)
        {
            if (ModelState.IsValid)
            {
                // Console.WriteLine(ViewData["StaffId"]);
                _context.Add(salary);
                await _context.SaveChangesAsync();
                return RedirectToAction("CreateOvertime","Salaries",new{@staffid = salary.StaffId,@salaryid = salary.SalaryId});
            }
            
            return View(salary);
        }

        public IActionResult CreateOvertime(int staffid,int salaryid)
        {
            ViewData["StaffId"] = staffid;
            ViewData["SalaryId"] = salaryid;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOvertime([Bind("SalaryId,dayOff,overtimeHours,overtimeSalary,staffTerm")] Overtime overtime)
        {
            if (ModelState.IsValid)
            {
                _context.Overtimes.Add(overtime);
                await _context.SaveChangesAsync();
                return RedirectToAction("CreateAllowance","Salaries",new{@staffid = overtime.staffTerm,@overtimeid = overtime.OverTimeId});
            }  
            return View(overtime);
        }

        public IActionResult CreateAllowance(int staffid,int overtimeid)
        {
            ViewData["StaffId"] = staffid;
            ViewData["OvertimeId"] = overtimeid;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAllowance([Bind("OvertimeId,bonusKPI,uniformsCharge,phoneCharge,lunchCharge,staffTerm")] Allowance allowance)
        {
            if (ModelState.IsValid)
            {
                _context.Allowances.Add(allowance);
                await _context.SaveChangesAsync();
                return RedirectToAction("index","Salaries",new{@staffid = allowance.staffTerm});
            }  
            return View(allowance);
        }

        //DeleteEntity
        public async Task<IActionResult> Delete(int? overtimeid)
        {
            if (overtimeid == null)
            {
                return NotFound();
            }

            var overtime = await _context.Overtimes
                .FirstOrDefaultAsync(m => m.OverTimeId == overtimeid);
            if (overtime == null)
            {
                return NotFound();
            }

            return View(overtime);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int overtimeid)
        {
            var overtime = await _context.Overtimes.FindAsync(overtimeid);
            var staffid = overtime.staffTerm;
            var salary = await _context.Salaries.FindAsync(overtime.SalaryId);
            _context.Overtimes.Remove(overtime);
            if(salary.Overtimes == null){
                _context.Salaries.Remove(salary);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("index","Salaries",new{@staffid = staffid});
        }
    }
}