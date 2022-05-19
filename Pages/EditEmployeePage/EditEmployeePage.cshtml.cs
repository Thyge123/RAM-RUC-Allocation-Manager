using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RAM___RUC_Allocation_Manager.MockData;
using RAM___RUC_Allocation_Manager.Models;
using RAM___RUC_Allocation_Manager.Models.DbConnections;
using RAM___RUC_Allocation_Manager.Models.WorkAssigments;
using RAM___RUC_Allocation_Manager.Services;

namespace RAM___RUC_Allocation_Manager.Pages.EditEmployeePage
{
    public class EditEmployeePageModel : PageModel
    {

        #region Fields
        public UserService userService;
        #endregion

        #region Properties

        public List<User> Users { get; set; }

        [BindProperty]
        public Employee EmployeeToEdit { get; set; }

        public bool IsLeader { get; set; }
        #endregion

        public EditEmployeePageModel(UserService userService)
        {
            this.userService = userService;

        }

        #region Methods
        public IActionResult OnGet(int id)
        {
            Users = userService.GetUsers();
            EmployeeToEdit = (Employee)userService.GetUserByID(id);
            
            if (EmployeeToEdit == null)
                return RedirectToPage("/NotFound"); 

            return Page();
        }

        public IActionResult OnPost()
        {
            userService.EditUser(EmployeeToEdit);
            return RedirectToPage("/LeaderLandingPage/LeaderLandingPage");
        }
        #endregion
    }
}
