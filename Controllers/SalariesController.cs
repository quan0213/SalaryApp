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
    public class SalariesController : Controller
    {
        private readonly SalaryAppContext _context;

        public SalariesController(SalaryAppContext context){
            _context = context;
        }
        //Show Salary, Allowance, Overtime
        public async Task<IActionResult> Index(string StaffId)
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
                // Salary salary = viewModel.salaries
                //     .Where(i => i.StaffId == StaffId.ToString()).Single();
            }
            return View(viewModel);
        }
    }
}