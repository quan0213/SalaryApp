using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SalaryApp.Data;
using System.Web;  
using SalaryApp.Models.SalaryViewModels;


namespace SalaryApp.Controllers
{
    public class StaffsController : Controller
    {
        private readonly SalaryAppContext _context;

        public StaffsController(SalaryAppContext context){
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new InstructorIndexData();
            viewModel.Staffs = await _context.Staffs
                .Include(i => i.Salaries)
                .AsNoTracking()
                .OrderBy(i => i.Name)
                .ToListAsync();
            return View(viewModel);
        }

    }
}